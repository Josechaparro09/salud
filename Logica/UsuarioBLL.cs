using System;
using System.Collections.Generic;

using Datos;
using Entidades;

namespace Logica
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            try
            {
                return usuarioDAL.ValidarUsuario(nombreUsuario, contraseña);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al iniciar sesión: " + ex.Message);
            }
        }

            public string RegistrarUsuario(string nombres, string apellidos, string nombreUsuario, string contrasena, int? idRol, string sexo = null)
        {
            if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return "Por favor, complete todos los campos.";
            }

            try
            {
                var usuarios = usuarioDAL.ObtenerUsuarios();

                foreach (var usuario in usuarios)
                {
                    if (usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase))
                    {
                        return "El nombre de usuario ya existe.";
                    }
                }

                var nuevoUsuario = new Usuario
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    NombreUsuario = nombreUsuario,
                    Contraseña = contrasena,
                    Rol = idRol.HasValue ? new Rol { IdRol = idRol.Value } : null,
                    Sexo = sexo
                };

                usuarioDAL.GuardarUsuario(nuevoUsuario);
                return "Registro exitoso.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el usuario: " + ex.Message);
            }
        }
        public Usuario RegistrarNuevoUsuarioPaciente(string nombres, string apellidos, string nombreUsuario, string contraseña, string sexo = null)
        {
            var usuario = new Usuario
            {
                Nombres = nombres,
                Apellidos = apellidos,
                NombreUsuario = nombreUsuario,
                Contraseña = contraseña,
                Rol = new Rol { IdRol = 21 },
                Sexo= sexo
            };

            try
            {
                var usuarioDAL = new UsuarioDAL();
                return usuarioDAL.RegistrarUsuarioYPaciente(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el registro: " + ex.Message);
            }
        }

        public string ActualizarUsuario(int idUsuario, string nombres, string apellidos, string nombreUsuario, string contrasena, int? idRol, string sexo = null)
        {
            if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return "Por favor, complete todos los campos.";
            }

            try
            {
                var usuario = new Usuario
                {
                    IdUsuario = idUsuario,
                    Nombres = nombres,
                    Apellidos = apellidos,
                    NombreUsuario = nombreUsuario,
                    Contraseña = contrasena,
                    Rol = idRol.HasValue ? new Rol { IdRol = idRol.Value } : null,
                    Sexo = sexo
                };

                usuarioDAL.ActualizarUsuario(usuario);
                return "Actualización exitosa.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el usuario: " + ex.Message);
            }
        }

        public string EliminarUsuario(int idUsuario)
        {
            try
            {
                usuarioDAL.EliminarUsuario(idUsuario);
                return "Usuario eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario: " + ex.Message);
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            try
            {
                return usuarioDAL.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los usuarios: " + ex.Message);
            }
        }
    }
}
