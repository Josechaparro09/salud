using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Entidades;
using Datos;

namespace Datos
{
    public class EspecialidadDAL
    {
        private Conexion conexion;

        public EspecialidadDAL()
        {
            conexion = new Conexion();
        }

        public List<Especialidad> ObtenerEspecialidades()
        {
            List<Especialidad> especialidades = new List<Especialidad>();

            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "SELECT IdEspecialidad, NombreEspecialidad FROM Especialidad";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var especialidad = new Especialidad
                                {
                                    IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]),
                                    NombreEspecialidad = reader["NombreEspecialidad"].ToString()
                                };

                                especialidades.Add(especialidad);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las especialidades: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            return especialidades;
        }

        public void GuardarEspecialidad(Especialidad especialidad)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "INSERT INTO Especialidad (NombreEspecialidad) VALUES (:NombreEspecialidad)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("NombreEspecialidad", especialidad.NombreEspecialidad));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar la especialidad: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public void ActualizarEspecialidad(Especialidad especialidad)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "UPDATE Especialidad SET NombreEspecialidad = :NombreEspecialidad WHERE IdEspecialidad = :IdEspecialidad";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("NombreEspecialidad", especialidad.NombreEspecialidad));
                        cmd.Parameters.Add(new OracleParameter("IdEspecialidad", especialidad.IdEspecialidad));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la especialidad: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public void EliminarEspecialidad(int idEspecialidad)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "DELETE FROM Especialidad WHERE IdEspecialidad = :IdEspecialidad";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdEspecialidad", idEspecialidad));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la especialidad: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public Especialidad ObtenerEspecialidadPorId(int idEspecialidad)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "SELECT IdEspecialidad, NombreEspecialidad FROM Especialidad WHERE IdEspecialidad = :IdEspecialidad";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdEspecialidad", idEspecialidad));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Especialidad
                                {
                                    IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]),
                                    NombreEspecialidad = reader["NombreEspecialidad"].ToString()
                                };
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la especialidad: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
    }
}