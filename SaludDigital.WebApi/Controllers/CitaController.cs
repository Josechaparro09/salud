using Microsoft.AspNetCore.Mvc;
using Logica;
using Entidades;
using System;
using System.Collections.Generic;

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

        [HttpGet("horarios-disponibles")]
        public IActionResult ObtenerHorariosDisponibles([FromQuery] int idDoctor, [FromQuery] DateTime fecha)
        {
            try
            {
                var horarios = _citaBLL.ObtenerHorariosDisponibles(idDoctor, fecha);
                return Ok(new { success = true, data = horarios });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult RegistrarCita([FromBody] Cita cita)
        {
            try
            {
                var resultado = _citaBLL.RegistrarCita(cita);
                return Ok(new { success = true, message = resultado });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [HttpGet("mis-citas")]
        public IActionResult ObtenerCitasPaciente([FromQuery] int idPaciente)
        {
            try
            {
                var citas = _citaBLL.ObtenerCitas().FindAll(c => c.Paciente.IdPaciente == idPaciente);
                return Ok(new { success = true, data = citas });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
    }
}