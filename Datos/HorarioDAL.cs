using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Entidades;

namespace Datos
{
    public class HorarioDAL
    {
        private Conexion conexion;

        public HorarioDAL()
        {
            conexion = new Conexion();
        }

        public List<Horario> ObtenerHorarios()
        {
            List<Horario> horarios = new List<Horario>();

            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"SELECT IdHorario, IdDoctor, DiaSemana, 
                           HoraInicio, HoraFin FROM Horario";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string diaAbreviado = reader["DiaSemana"].ToString();
                                string diaCompleto = DiasSemanaUtil.ObtenerDiaCompleto(diaAbreviado);

                                var horario = new Horario
                                {
                                    IdHorario = Convert.ToInt32(reader["IdHorario"]),
                                    IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                                    DiaSemana = diaCompleto,
                                    HoraInicio = (TimeSpan)reader["HoraInicio"],
                                    HoraFin = (TimeSpan)reader["HoraFin"]
                                };

                                horarios.Add(horario);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los horarios: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            return horarios;
        }

        public void GuardarHorario(Horario horario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {

                    string diaAbreviado = DiasSemanaUtil.ObtenerAbreviatura(horario.DiaSemana);

                    string query = @"INSERT INTO Horario 
                           (IdDoctor, DiaSemana, HoraInicio, HoraFin) 
                           VALUES 
                           (:IdDoctor, :DiaSemana, :HoraInicio, :HoraFin)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdDoctor", horario.IdDoctor));
                        cmd.Parameters.Add(new OracleParameter("DiaSemana", horario.DiaSemana));
                        cmd.Parameters.Add(new OracleParameter("HoraInicio", horario.HoraInicio));
                        cmd.Parameters.Add(new OracleParameter("HoraFin", horario.HoraFin));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar el horario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }


        public void ActualizarHorario(Horario horario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string diaAbreviado = DiasSemanaUtil.ObtenerAbreviatura(horario.DiaSemana);

                    string query = @"UPDATE Horario 
                           SET IdDoctor = :IdDoctor, 
                               DiaSemana = :DiaSemana, 
                               HoraInicio = :HoraInicio, 
                               HoraFin = :HoraFin 
                           WHERE IdHorario = :IdHorario";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdDoctor", horario.IdDoctor));
                        cmd.Parameters.Add(new OracleParameter("DiaSemana", horario.DiaSemana));
                        cmd.Parameters.Add(new OracleParameter("HoraInicio", horario.HoraInicio));
                        cmd.Parameters.Add(new OracleParameter("HoraFin", horario.HoraFin));
                        cmd.Parameters.Add(new OracleParameter("IdHorario", horario.IdHorario));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el horario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public void EliminarHorario(int idHorario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "DELETE FROM Horario WHERE IdHorario = :IdHorario";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdHorario", idHorario));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el horario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public Horario ObtenerHorarioPorId(int idHorario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "SELECT IdHorario, IdDoctor, DiaSemana, HoraInicio, HoraFin FROM Horario WHERE IdHorario = :IdHorario";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdHorario", idHorario));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Horario
                                {
                                    IdHorario = Convert.ToInt32(reader["IdHorario"]),
                                    IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                                    DiaSemana = reader["DiaSemana"].ToString(),
                                    HoraInicio = (TimeSpan)reader["HoraInicio"],
                                    HoraFin = (TimeSpan)reader["HoraFin"]
                                };
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el horario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
        public List<Horario> ObtenerHorariosPorDoctor(int idDoctor)
        {
            List<Horario> horarios = new List<Horario>();

            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "SELECT IdHorario, IdDoctor, DiaSemana, HoraInicio, HoraFin FROM Horario WHERE IdDoctor = :IdDoctor";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdDoctor", idDoctor));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var horario = new Horario
                                {
                                    IdHorario = Convert.ToInt32(reader["IdHorario"]),
                                    IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                                    DiaSemana = reader["DiaSemana"].ToString(),
                                    HoraInicio = (TimeSpan)reader["HoraInicio"],
                                    HoraFin = (TimeSpan)reader["HoraFin"]
                                };

                                horarios.Add(horario);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los horarios del doctor: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            return horarios;
        }
    }
}