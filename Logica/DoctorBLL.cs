using System;
using System.Collections.Generic;
using Datos;
using Entidades;

namespace Logica
{
    public class DoctorBLL
    {
        private DoctorDAL doctorDAL = new DoctorDAL();
        private UsuarioDAL _usuarioDAL = new UsuarioDAL();

        public List<Doctor> ObtenerDoctores()
        {
            try
            {
                return doctorDAL.ObtenerDoctores();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los doctores: " + ex.Message);
            }
        }
        
        public string RegistrarDoctorConUsuario(Doctor doctor)
        {
            try
            {
                string[] partes = doctor.Nombre.Split(' '); 

                string nombre = partes[0];
                string apellido;
                if (partes.Length > 1)
                {
                    apellido= partes[1];
                }
                else
                {
                    apellido =" ";
                }
                Usuario usuario = new Usuario
                {
                    Nombres = nombre,
                    Apellidos =apellido,
                    NombreUsuario = doctor.Cedula, 
                    Contraseña = doctor.Cedula,    
                    Rol = new Rol() { IdRol=2,NombreRol="doctor"}
                };

                int idUsuario = _usuarioDAL.RegistrarUsuarioConRol(usuario);

                if (idUsuario <= 0)
                {
                    throw new Exception("Error al crear el usuario para el doctor");
                }

                doctor.IdUsuario = idUsuario;

                doctorDAL.GuardarDoctor(doctor);

                return $"Doctor y usuario registrados exitosamente → Usuario:{usuario.NombreUsuario} Contraseña: {usuario.Contraseña} ";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar doctor con usuario: " + ex.Message);
            }
        }
        public Doctor ObtenerDoctorPorIdUsuario(int? idUsuario)
        {
            try
            {
                var doctor = doctorDAL.ObtenerDoctorPorIdUsuario(idUsuario);
                if (doctor == null)
                {
                    throw new Exception("No se encontró el doctor asociado al usuario.");
                }
                return doctor;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el doctor: {ex.Message}");
            }
        }


        public string RegistrarDoctor(Doctor doctor)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(doctor.Nombre) ||
                    string.IsNullOrWhiteSpace(doctor.Cedula) ||
                    string.IsNullOrWhiteSpace(doctor.Telefono))
                {
                    return "Por favor, complete todos los campos.";
                }

                doctorDAL.GuardarDoctor(doctor);
                return "Doctor registrado exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el doctor: " + ex.Message);
            }
        }

        public string ActualizarDoctor(Doctor doctor)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(doctor.Nombre) ||
                    string.IsNullOrWhiteSpace(doctor.Cedula) ||
                    string.IsNullOrWhiteSpace(doctor.Telefono))
                {
                    return "Por favor, complete todos los campos.";
                }

                doctorDAL.ActualizarDoctor(doctor);
                return "Doctor actualizado exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el doctor: " + ex.Message);
            }
        }

        public string EliminarDoctor(int idDoctor)
        {
            try
            {
                doctorDAL.EliminarDoctor(idDoctor);
                return "Doctor eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el doctor: " + ex.Message);
            }
        }

        public List<Doctor> ObtenerDoctoresPorEspecialidad(int idEspecialidad)
        {
            try
            {
                return doctorDAL.ObtenerDoctoresPorEspecialidad(idEspecialidad);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los doctores por especialidad: " + ex.Message);
            }
        }

        public Doctor ObtenerDoctorPorId(int idDoctor)
        {
            try
            {
                return doctorDAL.ObtenerDoctorPorId(idDoctor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el doctor: " + ex.Message);
            }
        }
    }
}