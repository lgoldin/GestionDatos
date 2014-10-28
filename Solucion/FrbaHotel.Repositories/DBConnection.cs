using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace FrbaHotel.Repositories
{
    public static class DBConnection
    {
        private static string connectionString = ConfigurationSettings.AppSettings["FrbaHotel"];

        public static string ConnectionString
        {
            get { return connectionString; }
        }

        public static SqlCommand CreateCommand()
        {
            string conn = ConnectionString;

            SqlConnection conexion = new SqlConnection(conn);

            SqlCommand command = conexion.CreateCommand();
            command.CommandType = CommandType.Text;
            
            return command;
        }

        public static SqlCommand CreateStoredProcedure(string storedName)
        {
            SqlConnection conexion = new SqlConnection(ConnectionString);
            
            SqlCommand command = conexion.CreateCommand();
            command.CommandText = storedName;
            command.CommandType = CommandType.StoredProcedure;
            
            return command;
        }

        public static int ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception; 
            }
            finally
            {
                command.Connection.Close();
                command.Connection.Dispose();
            }
        }

        public static SqlDataReader EjecutarComandoSelect(SqlCommand command)
        {
            SqlDataReader reader = null;
            
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception exception)
            { 
                throw exception; 
            }
            finally
            {
                reader.Close();
                CloseCommand(command);
            }

            return reader;

            //Dejo esto comentado porque puede llegar a servir:

            /*DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { comando.Connection.Close(); }
            return _tabla;*/
        }

        public static void CloseCommand(SqlCommand command)
        {
            command.Connection.Close();
            command.Connection.Dispose();
            command.Dispose();
        }
    }
}
