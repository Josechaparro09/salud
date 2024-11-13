using Oracle.ManagedDataAccess.Client;
using System;


namespace Datos
{
    public class Conexion
    {
        private readonly string connectionString;

        public Conexion()
        {
            // Asegúrate de que esta cadena de conexión coincida exactamente con tu configuración
            connectionString = "Data Source=localhost:1521/xe;User Id=C##saludigital;Password=12345678;";
        }

        public OracleConnection AbrirConexion()
        {
            try
            {
                var connection = new OracleConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle (Código: {ex.Number}): {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general: {ex.Message}");
                throw;
            }
        }

        public void CloseConnection(OracleConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}