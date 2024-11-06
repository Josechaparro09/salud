using System;
using System.Collections.Generic;
using Datos;
using Entidades;

namespace Logica
{
    public class EspecialidadBLL
    {
        private EspecialidadDAL especialidadDAL = new EspecialidadDAL();

        public string RegistrarEspecialidad(string nombreEspecialidad)
        {
            if (string.IsNullOrWhiteSpace(nombreEspecialidad))
            {
                return "Por favor, ingrese el nombre de la especialidad.";
            }

            try
            {
                var especialidades = especialidadDAL.ObtenerEspecialidades();

                foreach (var especialidad in especialidades)
                {
                    if (especialidad.NombreEspecialidad.Equals(nombreEspecialidad, StringComparison.OrdinalIgnoreCase))
                    {
                        return "La especialidad ya existe.";
                    }
                }

                var nuevaEspecialidad = new Especialidad
                {
                    NombreEspecialidad = nombreEspecialidad
                };

                especialidadDAL.GuardarEspecialidad(nuevaEspecialidad);
                return "Especialidad registrada exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la especialidad: " + ex.Message);
            }
        }

        public string ActualizarEspecialidad(int idEspecialidad, string nombreEspecialidad)
        {
            if (string.IsNullOrWhiteSpace(nombreEspecialidad))
            {
                return "Por favor, ingrese el nombre de la especialidad.";
            }

            try
            {
                var especialidades = especialidadDAL.ObtenerEspecialidades();

                foreach (var especialidad in especialidades)
                {
                    if (especialidad.IdEspecialidad != idEspecialidad &&
                        especialidad.NombreEspecialidad.Equals(nombreEspecialidad, StringComparison.OrdinalIgnoreCase))
                    {
                        return "Ya existe otra especialidad con este nombre.";
                    }
                }

                var especialidadActualizar = new Especialidad
                {
                    IdEspecialidad = idEspecialidad,
                    NombreEspecialidad = nombreEspecialidad
                };

                especialidadDAL.ActualizarEspecialidad(especialidadActualizar);
                return "Especialidad actualizada exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la especialidad: " + ex.Message);
            }
        }

        public string EliminarEspecialidad(int idEspecialidad)
        {
            try
            {
                especialidadDAL.EliminarEspecialidad(idEspecialidad);
                return "Especialidad eliminada exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la especialidad: " + ex.Message);
            }
        }

        public List<Especialidad> ObtenerEspecialidades()
        {
            try
            {
                return especialidadDAL.ObtenerEspecialidades();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las especialidades: " + ex.Message);
            }
        }

        public Especialidad ObtenerEspecialidadPorId(int idEspecialidad)
        {
            try
            {
                var especialidad = especialidadDAL.ObtenerEspecialidadPorId(idEspecialidad);
                if (especialidad == null)
                {
                    throw new Exception("No se encontró la especialidad especificada.");
                }
                return especialidad;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la especialidad: " + ex.Message);
            }
        }

        public bool ExisteEspecialidad(int idEspecialidad)
        {
            try
            {
                var especialidad = especialidadDAL.ObtenerEspecialidadPorId(idEspecialidad);
                return especialidad != null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar la existencia de la especialidad: " + ex.Message);
            }
        }
    }
}