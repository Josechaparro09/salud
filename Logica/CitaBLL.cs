using System;
using System.Collections.Generic;
using Datos;
using Entidades;

namespace Logica
{
    public class CitaBLL
    {
        private CitaDAL citaDAL = new CitaDAL();

        public List<Cita> ObtenerCitas()
        {
            try
            {
                return citaDAL.ObtenerCitas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las citas: " + ex.Message);
            }
        }
        public List<Cita> ObtenerCitasFiltradas(Dictionary<string, object> filtros)
        {
            try
            {
                var citas = citaDAL.ObtenerCitasFiltradas(filtros);
                return citas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las citas filtradas: " + ex.Message);
            }
        }

        public string RegistrarCita(Cita cita)
        {
            try
            {
                // Validaciones más específicas
                if (cita == null)
                {
                    return "Error: Datos de cita inválidos";
                }

                if (cita.PacienteId <= 0)
                {
                    return "Error: ID de paciente inválido";
                }

                if (cita.DoctorId <= 0)
                {
                    return "Error: ID de doctor inválido";
                }

                if (cita.FechaCita == default)
                {
                    return "Error: Fecha de cita inválida";
                }

                if (string.IsNullOrEmpty(cita.HoraCita.ToString()))
                {
                    return "Error: Hora de cita inválida";
                }

                // Crear la nueva cita
                var nuevaCita = new Cita
                {
                    FechaCita = cita.FechaCita,
                    HoraCita = TimeSpan.Parse(cita.HoraCita.ToString()),
                    PacienteId = cita.PacienteId,
                    DoctorId = cita.DoctorId,
                    Estado = "Pendiente"
                };

                citaDAL.GuardarCita(nuevaCita);
                return "Cita registrada exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la cita: " + ex.Message);
            }
        }
        public List<TimeSpan> ObtenerHorariosDisponibles(int idDoctor, DateTime fecha)
            {
            try
            {
                if (idDoctor <= 0)
                    throw new ArgumentException("ID de doctor no válido");

                if (fecha.Date < DateTime.Now.Date)
                    throw new ArgumentException("No se pueden agendar citas en fechas pasadas");

                if (fecha.Date > DateTime.Now.Date.AddMonths(3))
                    throw new ArgumentException("No se pueden agendar citas con más de 3 meses de anticipación");

                if (fecha.DayOfWeek == DayOfWeek.Sunday)
                    throw new ArgumentException("No se atiende los domingos");

                var horariosDisponibles = citaDAL.ObtenerHorariosDisponibles(idDoctor, fecha);

                if (horariosDisponibles == null || horariosDisponibles.Count == 0)
                    throw new Exception("No hay horarios disponibles para la fecha seleccionada");

                if (fecha.Date == DateTime.Now.Date)
                {
                    horariosDisponibles.RemoveAll(h => h <= DateTime.Now.TimeOfDay);
                }

                return horariosDisponibles;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener horarios disponibles: " + ex.Message);
            }
        }

        public void ActualizarCita(Cita cita)
        {
            try
            {
                if (cita == null)
                    throw new ArgumentNullException(nameof(cita));

                if (string.IsNullOrEmpty(cita.Estado))
                    throw new ArgumentException("El estado de la cita no puede estar vacío");

                citaDAL.ActualizarCita(cita);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al actualizar la cita: " + ex.Message);
            }
        }
        public string ActualizarCita(int idCita, DateTime fechaCita, TimeSpan horaCita, Paciente paciente, Doctor doctor)
        {
            if (fechaCita == default || horaCita == default)
            {
                return "Por favor, complete todos los campos requeridos.";
            }

            try
            {
                var cita = new Cita
                {
                    IdCita = idCita,
                    FechaCita = fechaCita,
                    HoraCita = horaCita,
                    Paciente = paciente,
                    Doctor = doctor
                };

                citaDAL.ActualizarCita(cita);
                return "Actualización exitosa.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la cita: " + ex.Message);
            }
        }


        public string EliminarCita(int idCita)
        {
            try
            {
                citaDAL.EliminarCita(idCita);
                return "Cita eliminada exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la cita: " + ex.Message);
            }
        }
    }
}
