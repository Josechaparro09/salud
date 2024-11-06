using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Entidades;
using Datos;

namespace Datos
{
    public class PacienteDAL
    {
        private Conexion conexion;

        public PacienteDAL()
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
                    string query = @"SELECT IdPaciente, Cedula, Nombre, Telefono, Direccion 
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
                                    Direccion = reader["Direccion"].ToString()
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
        public Paciente ObtenerPacientePorIdUsuario(int? idUsuario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"SELECT 
                IdPaciente, 
                Nombre, 
                Apellido, 
                Direccion, 
                Telefono, 
                Cedula,
                FechaNacimiento,
                IdUsuario
                FROM Paciente 
                WHERE IdUsuario = :IdUsuario";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdUsuario", idUsuario));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Paciente
                                {
                                    IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Cedula = reader["Cedula"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                                };
                            }
                            return null; 
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el paciente por IdUsuario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();

            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "SELECT IdPaciente,Cedula, Nombre, Apellido, Direccion, Telefono, FechaNacimiento FROM Paciente";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var paciente = new Paciente
                                {
                                    IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                                    Cedula = reader["Cedula"].ToString(),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                                };

                                pacientes.Add(paciente);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los pacientes: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            return pacientes;
        }

        public void GuardarPaciente(Paciente paciente)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "INSERT INTO Paciente (Nombre,Cedula, Apellido, Direccion, Telefono, FechaNacimiento) " +
                                   "VALUES (:Nombre,:Cedula, :Apellido, :Direccion, :Telefono, :FechaNacimiento)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Nombre", paciente.Nombre));
                        cmd.Parameters.Add(new OracleParameter("Cedula", paciente.Cedula));
                        cmd.Parameters.Add(new OracleParameter("Apellido", paciente.Apellido));
                        cmd.Parameters.Add(new OracleParameter("Direccion", paciente.Direccion));
                        cmd.Parameters.Add(new OracleParameter("Telefono", paciente.Telefono));
                        cmd.Parameters.Add(new OracleParameter("FechaNacimiento", paciente.FechaNacimiento));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar el paciente: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
        public void GuardarPacienteConUsuario(Paciente paciente, int idUsuario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "INSERT INTO Paciente (Nombre,Cedula, Apellido, Direccion, Telefono, FechaNacimiento,IdUsuario) " +
                                   "VALUES (:Nombre,:Cedula, :Apellido, :Direccion, :Telefono, :FechaNacimiento, :IdUsuario)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Nombre", paciente.Nombre));
                        cmd.Parameters.Add(new OracleParameter("Cedula", paciente.Cedula));
                        cmd.Parameters.Add(new OracleParameter("Apellido", paciente.Apellido));
                        cmd.Parameters.Add(new OracleParameter("Direccion", paciente.Direccion));
                        cmd.Parameters.Add(new OracleParameter("Telefono", paciente.Telefono));
                        cmd.Parameters.Add(new OracleParameter("FechaNacimiento", paciente.FechaNacimiento));
                        cmd.Parameters.Add(new OracleParameter("IdUsuario", idUsuario));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar el paciente: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "UPDATE Paciente SET Nombre = :Nombre, Cedula = :Cedula, Apellido = :Apellido, Direccion = :Direccion, Telefono = :Telefono, FechaNacimiento = :FechaNacimiento " +
                                   "WHERE IdPaciente = :IdPaciente";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Nombre", paciente.Nombre));
                        cmd.Parameters.Add(new OracleParameter("Cedula", paciente.Cedula));
                        cmd.Parameters.Add(new OracleParameter("Apellido", paciente.Apellido));
                        cmd.Parameters.Add(new OracleParameter("Direccion", paciente.Direccion));
                        cmd.Parameters.Add(new OracleParameter("Telefono", paciente.Telefono));
                        cmd.Parameters.Add(new OracleParameter("FechaNacimiento", paciente.FechaNacimiento));
                        cmd.Parameters.Add(new OracleParameter("IdPaciente", paciente.IdPaciente));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el paciente: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }


public Paciente ObtenerPacientePorId(int? idPaciente)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"
                SELECT 
                    IdPaciente, 
                    Nombre, 
                    Apellido, 
                    Cedula, 
                    Telefono, 
                    Direccion, 
                    FechaNacimiento,
                    IdUsuario
                FROM Paciente 
                WHERE IdPaciente = :IdPaciente";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdPaciente", idPaciente));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Paciente
                                {
                                    IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Cedula = reader["Cedula"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                    IdUsuario = reader["IdUsuario"] != DBNull.Value ?
                                              Convert.ToInt32(reader["IdUsuario"]) :
                                              (int?)null
                                };
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al obtener el paciente: {ex.Message}");
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public void EliminarPaciente(int idPaciente)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "DELETE FROM Paciente WHERE IdPaciente = :IdPaciente";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdPaciente", idPaciente));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el paciente: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
    }
}
