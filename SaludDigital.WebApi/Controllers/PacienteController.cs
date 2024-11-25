using Microsoft.AspNetCore.Mvc;
using Logica;
using Entidades;

namespace SaludDigital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly PacienteBLL _pacienteBLL;

        public PacienteController(PacienteBLL pacienteBLL)
        {
            _pacienteBLL = pacienteBLL;
        }

        [HttpGet("por-usuario/{idUsuario}")]
        public IActionResult ObtenerPacientePorUsuario(int idUsuario)
        {
            try
            {
                var paciente = _pacienteBLL.ObtenerPacientePorIdUsuario(idUsuario);
                if (paciente == null)
                {
                    return NotFound(new { success = false, message = "No se encontró el paciente" });
                }
                return Ok(new { success = true, data = paciente });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
    }
}