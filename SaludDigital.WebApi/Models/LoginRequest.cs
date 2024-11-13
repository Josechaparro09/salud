namespace SaludDigital.WebApi.Models
{
    public class LoginRequest
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
    }

    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string RedirectUrl { get; set; }
        public UserInfo Usuario { get; set; }
    }

    public class UserInfo
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public RolInfo Rol { get; set; }
    }

    public class RolInfo
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
    }
}