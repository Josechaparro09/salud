using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario

    {

        public int? IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public Rol Rol { get; set; }
        public string Sexo { get; set; }

        public Usuario() { }

        public Usuario(string nombres, string apellidos, string nombreUsuario, string contraseña, Rol rol, string sexo = null)
        {
            IdUsuario = null;
            Nombres = nombres;
            Apellidos = apellidos;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Rol = rol;
            Sexo = sexo;
        }


        // Constructor con idUsuario
        public Usuario(int? idUsuario, string nombres, string apellidos, string nombreUsuario, string contraseña, Rol rol, string sexo = null)
        {
            IdUsuario = idUsuario;
            Nombres = nombres;
            Apellidos = apellidos;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Rol = rol;
            Sexo = sexo;
        }


    }

}
