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
                _logger.LogInformation($"Especialidades obtenidas: {especialidades.Count}");

                return Ok(new
                {
                    success = true,
                    data = especialidades
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo especialidades");
                return BadRequest(new
                {
                    success = false,
                    message = "Error al obtener especialidades: " + ex.Message
                });
            }
        }

        // Endpoint de prueba para verificar que el controlador está funcionando
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok(new { message = "Controlador de Especialidades funcionando" });
        }
    }
}