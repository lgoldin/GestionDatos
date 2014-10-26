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

            SqlCommand _comando = DBConnection.CrearComando();
            _comando.CommandText = "SELECT * FROM Cliente";
            SqlDataReader reader = DBConnection.EjecutarComandoSelect(_comando);

            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Apellido = reader["apellido"].ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                cliente.Mail = reader["mail"].ToString();
                cliente.Nacionalidad = reader["nacionalidad"].ToString();
                cliente.Nombre = reader["nombre"].ToString();
                cliente.NumeroDocumento = reader["numeroDocumente"].ToString();
                cliente.Telefono = reader["telefono"].ToString();
                cliente.TipoDocumento = reader["tipoDocumento"].ToString();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Direccion = new Direccion() { Calle = reader["direccion"].ToString() };

                clientes.Add(cliente);
            }

            return clientes;
        }

        public override Cliente Get(int id)
        {
            Cliente cliente = new Cliente();

            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = DBConnection.EjecutarComandoSelect(_comando);


            if(reader.Read())
            {
                cliente.Apellido = reader["apellido"].ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                cliente.Mail = reader["mail"].ToString();
                cliente.Nacionalidad = reader["nacionalidad"].ToString();
                cliente.Nombre = reader["nombre"].ToString();
                cliente.NumeroDocumento = reader["numeroDocumente"].ToString();
                cliente.Telefono = reader["telefono"].ToString();
                cliente.TipoDocumento = reader["tipoDocumento"].ToString();
                cliente.Direccion = new Direccion() { Calle = reader["direccion"].ToString()};
            }

            return cliente;
        }

        public override int Insert(Cliente entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@nombre", entity.Nombre);
            _comando.Parameters.AddWithValue("@apellido", entity.Apellido);
            _comando.Parameters.AddWithValue("@direccionCalle", entity.Direccion.Calle);
            _comando.Parameters.AddWithValue("@direccionNumero", entity.Direccion.Numero);
            _comando.Parameters.AddWithValue("@fechaNacimiento", entity.FechaNacimiento);
            _comando.Parameters.AddWithValue("@mail", entity.Mail);
            _comando.Parameters.AddWithValue("@nacionalidad", entity.Nacionalidad);
            _comando.Parameters.AddWithValue("@numeroDocumento", entity.NumeroDocumento);
            _comando.Parameters.AddWithValue("@telefono", entity.Telefono);
            _comando.Parameters.AddWithValue("@tipoDocumento", entity.TipoDocumento);
            return DBConnection.EjecutarComandoNonQuery(_comando);
        }

        public override void Update(Cliente entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@nombre", entity.Nombre);
            _comando.Parameters.AddWithValue("@apellido", entity.Apellido);
            _comando.Parameters.AddWithValue("@direccionCalle", entity.Direccion.Calle);
            _comando.Parameters.AddWithValue("@direccionNumero", entity.Direccion.Numero);
            _comando.Parameters.AddWithValue("@fechaNacimiento", entity.FechaNacimiento);
            _comando.Parameters.AddWithValue("@mail", entity.Mail);
            _comando.Parameters.AddWithValue("@nacionalidad", entity.Nacionalidad);
            _comando.Parameters.AddWithValue("@numeroDocumento", entity.NumeroDocumento);
            _comando.Parameters.AddWithValue("@telefono", entity.Telefono);
            _comando.Parameters.AddWithValue("@tipoDocumento", entity.TipoDocumento);
            DBConnection.EjecutarComandoNonQuery(_comando);
        }

        public override void Delete(Cliente entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@nombre", entity.Id);
            DBConnection.EjecutarComandoNonQuery(_comando);
        }
    }
}
