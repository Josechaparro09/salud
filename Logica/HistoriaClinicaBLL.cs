using System;
using System.Collections.Generic;
using Datos;
using Entidades;

namespace Logica
{
    public class HistoriaClinicaBLL
    {
        private HistoriaClinicaDAL historiaClinicaDAL = new HistoriaClinicaDAL();

        public List<HistoriaClinica> ObtenerHistoriasClinicas()
        {
            try
            {
                return historiaClinicaDAL.ObtenerHistoriasClinicas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las historias clínicas: " + ex.Message);
            }
        }
        public HistoriaClinica ObtenerHistoriaClinicaPorIdCita(int? idCita)
        {
            try
            {
                if (idCita <= 0)
                {
                    throw new ArgumentException("El ID de la cita es inválido");
                }
                return historiaClinicaDAL.ObtenerHistoriaClinicaPorIdCita(idCita);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al obtener historia clínica por ID de cita: " + ex.Message);
            }
        }

        public string RegistrarHistoriaClinica(Paciente paciente, Doctor doctor, DateTime fechaCreacion, string diagnostico, string tratamiento, string notasAdicionales)
        {
            if (string.IsNullOrWhiteSpace(diagnostico) || string.IsNullOrWhiteSpace(tratamiento))
            {
                return "Por favor, complete todos los campos requeridos.";
            }

            try
            {
                var nuevaHistoriaClinica = new HistoriaClinica
                {
                    Paciente= paciente,
                    Doctor = doctor,
                    FechaCreacion = fechaCreacion,
                    Diagnostico = diagnostico,
                    Tratamiento = tratamiento,
                    NotasAdicionales = notasAdicionales
                };

                historiaClinicaDAL.GuardarHistoriaClinica(nuevaHistoriaClinica);
                return "Registro exitoso.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la historia clínica: " + ex.Message);
            }
        }
        public bool ActualizarHistoriaClinica(HistoriaClinica historiaClinica)
        {
            try
            {
                if (historiaClinica == null)
                    throw new ArgumentNullException(nameof(historiaClinica));

                if (string.IsNullOrWhiteSpace(historiaClinica.Diagnostico))
                    throw new ArgumentException("El diagnóstico es requerido");

                if (string.IsNullOrWhiteSpace(historiaClinica.Tratamiento))
                    throw new ArgumentException("El tratamiento es requerido");

                if (historiaClinica.Doctor == null || historiaClinica.Doctor.IdDoctor <= 0)
                    throw new ArgumentException("El doctor es requerido");

                if (historiaClinica.Paciente == null || historiaClinica.Paciente.IdPaciente <= 0)
                    throw new ArgumentException("El paciente es requerido");

                if (historiaClinica.IdHistoriaClinica <= 0)
                    throw new ArgumentException("ID de historia clínica inválido");

                var historiaExistente = historiaClinicaDAL.ObtenerHistoriaClinicaPorId(historiaClinica.IdHistoriaClinica);
                if (historiaExistente == null)
                    throw new Exception("La historia clínica no existe");

                return historiaClinicaDAL.ActualizarHistoriaClinica(historiaClinica);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al actualizar la historia clínica: " + ex.Message);
            }
        }

        public HistoriaClinica ObtenerHistoriaClinicaPorId(int idHistoriaClinica)
        {
            try
            {
                if (idHistoriaClinica <= 0)
                    throw new ArgumentException("ID de historia clínica inválido");

                return historiaClinicaDAL.ObtenerHistoriaClinicaPorId(idHistoriaClinica);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al obtener la historia clínica: " + ex.Message);
            }
        }

        public string ActualizarHistoriaClinica(int idHistoriaClinica, Paciente paciente, Doctor doctor, DateTime fechaCreacion, string diagnostico, string tratamiento, string notasAdicionales)
        {
            if (string.IsNullOrWhiteSpace(diagnostico) || string.IsNullOrWhiteSpace(tratamiento))
            {
                return "Por favor, complete todos los campos requeridos.";
            }

            try
            {
                var historiaClinica = new HistoriaClinica
                {
                    IdHistoriaClinica = idHistoriaClinica,
                    Paciente = paciente,
                    Doctor = doctor,
                    FechaCreacion = fechaCreacion,
                    Diagnostico = diagnostico,
                    Tratamiento = tratamiento,
                    NotasAdicionales = notasAdicionales
                };

                historiaClinicaDAL.ActualizarHistoriaClinica(historiaClinica);
                return "Actualización exitosa.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la historia clínica: " + ex.Message);
            }
        }

        public string EliminarHistoriaClinica(int idHistoriaClinica)
        {
            try
            {
                historiaClinicaDAL.EliminarHistoriaClinica(idHistoriaClinica);
                return "Historia clínica eliminada exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la historia clínica: " + ex.Message);
            }
        }
        public bool GuardarHistoriaClinica(HistoriaClinica historiaClinica)
        {
            try
            {
                ValidarHistoriaClinica(historiaClinica);
                var guardado = historiaClinicaDAL.GuardarHistoriaClinica(historiaClinica);
                
                return guardado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar la historia clínica: {ex.Message}");
            }
        }

        private void ValidarHistoriaClinica(HistoriaClinica historiaClinica)
        {
            if (historiaClinica.Paciente == null)
                throw new Exception("El paciente es requerido");

            if (historiaClinica.Doctor == null)
                throw new Exception("El doctor es requerido");

            if (string.IsNullOrWhiteSpace(historiaClinica.Diagnostico))
                throw new Exception("El diagnóstico es requerido");

            if (string.IsNullOrWhiteSpace(historiaClinica.Tratamiento))
                throw new Exception("El tratamiento es requerido");
        }

        public List<HistoriaClinica> ObtenerHistoriasClinicasPorPaciente(int? idPaciente)
        {
            try
            {
                return historiaClinicaDAL.ObtenerHistoriasClinicasPorPaciente(idPaciente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener las historias clínicas: {ex.Message}");
            }
        }
    }
}
