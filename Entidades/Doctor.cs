using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Doctor
    {
        public int? IdDoctor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public int? IdEspecialidad { get; set; }
        public Especialidad Especialidad { get; set; }
        public int IdUsuario { get; set; }

        public Doctor() { }

        public Doctor(int? idDoctor, string nombre, int? idEspecialidad,Especialidad especialidad, string telefono, string cedula)
        {
            IdDoctor = idDoctor;
            Nombre = nombre;
            IdEspecialidad= idEspecialidad;
            Especialidad = especialidad;
            Telefono = telefono;
            Cedula = cedula;
        }

        public Doctor(string nombre,int? idEspecialidad, Especialidad especialidad, string telefono,string cedula)
        {
            IdDoctor = null;
            Nombre = nombre;
            IdEspecialidad = idEspecialidad;
            Especialidad = especialidad;
            Telefono = telefono;
            Cedula = cedula;
        }


    }

}
