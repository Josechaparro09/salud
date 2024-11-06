using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Entidades;
using Datos;

namespace Datos
{
    public class HistoriaClinicaDAL
    {
        private Conexion conexion;
        CitaDAL citaDAL = new CitaDAL();
        public HistoriaClinicaDAL()
        {
            conexion = new Conexion();
        }

        public List<HistoriaClinica> ObtenerHistoriasClinicas()
        {
            List<HistoriaClinica> historiasClinicas = new List<HistoriaClinica>();

            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"
                        SELECT 
                            hc.IdHistoriaClinica, 
                            hc.IdPaciente, 
                            hc.IdDoctor, 
                            hc.FechaCreacion, 
                            hc.Diagnostico, 
                            hc.Tratamiento, 
                            hc.NotasAdicionales,hc.IdCita,
                            p.Nombre AS NombrePaciente, 
                            p.Apellido AS ApellidoPaciente, 
                            p.Direccion, 
                            p.Telefono AS TelefonoPaciente, 
                            p.FechaNacimiento,
                            d.Nombre AS NombreDoctor, 
                            d.Cedula AS CedulaDoctor,
                            d.Telefono AS TelefonoDoctor,
                            d.IdEspecialidad,
                            e.NombreEspecialidad
                        FROM HistoriaClinica hc
                        JOIN Paciente p ON hc.IdPaciente = p.IdPaciente
                        JOIN Doctor d ON hc.IdDoctor = d.IdDoctor
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
                                    Nombre = reader["NombreDoctor"].ToString(),
                                    Cedula = reader["CedulaDoctor"].ToString(),
                                    Telefono = reader["TelefonoDoctor"].ToString(),
                                    IdEspecialidad = especialidad.IdEspecialidad,
                                    Especialidad = especialidad
                                };

                                var paciente = new Paciente
                                {
                                    IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                                    Nombre = reader["NombrePaciente"].ToString(),
                                    Apellido = reader["ApellidoPaciente"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                    Telefono = reader["TelefonoPaciente"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                                };

                                var historiaClinica = new HistoriaClinica
                                {
                                    IdHistoriaClinica = Convert.ToInt32(reader["IdHistoriaClinica"]),
                                    FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                    Diagnostico = reader["Diagnostico"]?.ToString(),
                                    Tratamiento = reader["Tratamiento"]?.ToString(),
                                    NotasAdicionales = reader["NotasAdicionales"]?.ToString(),
                                    Paciente = paciente,
                                    Doctor = doctor,
                                    IdCita =Convert.ToInt32(reader["IdCita"]),
                                };

                                historiasClinicas.Add(historiaClinica);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las historias clínicas: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            return historiasClinicas;
        }

        public bool GuardarHistoriaClinica(HistoriaClinica historiaClinica)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"
                        INSERT INTO HistoriaClinica 
                            (IdPaciente, IdDoctor, FechaCreacion, Diagnostico, Tratamiento, NotasAdicionales, IdCita) 
                        VALUES 
                            (:IdPaciente, :IdDoctor, :FechaCreacion, :Diagnostico, :Tratamiento, :NotasAdicionales, :IdCita)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdPaciente", historiaClinica.Paciente.IdPaciente));
                        cmd.Parameters.Add(new OracleParameter("IdDoctor", historiaClinica.Doctor.IdDoctor));
                        cmd.Parameters.Add(new OracleParameter("FechaCreacion", historiaClinica.FechaCreacion));
                        cmd.Parameters.Add(new OracleParameter("Diagnostico",
                            (object)historiaClinica.Diagnostico ?? DBNull.Value));
                        cmd.Parameters.Add(new OracleParameter("Tratamiento",
                            (object)historiaClinica.Tratamiento ?? DBNull.Value));
                        cmd.Parameters.Add(new OracleParameter("NotasAdicionales",
                            (object)historiaClinica.NotasAdicionales ?? DBNull.Value));
                        cmd.Parameters.Add(new OracleParameter("IdCita", historiaClinica.IdCita));

                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar la historia clínica: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public bool ActualizarHistoriaClinica(HistoriaClinica historiaClinica)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"UPDATE HistoriaClinica 
                               SET Diagnostico = :Diagnostico, 
                                   Tratamiento = :Tratamiento, 
                                   NotasAdicionales = :NotasAdicionales,
                                   FechaActualizacion = :FechaActualizacion,
                                   DoctorId = :DoctorId,
                                   PacienteId = :PacienteId,
                                   IdCita = :IdCita
                               WHERE IdHistoriaClinica = :IdHistoriaClinica";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Diagnostico", historiaClinica.Diagnostico));
                        cmd.Parameters.Add(new OracleParameter("Tratamiento", historiaClinica.Tratamiento));
                        cmd.Parameters.Add(new OracleParameter("NotasAdicionales",
                            historiaClinica.NotasAdicionales ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new OracleParameter("FechaActualizacion", DateTime.Now));
                        cmd.Parameters.Add(new OracleParameter("DoctorId", historiaClinica.Doctor.IdDoctor));
                        cmd.Parameters.Add(new OracleParameter("PacienteId", historiaClinica.Paciente.IdPaciente));
                        cmd.Parameters.Add(new OracleParameter("IdCita", historiaClinica.IdCita));
                        cmd.Parameters.Add(new OracleParameter("IdHistoriaClinica", historiaClinica.IdHistoriaClinica));

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la historia clínica: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public HistoriaClinica ObtenerHistoriaClinicaPorId(int? idHistoriaClinica)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"SELECT h.*, 
                                      p.Nombre as NombrePaciente, 
                                      p.Apellido as ApellidoPaciente,
                                      d.Nombre as NombreDoctor
                               FROM HistoriaClinica h
                               INNER JOIN Paciente p ON h.PacienteId = p.IdPaciente
                               INNER JOIN Doctor d ON h.DoctorId = d.IdDoctor
                               WHERE h.IdHistoriaClinica = :IdHistoriaClinica";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdHistoriaClinica", idHistoriaClinica));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new HistoriaClinica
                                {
                                    IdHistoriaClinica = Convert.ToInt32(reader["IdHistoriaClinica"]),
                                    Diagnostico = reader["Diagnostico"].ToString(),
                                    Tratamiento = reader["Tratamiento"].ToString(),
                                    NotasAdicionales = reader["NotasAdicionales"].ToString(),
                                    FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                    IdCita = Convert.ToInt32(reader["IdCita"]),
                                    Paciente = new Paciente
                                    {
                                        IdPaciente = Convert.ToInt32(reader["PacienteId"]),
                                        Nombre = reader["NombrePaciente"].ToString(),
                                        Apellido = reader["ApellidoPaciente"].ToString()
                                    },
                                    Doctor = new Doctor
                                    {
                                        IdDoctor = Convert.ToInt32(reader["DoctorId"]),
                                        Nombre = reader["NombreDoctor"].ToString()
                                    }
                                };
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la historia clínica: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public void EliminarHistoriaClinica(int idHistoriaClinica)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "DELETE FROM HistoriaClinica WHERE IdHistoriaClinica = :IdHistoriaClinica";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdHistoriaClinica", idHistoriaClinica));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la historia clínica: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
        public List<HistoriaClinica> ObtenerHistoriasClinicasPorPaciente(int? idPaciente)
        {
            List<HistoriaClinica> historiasClinicas = new List<HistoriaClinica>();
            string query = @"
                SELECT 
                    hc.IdHistoriaClinica, 
                    hc.IdPaciente, 
                    hc.IdDoctor, 
                    hc.FechaCreacion, 
                    hc.Diagnostico, 
                    hc.Tratamiento, 
                    hc.NotasAdicionales,
                    p.Nombre AS NombrePaciente, 
                    p.Apellido AS ApellidoPaciente, 
                    p.Direccion, 
                    p.Telefono AS TelefonoPaciente, 
                    p.FechaNacimiento,
                    d.Nombre AS NombreDoctor, 
                    d.Cedula AS CedulaDoctor,
                    d.Telefono AS TelefonoDoctor,
                    d.IdEspecialidad,
                    e.NombreEspecialidad,
                FROM HistoriaClinica hc
                JOIN Paciente p ON hc.IdPaciente = p.IdPaciente
                JOIN Doctor d ON hc.IdDoctor = d.IdDoctor
                LEFT JOIN Especialidad e ON d.IdEspecialidad = e.IdEspecialidad
                WHERE hc.IdPaciente = :IdPaciente
                ORDER BY hc.FechaCreacion DESC";


            return historiasClinicas;
        }
        public HistoriaClinica ObtenerHistoriaClinicaPorIdCita(int? idCita)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"
                SELECT 
                    hc.IdHistoriaClinica, 
                    hc.IdPaciente, 
                    hc.IdDoctor, 
                    hc.FechaCreacion, 
                    hc.Diagnostico, 
                    hc.Tratamiento, 
                    hc.NotasAdicionales,
                    hc.IdCita,
                    p.Nombre AS NombrePaciente,
                    p.Cedula AS CedulaPaciente,
                    p.Apellido AS ApellidoPaciente, 
                    p.Direccion, 
                    p.Telefono AS TelefonoPaciente, 
                    p.FechaNacimiento,
                    d.Nombre AS NombreDoctor, 
                    d.Cedula AS CedulaDoctor,
                    d.Telefono AS TelefonoDoctor,
                    d.IdEspecialidad,
                    e.NombreEspecialidad,
                    c.FechaCita,
                    c.HoraCita,
                    c.Estado
                FROM HistoriaClinica hc
                JOIN Paciente p ON hc.IdPaciente = p.IdPaciente
                JOIN Doctor d ON hc.IdDoctor = d.IdDoctor
                LEFT JOIN Especialidad e ON d.IdEspecialidad = e.IdEspecialidad
                JOIN Cita c ON hc.IdCita = c.IdCita
                WHERE hc.IdCita = :IdCita";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdCita", idCita));

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

                                var doctor = new Doctor
                                {
                                    IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                                    Nombre = reader["NombreDoctor"].ToString(),
                                    Cedula = reader["CedulaDoctor"].ToString(),
                                    Telefono = reader["TelefonoDoctor"].ToString(),
                                    IdEspecialidad = especialidad.IdEspecialidad,
                                    Especialidad = especialidad
                                };

                                var paciente = new Paciente
                                {
                                    IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                                    Nombre = reader["NombrePaciente"].ToString(),
                                    Cedula = reader["CedulaPaciente"].ToString(),
                                    Apellido = reader["ApellidoPaciente"].ToString(),
                                    Direccion = reader["Direccion"].ToString(),
                                    Telefono = reader["TelefonoPaciente"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                                };

                                return new HistoriaClinica
                                {
                                    IdHistoriaClinica = Convert.ToInt32(reader["IdHistoriaClinica"]),
                                    FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                    Diagnostico = reader["Diagnostico"]?.ToString(),
                                    Tratamiento = reader["Tratamiento"]?.ToString(),
                                    NotasAdicionales = reader["NotasAdicionales"]?.ToString(),
                                    Paciente = paciente,
                                    Doctor = doctor,
                                    IdCita = Convert.ToInt32(reader["IdCita"])
                                };
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la historia clínica por IdCita: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
    }
}
