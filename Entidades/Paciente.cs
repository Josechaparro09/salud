using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {


        public int? IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<HistoriaClinica> HistoriaClinica { get; set; }
        public string Cedula { get; set; }
        public int? IdUsuario { get; set; }

        public Paciente()
        {

        }

        public Paciente(string nombre, string apellido, string direccion, string telefono, DateTime fechaNacimiento, List<HistoriaClinica> historiaClinica)
        {
            IdPaciente = null;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            HistoriaClinica = historiaClinica;
        }
        public Paciente(int idPaciente, string nombre, string apellido, string direccion, string telefono, DateTime fechaNacimiento, List<HistoriaClinica> historiaClinica)
        {
            IdPaciente = idPaciente;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            HistoriaClinica = historiaClinica;
        }
    }

}
