using System;
using System.Data.SqlClient;

namespace Semana_5_Tarea_1.config
{
        public static class Conexion
    {
        private static readonly string connectionString;

        static Conexion()
        {
            connectionString = "Server=DESKTOP-PS51K8K\\SQLEXPRESS;Database=pubs;User Id=sa;Password=12345;";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        }
    }
}
