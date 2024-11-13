using Microsoft.AspNetCore.Mvc;
using Logica;
using System;

namespace SaludDigital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UsuarioBLL _usuarioBLL;
        private readonly ILogger<LoginController> _logger;

        public LoginController(UsuarioBLL usuarioBLL, ILogger<LoginController> logger)
        {
            _usuarioBLL = usuarioBLL;
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Login([FromBody] LoginRequest request)
        {
            try
            {
                _logger.LogInformation($"Intento de login para usuario: {request.NombreUsuario}");

                if (request == null || string.IsNullOrEmpty(request.NombreUsuario) || string.IsNullOrEmpty(request.Contraseña))
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Usuario y contraseña son requeridos"
                    });
                }

                var usuario = _usuarioBLL.IniciarSesion(request.NombreUsuario, request.Contraseña);

                if (usuario == null)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Usuario o contraseña incorrectos"
                    });
                }

                // Determinar la URL de redirección según el rol
                string redirectUrl = usuario.Rol?.IdRol switch
                {
                    21 => "/paciente.html",  // Rol Paciente
                    1 => "/admin.html",      // Rol Admin
                    _ => "/dashboard.html"   // Otros roles
                };

                return Ok(new
                {
                    success = true,
                    message = "Login exitoso",
                    redirectUrl = redirectUrl,
                    usuario = new
                    {
                        idUsuario = usuario.IdUsuario,
                        nombres = usuario.Nombres,
                        apellidos = usuario.Apellidos,
                        nombreUsuario = usuario.NombreUsuario,
                        rol = new
                        {
                            idRol = usuario.Rol?.IdRol,
                            nombreRol = usuario.Rol?.NombreRol
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en el proceso de login");
                return StatusCode(500, new
                {
                    success = false,
                    message = "Error en el servidor: " + ex.Message
                });
            }
        }
    }

    public class LoginRequest
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
    }
}