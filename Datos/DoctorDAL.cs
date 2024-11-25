using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Entidades;
using Datos;

namespace Datos
{
    public class DoctorDAL
    {
        private Conexion conexion;
        public DoctorDAL()
        {
            conexion = new Conexion();
        }

        public List<Paciente> BuscarPacientes(string criterio)
        {
            List<Paciente> pacientes = new List<Paciente>();
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"SELECT IdPaciente, Cedula, Nombre, Telefono, Direccion,Sexo 
                           FROM Paciente 
                           WHERE LOWER(Cedula) LIKE LOWER(:criterio) 
                           OR LOWER(Nombre) LIKE LOWER(:criterio)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add("criterio", "%" + criterio + "%");
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pacientes.Add(new Paciente
                                {
                                    IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                                    Cedula = reader["Cedula"].ToString(),
                                    Nombre = reader["Nombre"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                    Sexo = reader["Sexo"].ToString(),
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar pacientes: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
            return pacientes;
        }

        public List<Doctor> ObtenerDoctores()
        {
            List<Doctor> doctores = new List<Doctor>();

            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"SELECT d.IdDoctor, d.Nombre, d.Cedula, d.Telefono, d.Sexo,
                                   d.IdEspecialidad, e.NombreEspecialidad 
                                   FROM Doctor d 
                                   LEFT JOIN Especialidad e ON d.IdEspecialidad = e.IdEspecialidad";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var especialidad = new Especialidad
                                {
                                    IdEspecialidad = reader["IdEspecialidad"] != DBNull.Value
                                        ? Convert.ToInt32(reader["IdEspecialidad"])
                                        : 0,
                                    NombreEspecialidad = reader["NombreEspecialidad"]?.ToString()
                                };

                                var doctor = new Doctor
                                {
                                    IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Cedula = reader["Cedula"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Sexo = reader["Sexo"].ToString(),
                                    Especialidad = especialidad
                                };

                                doctores.Add(doctor);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los doctores: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            return doctores;
        }

        public void GuardarDoctor(Doctor doctor)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                OracleTransaction transaction = null;
                try
                {
                    transaction = conn.BeginTransaction();

                    Usuario usuarioDoctor = new Usuario
                    {
                        Nombres = doctor.Nombre,
                        Apellidos = "", 
                        NombreUsuario = doctor.Cedula,
                        Contraseña = doctor.Cedula,IdUsuario=doctor.IdUsuario,
                        Sexo=doctor.Sexo,
                    };


                    string queryVerificarEspecialidad = @"
                SELECT IdEspecialidad 
                FROM Especialidad 
                WHERE NombreEspecialidad = :NombreEspecialidad";

                    int idEspecialidad;
                    using (OracleCommand cmdVerificar = new OracleCommand(queryVerificarEspecialidad, conn))
                    {
                        cmdVerificar.Transaction = transaction;
                        cmdVerificar.Parameters.Add("NombreEspecialidad", doctor.Especialidad.NombreEspecialidad);
                        var result = cmdVerificar.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            string queryInsertarEspecialidad = @"
                        INSERT INTO Especialidad (NombreEspecialidad) 
                        VALUES (:NombreEspecialidad) 
                        RETURNING IdEspecialidad INTO :IdEspecialidad";

                            using (OracleCommand cmdInsertarEsp = new OracleCommand(queryInsertarEspecialidad, conn))
                            {
                                cmdInsertarEsp.Transaction = transaction;
                                cmdInsertarEsp.Parameters.Add("NombreEspecialidad", doctor.Especialidad.NombreEspecialidad);

                                var paramId = new OracleParameter("IdEspecialidad", OracleDbType.Int32);
                                paramId.Direction = System.Data.ParameterDirection.Output;
                                cmdInsertarEsp.Parameters.Add(paramId);

                                cmdInsertarEsp.ExecuteNonQuery();
                                idEspecialidad = int.Parse(paramId.Value.ToString());
                            }
                        }
                        else
                        {
                            idEspecialidad = Convert.ToInt32(result);
                        }
                    }

                    string queryInsertarDoctor = @"
                INSERT INTO Doctor (Nombre, Cedula, Telefono, IdEspecialidad, IdUsuario,Sexo) 
                VALUES (:Nombre, :Cedula, :Telefono, :IdEspecialidad, :IdUsuario, :Sexo)";

                    using (OracleCommand cmdInsertarDoc = new OracleCommand(queryInsertarDoctor, conn))
                    {
                        cmdInsertarDoc.Transaction = transaction;
                        cmdInsertarDoc.Parameters.Add("Nombre", doctor.Nombre);
                        cmdInsertarDoc.Parameters.Add("Cedula", doctor.Cedula);
                        cmdInsertarDoc.Parameters.Add("Telefono", doctor.Telefono);
                        cmdInsertarDoc.Parameters.Add("IdEspecialidad", idEspecialidad);
                        cmdInsertarDoc.Parameters.Add("IdUsuario", doctor.IdUsuario);
                        cmdInsertarDoc.Parameters.Add("Sexo", doctor.IdUsuario);

                        cmdInsertarDoc.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                        transaction.Rollback();
                    throw new Exception("Error al guardar el doctor: " + ex.Message);
                }
                finally
                {
                    if (transaction != null)
                        transaction.Dispose();
                    conexion.CloseConnection(conn);
                }
            }
        }

        public void ActualizarDoctor(Doctor doctor)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"UPDATE Doctor 
                                   SET Nombre = :Nombre, 
                                       Cedula = :Cedula, 
                                       Telefono = :Telefono, 
                                       IdEspecialidad = :IdEspecialidad, Sexo = :Sexo
                                   WHERE IdDoctor = :IdDoctor";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Nombre", doctor.Nombre));
                        cmd.Parameters.Add(new OracleParameter("Cedula", doctor.Cedula));
                        cmd.Parameters.Add(new OracleParameter("Telefono", doctor.Telefono));
                        cmd.Parameters.Add(new OracleParameter("IdEspecialidad", doctor.Especialidad.IdEspecialidad));
                        cmd.Parameters.Add(new OracleParameter("IdDoctor", doctor.IdDoctor));
                        cmd.Parameters.Add(new OracleParameter("Sexo", doctor.Sexo));

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el doctor: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public Doctor ObtenerDoctorPorId(int? idDoctor)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"SELECT d.IdDoctor, d.Nombre, d.Cedula, d.Telefono, d.Sexo,
                                   d.IdEspecialidad, e.NombreEspecialidad 
                                   FROM Doctor d 
                                   LEFT JOIN Especialidad e ON d.IdEspecialidad = e.IdEspecialidad 
                                   WHERE d.IdDoctor = :IdDoctor";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdDoctor", idDoctor));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var especialidad = new Especialidad
                                {
                                    IdEspecialidad = reader["IdEspecialidad"] != DBNull.Value
                                        ? Convert.ToInt32(reader["IdEspecialidad"])
                                        : 0,
                                    NombreEspecialidad = reader["NombreEspecialidad"]?.ToString()
                                };

                                return new Doctor
                                {
                                    IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Cedula = reader["Cedula"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Especialidad = especialidad,
                                    Sexo= reader["Sexo"].ToString(),
                                };
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el doctor: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public bool ExisteCedula(string cedula, int? idDoctorExcluir = null)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM Doctor WHERE Cedula = :Cedula";
                    if (idDoctorExcluir.HasValue)
                    {
                        query += " AND IdDoctor != :IdDoctor";
                    }

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Cedula", cedula));
                        if (idDoctorExcluir.HasValue)
                        {
                            cmd.Parameters.Add(new OracleParameter("IdDoctor", idDoctorExcluir.Value));
                        }

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al verificar la cédula: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
        public List<Doctor> ObtenerDoctoresPorEspecialidad(int idEspecialidad)
        {
            List<Doctor> doctores = new List<Doctor>();

            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"SELECT d.IdDoctor, d.Nombre, d.Cedula, d.Telefono,d.Sexo,
                           d.IdEspecialidad, e.NombreEspecialidad 
                           FROM Doctor d 
                           LEFT JOIN Especialidad e ON d.IdEspecialidad = e.IdEspecialidad 
                           WHERE d.IdEspecialidad = :IdEspecialidad";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdEspecialidad", idEspecialidad));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var especialidad = new Especialidad
                                {
                                    IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]),
                                    NombreEspecialidad = reader["NombreEspecialidad"].ToString()
                                };

                                var doctor = new Doctor
                                {
                                    IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Cedula = reader["Cedula"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Sexo = reader["Sexo"].ToString(),
                                    Especialidad = especialidad
                                };

                                doctores.Add(doctor);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los doctores por especialidad: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            return doctores;
        }

        public void EliminarDoctor(int idDoctor)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "DELETE FROM Doctor WHERE IdDoctor = :IdDoctor";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdDoctor", idDoctor));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el doctor: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
        public Doctor ObtenerDoctorPorIdUsuario(int? idUsuario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"SELECT 
                               d.IdDoctor, 
                               d.Nombre, 
                               d.Cedula, 
                               d.Telefono, 
                               d.IdEspecialidad, 
                               d.IdUsuario, d.Sexo
                               e.NombreEspecialidad 
                           FROM Doctor d 
                           LEFT JOIN Especialidad e ON d.IdEspecialidad = e.IdEspecialidad 
                           WHERE d.IdUsuario = :IdUsuario";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdUsuario", idUsuario));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var especialidad = new Especialidad
                                {
                                    IdEspecialidad = reader["IdEspecialidad"] != DBNull.Value
                                        ? Convert.ToInt32(reader["IdEspecialidad"])
                                        : 0,
                                    NombreEspecialidad = reader["NombreEspecialidad"]?.ToString()
                                };

                                return new Doctor
                                {
                                    IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Cedula = reader["Cedula"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                    Sexo = reader["Sexo"].ToString(),
                                    Especialidad = especialidad
                                };
                            }
                            return null; 
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el doctor por ID de usuario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
    }
}
