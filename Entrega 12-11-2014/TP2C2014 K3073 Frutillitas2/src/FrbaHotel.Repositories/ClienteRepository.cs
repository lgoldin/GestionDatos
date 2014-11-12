using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;

namespace FrbaHotel.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>
    {
        public override IEnumerable<Cliente> GetAll()
        {
            List<Cliente> clientes = new List<Cliente>();

            SqlCommand _comando = DBConnection.CreateCommand();
            _comando.CommandText = "SELECT * FROM Cliente";
            SqlDataReader reader = DBConnection.EjecutarComandoSelect(_comando);

            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                CreateCliente(cliente, reader);
                clientes.Add(cliente);
            }
            
            return clientes;
        }

        public override Cliente Get(int id)
        {
            Cliente cliente = new Cliente();

            SqlCommand _comando = DBConnection.CreateStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = DBConnection.EjecutarComandoSelect(_comando);


            if(reader.Read())
            {
                CreateCliente(cliente, reader);
            }
            
            return cliente;
        }

        public override int Insert(Cliente entity)
        {
            SqlCommand _comando = DBConnection.CreateStoredProcedure("NombreDelSP");
            AddClienteParameters(entity, _comando);
            return DBConnection.ExecuteNonQuery(_comando);
        }

        public override void Update(Cliente entity)
        {
            SqlCommand _comando = DBConnection.CreateStoredProcedure("NombreDelSP");
            AddClienteParameters(entity, _comando);
            DBConnection.ExecuteNonQuery(_comando);
        }

        public override void Delete(Cliente entity)
        {
            SqlCommand _comando = DBConnection.CreateStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@id", entity.Id);
            DBConnection.ExecuteNonQuery(_comando);
        }

        private static void CreateCliente(Cliente cliente, SqlDataReader reader)
        {
            /*
            cliente.Apellido = reader["apellido"].ToString();
            cliente.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
            cliente.Mail = reader["mail"].ToString();
            cliente.Nacionalidad = reader["nacionalidad"].ToString();
            cliente.Nombre = reader["nombre"].ToString();
            cliente.NumeroDocumento = reader["numeroDocumente"].ToString();
            cliente.Telefono = reader["telefono"].ToString();
            cliente.TipoDeDocumento = (TipoDocumento)Convert.ToInt32(reader["tipoDocumento"]);
            cliente.Direccion = new Direccion() { Calle = reader["direccion"].ToString() };
            cliente.Id = Convert.ToInt32(reader["id"]);
            */
        }

        private static void AddClienteParameters(Cliente cliente, SqlCommand _comando)
        {
            /*
            _comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            _comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
            _comando.Parameters.AddWithValue("@direccionCalle", cliente.Direccion.Calle);
            _comando.Parameters.AddWithValue("@direccionNumero", cliente.Direccion.Numero);
            _comando.Parameters.AddWithValue("@fechaNacimiento", cliente.FechaNacimiento);
            _comando.Parameters.AddWithValue("@mail", cliente.Mail);
            _comando.Parameters.AddWithValue("@nacionalidad", cliente.Nacionalidad);
            _comando.Parameters.AddWithValue("@numeroDocumento", cliente.NumeroDocumento);
            _comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            _comando.Parameters.AddWithValue("@tipoDocumento", (int)cliente.TipoDeDocumento);
            */
        }
    }
}
