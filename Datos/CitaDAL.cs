using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Entidades;
using Datos;

namespace Datos
{
    public class CitaDAL
    {
        private Conexion conexion;

        public CitaDAL()
        {
            conexion = new Conexion();
        }

        public List<Cita> ObtenerCitas()
        {
            List<Cita> citas = new List<Cita>();

            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"
                        SELECT 
                            c.IdCita, 
                            c.FechaCita, 
                            c.HoraCita, 
                            c.IdPaciente, 
                            c.IdDoctor,
                            c.estado,
                            p.Nombre AS NombrePaciente, 
                            p.Apellido AS ApellidoPaciente, 
                            p.Direccion, 
                            p.Telefono AS TelefonoPaciente,
                            p.Cedula AS CedulaPaciente,
                            p.FechaNacimiento,
                            d.Nombre AS NombreDoctor, 
                            d.Cedula AS CedulaDoctor,
                            d.Telefono AS TelefonoDoctor,
                            d.IdEspecialidad,
                            e.NombreEspecialidad
                        FROM Cita c
                        JOIN Paciente p ON c.IdPaciente = p.IdPaciente
                        JOIN Doctor d ON c.IdDoctor = d.IdDoctor
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
                                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                    Cedula = reader["CedulaPaciente"].ToString(),
                                };

                                var cita = new Cita
                                {
                                    IdCita = Convert.ToInt32(reader["IdCita"]),
                                    FechaCita = Convert.ToDateTime(reader["FechaCita"]),
                                    HoraCita = reader["HoraCita"] != DBNull.Value
                                        ? (TimeSpan)reader["HoraCita"]
                                        : TimeSpan.Zero,
                                    Paciente = paciente,
                                    Doctor = doctor,
                                    Estado = reader["Estado"].ToString(),
                                };

                                citas.Add(cita);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las citas: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            return citas;
        }
        public List<Cita> ObtenerCitasFiltradas(Dictionary<string, object> filtros)
        {
            List<Cita> citas = new List<Cita>();
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"
                SELECT 
                    c.*, 
                    p.Nombre as NombrePaciente, 
                    p.Apellido as ApellidoPaciente,
                    p.Cedula as CedulaPaciente,
                    d.Nombre as NombreDoctor,
                    e.NombreEspecialidad
                FROM Cita c
                JOIN Paciente p ON c.IdPaciente = p.IdPaciente
                JOIN Doctor d ON c.IdDoctor = d.IdDoctor
                JOIN Especialidad e ON d.IdEspecialidad = e.IdEspecialidad
                WHERE 1=1";

                    var parameters = new List<OracleParameter>();

                    if (!string.IsNullOrEmpty(filtros["busqueda"]?.ToString()))
                    {
                        query += @" AND (UPPER(p.Nombre) LIKE UPPER(:busqueda) 
                            OR UPPER(p.Apellido) LIKE UPPER(:busqueda)
                            OR UPPER(p.Cedula) LIKE UPPER(:busqueda))";
                        parameters.Add(new OracleParameter("busqueda", $"%{filtros["busqueda"]}%"));
                    }

                    if (!string.IsNullOrEmpty(filtros["estado"]?.ToString()))
                    {
                        query += " AND UPPER(c.Estado) = UPPER(:estado)";
                        parameters.Add(new OracleParameter("estado", filtros["estado"]));
                    }

                    if (filtros["fecha"] != null)
                    {
                        query += " AND TRUNC(c.FechaCita) = TRUNC(:fecha)";
                        parameters.Add(new OracleParameter("fecha", filtros["fecha"]));
                    }

                    query += " ORDER BY c.FechaCita DESC, c.HoraCita";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                citas.Add(MapearCita(reader));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las citas filtradas: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
            return citas;
        }

        private Cita MapearCita(OracleDataReader reader)
        {
            return new Cita
            {
                IdCita = Convert.ToInt32(reader["IdCita"]),
                FechaCita = Convert.ToDateTime(reader["FechaCita"]),
                HoraCita = (TimeSpan)reader["HoraCita"],
                Estado = reader["Estado"].ToString(),
                Paciente = new Paciente
                {
                    IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                    Nombre = reader["NombrePaciente"].ToString(),
                    Apellido = reader["ApellidoPaciente"].ToString(),
                    Cedula = reader["CedulaPaciente"].ToString()
                },
                Doctor = new Doctor
                {
                    IdDoctor = Convert.ToInt32(reader["IdDoctor"]),
                    Nombre = reader["NombreDoctor"].ToString(),
                    Especialidad = new Especialidad
                    {
                        NombreEspecialidad = reader["NombreEspecialidad"].ToString()
                    }
                }
            };
        }

        public void GuardarCita(Cita cita)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"INSERT INTO Cita 
            (IDPACIENTE, IDDOCTOR, FECHACITA, HORACITA, ESTADO) 
            VALUES 
            (:1, :2, :3, :4, :5)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("1", cita.PacienteId));
                        cmd.Parameters.Add(new OracleParameter("2", cita.DoctorId));
                        cmd.Parameters.Add(new OracleParameter("3", cita.FechaCita.Date));
                        cmd.Parameters.Add(new OracleParameter("4", cita.HoraCita));
                        cmd.Parameters.Add(new OracleParameter("5", "Pendiente"));

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar la cita: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public List<TimeSpan> ObtenerHorariosDisponibles(int idDoctor, DateTime fecha)
        {
            List<TimeSpan> horariosDisponibles = new List<TimeSpan>();
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string diaSemana = ObtenerNombreDiaSemana(fecha.DayOfWeek);

                    string queryHorario = @"SELECT HoraInicio, HoraFin 
                FROM Horario 
                WHERE IdDoctor = :IdDoctor 
                AND UPPER(DiaSemana) = UPPER(:DiaSemana)";

                    using (OracleCommand cmd = new OracleCommand(queryHorario, conn))
                    {
                        cmd.Parameters.Add("IdDoctor", OracleDbType.Int32).Value = idDoctor;
                        cmd.Parameters.Add("DiaSemana", OracleDbType.Varchar2).Value = diaSemana;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TimeSpan horaInicio = (TimeSpan)reader["HoraInicio"];
                                TimeSpan horaFin = (TimeSpan)reader["HoraFin"];
                                TimeSpan intervalo = TimeSpan.FromMinutes(30); 

                                
                                for (TimeSpan hora = horaInicio; hora < horaFin; hora = hora.Add(intervalo))
                                {
                                    horariosDisponibles.Add(hora);
                                }

                                string queryCitas = @"SELECT HoraCita 
                            FROM Cita 
                            WHERE IdDoctor = :IdDoctor 
                            AND FechaCita = :Fecha";

                                using (OracleCommand cmdCitas = new OracleCommand(queryCitas, conn))
                                {
                                    cmdCitas.Parameters.Add("IdDoctor", OracleDbType.Int32).Value = idDoctor;
                                    cmdCitas.Parameters.Add("Fecha", OracleDbType.Date).Value = fecha.Date;

                                    using (OracleDataReader readerCitas = cmdCitas.ExecuteReader())
                                    {
                                        while (readerCitas.Read())
                                        {
                                            TimeSpan horaOcupada = (TimeSpan)readerCitas["HoraCita"];
                                            horariosDisponibles.Remove(horaOcupada);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener horarios disponibles: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            if (horariosDisponibles.Count == 0)
            {
                throw new Exception($"No hay horarios disponibles para el día {fecha.ToShortDateString()}");
            }

            return horariosDisponibles;
        }

        private string ObtenerNombreDiaSemana(DayOfWeek dia)
        {
            switch (dia)
            {
                case DayOfWeek.Monday:
                    return "Lunes";
                case DayOfWeek.Tuesday:
                    return "Martes";
                case DayOfWeek.Wednesday:
                    return "Miércoles";
                case DayOfWeek.Thursday:
                    return "Jueves";
                case DayOfWeek.Friday:
                    return "Viernes";
                case DayOfWeek.Saturday:
                    return "Sábado";
                case DayOfWeek.Sunday:
                    return "Domingo";
                default:
                    throw new ArgumentException("Día de la semana no válido");
            }
        }

        private bool ExisteCitaDoctor(OracleConnection conn, int? idDoctor, DateTime fecha, TimeSpan hora)
        {
            string query = @"
                SELECT COUNT(*) 
                FROM Cita 
                WHERE IdDoctor = :IdDoctor 
                AND FechaCita = :FechaCita 
                AND HoraCita = :HoraCita";

            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                cmd.Parameters.Add(new OracleParameter("IdDoctor", idDoctor));
                cmd.Parameters.Add(new OracleParameter("FechaCita", fecha));
                cmd.Parameters.Add(new OracleParameter("HoraCita", hora));

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public void ActualizarCita(Cita cita)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "UPDATE Cita SET Estado = :Estado WHERE IdCita = :IdCita";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Estado", cita.Estado));
                        cmd.Parameters.Add(new OracleParameter("IdCita", cita.IdCita));

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            throw new Exception("No se encontró la cita para actualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la cita: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
    

        private bool ExisteCitaDoctorExcluyendoActual(OracleConnection conn, int? idDoctor, DateTime fecha, TimeSpan hora, int? idCita)
        {
            string query = @"
                SELECT COUNT(*) 
                FROM Cita 
                WHERE IdDoctor = :IdDoctor 
                AND FechaCita = :FechaCita 
                AND HoraCita = :HoraCita 
                AND IdCita != :IdCita";

            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                cmd.Parameters.Add(new OracleParameter("IdDoctor", idDoctor));
                cmd.Parameters.Add(new OracleParameter("FechaCita", fecha));
                cmd.Parameters.Add(new OracleParameter("HoraCita", hora));
                cmd.Parameters.Add(new OracleParameter("IdCita", idCita));

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public List<Cita> ObtenerCitasPorPaciente(int? idPaciente)
        {
            List<Cita> citas = new List<Cita>();
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"
                SELECT 
                    c.IdCita, 
                    c.FechaCita, 
                    c.HoraCita, 
                    c.Estado,
                    d.IdDoctor,
                    d.Nombre AS NombreDoctor,
                    e.IdEspecialidad,
                    e.NombreEspecialidad,
                    p.IdPaciente,
                    p.Nombre AS NombrePaciente,
                    p.Apellido AS ApellidoPaciente
                FROM Cita c
                JOIN Doctor d ON c.IdDoctor = d.IdDoctor
                JOIN Especialidad e ON d.IdEspecialidad = e.IdEspecialidad
                JOIN Paciente p ON c.IdPaciente = p.IdPaciente
                WHERE c.IdPaciente = :IdPaciente
                ORDER BY c.FechaCita DESC, c.HoraCita";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdPaciente", idPaciente));

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
                                    Nombre = reader["NombreDoctor"].ToString(),
                                    Especialidad = especialidad
                                };

                                var paciente = new Paciente
                                {
                                    IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                                    Nombre = reader["NombrePaciente"].ToString(),
                                    Apellido = reader["ApellidoPaciente"].ToString()
                                };

                                var cita = new Cita
                                {
                                    IdCita = Convert.ToInt32(reader["IdCita"]),
                                    FechaCita = Convert.ToDateTime(reader["FechaCita"]),
                                    HoraCita = (TimeSpan)reader["HoraCita"],
                                    Estado = reader["Estado"].ToString(),
                                    Doctor = doctor,
                                    Paciente = paciente
                                };

                                citas.Add(cita);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las citas del paciente: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
            return citas;
        }
        public void EliminarCita(int idCita)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "DELETE FROM Cita WHERE IdCita = :IdCita";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdCita", idCita));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la cita: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
    }
}