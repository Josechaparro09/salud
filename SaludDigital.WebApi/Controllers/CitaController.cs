using Microsoft.AspNetCore.Mvc;
using Logica;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaludDigital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly CitaBLL _citaBLL;

        public CitaController(CitaBLL citaBLL)
        {
            _citaBLL = citaBLL;
        }

        [HttpGet("{id}/mis-citas")]
        public IActionResult ObtenerCitasPaciente(int id)
        {
            try
            {
                // Obtener el ID del paciente del token o sesión actual
                var idPaciente = id;
                if (idPaciente <= 0)
                {
                    return Unauthorized(new { success = false, message = "Usuario no autorizado" });
                }

                var citas = _citaBLL.ObtenerCitas()
                    .Where(c => c.Paciente.IdPaciente == idPaciente)
                    .OrderByDescending(c => c.FechaCita)
                    .ThenBy(c => c.HoraCita)
                    .ToList();

                return Ok(new { success = true, data = citas });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = "Error al obtener las citas: " + ex.Message });
            }
        }

        [HttpGet("horarios-disponibles")]
        public IActionResult ObtenerHorariosDisponibles([FromQuery] int idDoctor, [FromQuery] DateTime fecha)
        {
            try
            {
                if (idDoctor <= 0)
                {
                    return BadRequest(new { success = false, message = "ID de doctor inválido" });
                }

                if (fecha.Date < DateTime.Now.Date)
                {
                    return BadRequest(new { success = false, message = "La fecha no puede ser anterior a hoy" });
                }

                var horarios = _citaBLL.ObtenerHorariosDisponibles(idDoctor, fecha);

                return Ok(new { success = true, data = horarios });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = "Error al obtener horarios: " + ex.Message });
            }
        }
        public class CitaRequest
        {
            public Cita cita { get; set; }
        }
        [HttpPost]
        public IActionResult RegistrarCita([FromBody] CitaRequest request)
        {
            try
            {
                if (request?.cita == null)
                {
                    return BadRequest(new { success = false, message = "Datos de cita inválidos" });
                }

                // Validar que la fecha no sea anterior a hoy
                if (request.cita.FechaCita.Date < DateTime.Now.Date)
                {
                    return BadRequest(new { success = false, message = "La fecha de la cita no puede ser anterior a hoy" });
                }

                // Establecer estado inicial
                request.cita.Estado = "Pendiente";

                var resultado = _citaBLL.RegistrarCita(request.cita);

                if (resultado.StartsWith("Error") || resultado.Contains("campos requeridos"))
                {
                    return BadRequest(new { success = false, message = resultado });
                }

                return Ok(new { success = true, message = resultado });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = "Error al registrar la cita: " + ex.Message });
            }
        }

        [HttpPut("{id}/cancelar")]
        public IActionResult CancelarCita(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { success = false, message = "ID de cita inválido" });
                }

                var idPaciente = ObtenerIdPacienteActual();
                var cita = _citaBLL.ObtenerCitas().FirstOrDefault(c => c.IdCita == id);

                if (cita == null)
                {
                    return NotFound(new { success = false, message = "Cita no encontrada" });
                }

                if (cita.Paciente.IdPaciente != idPaciente)
                {
                    return Unauthorized(new { success = false, message = "No autorizado para cancelar esta cita" });
                }

                if (cita.Estado != "Pendiente")
                {
                    return BadRequest(new { success = false, message = "Solo se pueden cancelar citas pendientes" });
                }

                cita.Estado = "Cancelada";
                _citaBLL.ActualizarCita(cita);

                return Ok(new { success = true, message = "Cita cancelada exitosamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = "Error al cancelar la cita: " + ex.Message });
            }
        }


        private int ObtenerIdPacienteActual()
        {
            // TODO: Implementar la lógica para obtener el ID del paciente del token/sesión actual
            // Por ahora, puedes usar un valor hardcodeado para pruebas
            return 341; // Reemplazar con la lógica real
        }
    }
}