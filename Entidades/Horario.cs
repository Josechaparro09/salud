using System;

namespace Entidades
{
    public class Horario
    {
        public int IdHorario { get; set; }
        public int IdDoctor { get; set; }
        public string DiaSemana { get; set; } // Lunes, Martes, etc.
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public Horario()
        {
        }

        public Horario(int idHorario, int idDoctor, string diaSemana, TimeSpan horaInicio, TimeSpan horaFin)
        {
            IdHorario = idHorario;
            IdDoctor = idDoctor;
            DiaSemana = diaSemana;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }

        public override string ToString()
        {
            return $"{DiaSemana}: {HoraInicio} - {HoraFin}";
        }
    }
}