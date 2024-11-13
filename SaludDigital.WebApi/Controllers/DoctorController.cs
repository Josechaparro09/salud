using Microsoft.AspNetCore.Mvc;
using Logica;
using System;

namespace SaludDigital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorBLL _doctorBLL;
        private readonly ILogger<DoctorController> _logger;

        public DoctorController(DoctorBLL doctorBLL, ILogger<DoctorController> logger)
        {
            _doctorBLL = doctorBLL;
            _logger = logger;
        }

        [HttpGet("por-especialidad/{idEspecialidad}")]
        public IActionResult GetDoctoresPorEspecialidad(int idEspecialidad)
        {
            try
            {
                _logger.LogInformation($"Obteniendo doctores para especialidad: {idEspecialidad}");
                var doctores = _doctorBLL.ObtenerDoctoresPorEspecialidad(idEspecialidad);

                return Ok(new
                {
                    success = true,
                    data = doctores
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al obtener doctores para especialidad: {idEspecialidad}");
                return BadRequest(new
                {
                    success = false,
                    message = "Error al obtener doctores: " + ex.Message
                });
            }
        }
    }
}