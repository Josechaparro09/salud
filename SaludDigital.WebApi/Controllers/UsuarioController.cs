using Microsoft.AspNetCore.Mvc;
using Logica;
using Entidades;

namespace SaludDigital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioBLL _usuarioBLL;

        public UsuarioController(UsuarioBLL usuarioBLL)
        {
            _usuarioBLL = usuarioBLL;
        }

        [HttpPost("registro-paciente")]
        public IActionResult RegistrarPaciente([FromBody] RegistroPacienteRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Nombres) ||
                    string.IsNullOrEmpty(request.Apellidos) ||
                    string.IsNullOrEmpty(request.NombreUsuario) ||
                    string.IsNullOrEmpty(request.Contraseña))
                {
                    return BadRequest(new { success = false, message = "Todos los campos son requeridos" });
                }

                var usuario = _usuarioBLL.RegistrarNuevoUsuarioPaciente(
                    request.Nombres,
                    request.Apellidos,
                    request.NombreUsuario,
                    request.Contraseña,
                    request.Sexo
                );

                return Ok(new
                {
                    success = true,
                    message = "Registro exitoso",
                    data = new
                    {
                        idUsuario = usuario.IdUsuario,
                        nombres = usuario.Nombres,
                        apellidos = usuario.Apellidos,
                        nombreUsuario = usuario.NombreUsuario,
                        sexo = usuario.Sexo,
                    }
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
    }

    public class RegistroPacienteRequest
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Sexo { get; set; }
    }
}