using Oracle.ManagedDataAccess.Client;
using System;
using System.Diagnostics;

namespace Datos
{
    public class Conexion
    {
        private readonly string connectionString;

        public Conexion()
        {
            connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=C##saludigital;Password=12345678";

        }

        public OracleConnection AbrirConexion()
        {
            try
            {
                OracleConnection connection = new OracleConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexión exitosa a la base de datos Oracle.");
                return connection; 
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message} (Código de Error: {ex.Number})");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Operación inválida: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Otro error: {ex.Message}");
            }

            return null; 
        }


        public void CloseConnection(OracleConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada exitosamente.");
            }
        }
    }
}
