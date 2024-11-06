using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Especialidad
    {
        public int? IdEspecialidad { get; set; }
        public string NombreEspecialidad { get; set; }

        public Especialidad()
        {
        }

        public Especialidad(int idEspecialidad, string nombreEspecialidad)
        {
            IdEspecialidad = idEspecialidad;
            NombreEspecialidad = nombreEspecialidad;
        }
        public Especialidad(string nombreEspecialidad)
        {
            IdEspecialidad = null;
            NombreEspecialidad = nombreEspecialidad;
        }
    }
}
