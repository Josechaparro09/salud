using System;
using System.Collections.Generic;
using Datos;
using Entidades;

namespace Logica
{
    public class PacienteBLL
    {
        private PacienteDAL pacienteDAL = new PacienteDAL();



        public Paciente ObtenerPacientePorId(int? idPaciente)
        {
            try
            {
                if (idPaciente <= 0)
                {
                    throw new ArgumentException("El ID del paciente debe ser mayor que cero.");
                }

                var paciente = pacienteDAL.ObtenerPacientePorId(idPaciente);

                if (paciente == null)
                {
                    throw new Exception($"No se encontró ningún paciente con el ID {idPaciente}");
                }

                return paciente;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el paciente: {ex.Message}");
            }
        }

        public List<Paciente> ObtenerPacientes()
        {
            try
            {
                return pacienteDAL.ObtenerPacientes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los pacientes: " + ex.Message);
            }
        }
        public List<Paciente> BuscarPacientes(string criterio)
        {
            try
            {
                if (string.IsNullOrEmpty(criterio))
                    throw new ArgumentException("El criterio de búsqueda no puede estar vacío");

                return pacienteDAL.BuscarPacientes(criterio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al buscar pacientes: " + ex.Message);
            }
        }

        public string RegistrarPaciente(string nombre, string apellido, string direccion, string telefono, DateTime fechaNacimiento, string cedula, string sexo = null)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono))
            {
                return "Por favor, complete todos los campos.";
            }

            try
            {
                var nuevoPaciente = new Paciente
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Telefono = telefono,
                    FechaNacimiento = fechaNacimiento,
                    Cedula = cedula,
                    Sexo = sexo
                };

                pacienteDAL.GuardarPaciente(nuevoPaciente);
                return "Registro exitoso.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el paciente: " + ex.Message);
            }
        }
        public Paciente ObtenerPacientePorIdUsuario(int? idUsuario)
        {
            try
            {
                return pacienteDAL.ObtenerPacientePorIdUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener paciente por ID de usuario: " + ex.Message);
            }
        }
    

    public string ActualizarPaciente(int? idPaciente, string nombre, string apellido, string direccion, string telefono, DateTime fechaNacimiento,string cedula,string sexo = null)
        {
            if (string.IsNullOrWhiteSpace(cedula)||string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono))
            {
                return "Por favor, complete todos los campos.";
            }

            try
            {
                var paciente = new Paciente
                {
                    IdPaciente = idPaciente,
                    Nombre = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Telefono = telefono,
                    FechaNacimiento = fechaNacimiento,
                    Cedula = cedula,
                    Sexo = sexo
                    
                };

                pacienteDAL.ActualizarPaciente(paciente);
                return "Actualización exitosa.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el paciente: " + ex.Message);
            }
        }
        public string ActualizarPaciente(Paciente paciente)
        {
            try
            {
                
                pacienteDAL.ActualizarPaciente(paciente);
                return "Actualización exitosa.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el paciente: " + ex.Message);
            }
        }


        public string EliminarPaciente(int idPaciente)
        {
            try
            {
                pacienteDAL.EliminarPaciente(idPaciente);
                return "Paciente eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el paciente: " + ex.Message);
            }
        }
    }
}
