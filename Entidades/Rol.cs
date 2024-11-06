using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rol
    {
        public int? IdRol { get; set; }
        public string NombreRol { get; set; }

        public Rol() { }

        public Rol(int? idRol, string nombreRol)
        {
            IdRol = idRol;
            NombreRol = nombreRol;
        }

        public Rol(int idRol, string nombreRol)
        {
            IdRol = null;
            NombreRol = nombreRol;
        }


    }
}
