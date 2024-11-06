using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cita
    {
        public int? IdCita { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        public Paciente Paciente { get; set; }
        public int? PacienteId {  get; set; }
        public Doctor Doctor { get; set; }
        public int? DoctorId { get; set; }
        public string Estado { get; set; }

        public Cita() { }

        public Cita(DateTime fechaCita, TimeSpan horaCita, Paciente paciente, Doctor doctor)
        {
            IdCita = null;
            FechaCita = fechaCita;
            HoraCita = horaCita;
            Paciente = paciente;
            Doctor = doctor;
        }

        public Cita(int idCita, DateTime fechaCita, TimeSpan horaCita, Paciente paciente, Doctor doctor)
        {
            IdCita = idCita;
            FechaCita = fechaCita;
            HoraCita = horaCita;
            Paciente = paciente;
            Doctor = doctor;
        }


    }

}
