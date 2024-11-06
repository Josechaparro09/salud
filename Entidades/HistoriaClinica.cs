using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HistoriaClinica
    {
        public int? IdHistoriaClinica { get; set; }
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string NotasAdicionales { get; set; }
        public int? IdCita { get; set; }
        public Cita Cita { get; set; }

        public HistoriaClinica()
        {

        }

        public HistoriaClinica(int? idHistoriaClinica, Paciente paciente, Doctor doctor, DateTime fechaCreacion, string diagnostico, string tratamiento, string notasAdicionales)
        {
            IdHistoriaClinica = idHistoriaClinica;
            Paciente = paciente;
            Doctor = doctor;
            FechaCreacion = fechaCreacion;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            NotasAdicionales = notasAdicionales;
        }

        public HistoriaClinica(Paciente paciente, Doctor doctor, DateTime fechaCreacion, string diagnostico, string tratamiento, string notasAdicionales)
        {
            IdHistoriaClinica = null;
            Paciente = paciente;
            Doctor = doctor;
            FechaCreacion = fechaCreacion;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            NotasAdicionales = notasAdicionales;
        }


    }

}
