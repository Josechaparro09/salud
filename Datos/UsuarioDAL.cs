using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Entidades;
using Datos;

namespace Datos
{
    public class UsuarioDAL
    {
        private Conexion conexion;

        public UsuarioDAL()
        {
            conexion = new Conexion();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "SELECT u.IdUsuario, u.Nombres, u.Apellidos, u.NombreUsuario, u.Contraseña, u.idRol, r.nombreRol FROM Usuario u LEFT JOIN Rol r ON u.idRol = r.idRol";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var rol = new Rol
                                {
                                    IdRol = reader["idRol"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["idRol"]),
                                    NombreRol = reader["nombreRol"].ToString()
                                };

                                var usuario = new Usuario
                                {
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                    Nombres = reader["Nombres"].ToString(),
                                    Apellidos = reader["Apellidos"].ToString(),
                                    NombreUsuario = reader["NombreUsuario"].ToString(),
                                    Contraseña = reader["Contraseña"].ToString(),
                                    Rol = rol
                                };

                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los usuarios: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

            return usuarios;
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "INSERT INTO Usuario (Nombres, Apellidos, NombreUsuario, Contraseña, idRol) " +
                                   "VALUES (:Nombres, :Apellidos, :NombreUsuario, :Contraseña, :idRol)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Nombres", usuario.Nombres));
                        cmd.Parameters.Add(new OracleParameter("Apellidos", usuario.Apellidos));
                        cmd.Parameters.Add(new OracleParameter("NombreUsuario", usuario.NombreUsuario));
                        cmd.Parameters.Add(new OracleParameter("Contraseña", usuario.Contraseña));
                        cmd.Parameters.Add(new OracleParameter("idRol", usuario.Rol.IdRol));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar el usuario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "UPDATE Usuario SET Nombres = :Nombres, Apellidos = :Apellidos, NombreUsuario = :NombreUsuario, Contraseña = :Contraseña, idRol = :idRol " +
                                   "WHERE IdUsuario = :IdUsuario";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Nombres", usuario.Nombres));
                        cmd.Parameters.Add(new OracleParameter("Apellidos", usuario.Apellidos));
                        cmd.Parameters.Add(new OracleParameter("NombreUsuario", usuario.NombreUsuario));
                        cmd.Parameters.Add(new OracleParameter("Contraseña", usuario.Contraseña));
                        cmd.Parameters.Add(new OracleParameter("idRol", usuario.Rol.IdRol));
                        cmd.Parameters.Add(new OracleParameter("IdUsuario", usuario.IdUsuario));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el usuario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }

        public void EliminarUsuario(int idUsuario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = "DELETE FROM Usuario WHERE IdUsuario = :IdUsuario";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("IdUsuario", idUsuario));

                        cmd.ExecuteNonQuery(); 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el usuario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }
        }
        public Usuario RegistrarUsuarioYPaciente(Usuario usuario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                OracleTransaction transaction = null;
                try
                {
                    transaction = conn.BeginTransaction();

                    string queryUsuario = @"INSERT INTO Usuario 
                (Nombres, Apellidos, NombreUsuario, Contraseña, idRol) 
                VALUES (:Nombres, :Apellidos, :NombreUsuario, :Contraseña, :idRol) 
                RETURNING IdUsuario INTO :IdUsuario";

                    int idUsuarioGenerado;
                    using (OracleCommand cmd = new OracleCommand(queryUsuario, conn))
                    {
                        cmd.Transaction = transaction;

                        cmd.Parameters.Add(new OracleParameter("Nombres", usuario.Nombres));
                        cmd.Parameters.Add(new OracleParameter("Apellidos", usuario.Apellidos));
                        cmd.Parameters.Add(new OracleParameter("NombreUsuario", usuario.NombreUsuario));
                        cmd.Parameters.Add(new OracleParameter("Contraseña", usuario.Contraseña));
                        cmd.Parameters.Add(new OracleParameter("idRol", usuario.Rol.IdRol));

                        OracleParameter paramId = new OracleParameter("IdUsuario", OracleDbType.Int32);
                        paramId.Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add(paramId);

                        cmd.ExecuteNonQuery();
                        idUsuarioGenerado = Convert.ToInt32(paramId.Value.ToString());
                        usuario.IdUsuario = idUsuarioGenerado;
                    }

                    string queryPaciente = @"INSERT INTO Paciente 
                (Nombre, Apellido, Cedula, Telefono, Direccion, IdUsuario, FechaNacimiento) 
                VALUES (:Nombre, :Apellido, :Cedula, :Telefono, :Direccion, :IdUsuario, :FechaNacimiento)";

                    using (OracleCommand cmd = new OracleCommand(queryPaciente, conn))
                    {
                        cmd.Transaction = transaction;

                        cmd.Parameters.Add(new OracleParameter("Nombre", usuario.Nombres));
                        cmd.Parameters.Add(new OracleParameter("Apellido", usuario.Apellidos));
                        cmd.Parameters.Add(new OracleParameter("Cedula", DBNull.Value));
                        cmd.Parameters.Add(new OracleParameter("Telefono", DBNull.Value));
                        cmd.Parameters.Add(new OracleParameter("Direccion", DBNull.Value));
                        cmd.Parameters.Add(new OracleParameter("IdUsuario", idUsuarioGenerado));
                        cmd.Parameters.Add(new OracleParameter("FechaNacimiento", DateTime.Now)); 

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    return usuario;
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw new Exception("Error al registrar usuario y paciente: " + ex.Message);
                }
                finally
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                    }
                    conexion.CloseConnection(conn);
                }
            }
        }
        public Usuario ValidarUsuario(string nombreUsuario, string contraseña)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"SELECT u.IdUsuario, u.Nombres, u.Apellidos, u.NombreUsuario, 
                           u.idRol, r.nombreRol 
                           FROM Usuario u 
                           LEFT JOIN Rol r ON u.idRol = r.idRol 
                           WHERE u.NombreUsuario = :nombreUsuario 
                           AND u.Contraseña = :contraseña";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add("nombreUsuario", nombreUsuario);
                        cmd.Parameters.Add("contraseña", contraseña);

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var rol = new Rol
                                {
                                    IdRol = reader["idRol"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["idRol"]),
                                    NombreRol = reader["nombreRol"].ToString()
                                };

                                return new Usuario
                                {
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                    Nombres = reader["Nombres"].ToString(),
                                    Apellidos = reader["Apellidos"].ToString(),
                                    NombreUsuario = reader["NombreUsuario"].ToString(),
                                    Rol = rol
                                };
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar usuario: " + ex.Message);
                }
                finally
                {
                    conexion.CloseConnection(conn);
                }
            }

        }
        public int RegistrarUsuarioConRol(Usuario usuario)
        {
            using (OracleConnection conn = conexion.AbrirConexion())
            {
                OracleTransaction transaction = null;
                try
                {
                    transaction = conn.BeginTransaction();


                    string queryUsuario = @"INSERT INTO Usuario 
                (Nombres, Apellidos, NombreUsuario, Contraseña, idRol) 
                VALUES (:Nombres, :Apellidos, :NombreUsuario, :Contraseña, :idRol) 
                RETURNING IdUsuario INTO :IdUsuario";

                    int idUsuarioGenerado;
                    using (OracleCommand cmd = new OracleCommand(queryUsuario, conn))
                    {
                        cmd.Transaction = transaction;

                        cmd.Parameters.Add(new OracleParameter("Nombres", usuario.Nombres));
                        cmd.Parameters.Add(new OracleParameter("Apellidos", usuario.Apellidos));
                        cmd.Parameters.Add(new OracleParameter("NombreUsuario", usuario.NombreUsuario));
                        cmd.Parameters.Add(new OracleParameter("Contraseña", usuario.Contraseña));
                        cmd.Parameters.Add(new OracleParameter("idRol", usuario.Rol.IdRol));

                        OracleParameter paramId = new OracleParameter("IdUsuario", OracleDbType.Int32);
                        paramId.Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add(paramId);

                        cmd.ExecuteNonQuery();
                        idUsuarioGenerado = Convert.ToInt32(paramId.Value.ToString());
                    }

                    transaction.Commit();
                    return idUsuarioGenerado;
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                        transaction.Rollback();
                    throw new Exception("Error al registrar usuario: " + ex.Message);
                }
                finally
                {
                    if (transaction != null)
                        transaction.Dispose();
                    conexion.CloseConnection(conn);
                }
            }
        }
    }

}
