using Microsoft.AspNetCore.Mvc;
using Logica;
using System;
using System.Collections.Generic;
using Entidades;

namespace SaludDigital.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadController : ControllerBase
    {
        private readonly EspecialidadBLL _especialidadBLL;
        private readonly ILogger<EspecialidadController> _logger;

        public EspecialidadController(EspecialidadBLL especialidadBLL, ILogger<EspecialidadController> logger)
        {
            _especialidadBLL = especialidadBLL;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _logger.LogInformation("Iniciando obtención de especialidades");

                var especialidades = _especialidadBLL.ObtenerEspecialidades();

                _logger.LogInformation($"Se encontraron {especialidades.Count} especialidades");

                if (especialidades.Count == 0)
                {
                    _logger.LogWarning("No se encontraron especialidades en la base de datos");
                    return Ok(new { success = true, data = new List<Especialidad>() });
                }

                foreach (var esp in especialidades)
                {
                    _logger.LogDebug($"Especialidad encontrada: ID={esp.IdEspecialidad}, Nombre={esp.NombreEspecialidad}");
                }

                return Ok(new
                {
                    success = true,
                    data = especialidades
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo especialidades");
                return StatusCode(500, new
                {
                    success = false,
                    message = "Error al obtener especialidades: " + ex.Message,
                    details = ex.StackTrace
                });
            }
        }
    }
}