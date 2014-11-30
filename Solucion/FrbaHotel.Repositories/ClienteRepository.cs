using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>
    {
        public override IEnumerable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Cliente Get(int id)
        {
            throw new NotImplementedException();
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

        private Cliente CreateCliente(DataRow row)
        {
            Cliente cliente = new Cliente();
            cliente.Apellido = row["apellido"].ToString();
            cliente.FechaNacimiento = Convert.ToDateTime(row["fechaNacimiento"]);
            cliente.Mail = row["mail"].ToString();
            cliente.Nacionalidad = Convert.ToInt32(row["nacionalidad"]);
            cliente.Nombre = row["nombre"].ToString();
            cliente.NumeroDocumento = row["numeroDocumente"].ToString();
            cliente.Telefono = row["telefono"].ToString();
            cliente.TipoDeDocumento = new TipoDocumento() { Id = Convert.ToInt32(row["tipoDocumentoId"]), Nombre = (row["tipoDocumentoNombre"]).ToString() };
            cliente.Direccion = (row["direccion"]).ToString();
            cliente.Id = Convert.ToInt32(row["id"]);
            return cliente;
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

        public Cliente GetByEmail(string mail)
        {
            Cliente cliente = new Cliente();
            SqlCommand command = DBConnection.CreateStoredProcedure("GetClienteByMail");
            command.Parameters.AddWithValue("@email", cliente.Mail);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            //Id = Convert.ToInt32(row["Id"])
            CreateCliente(collection[0]);
            return null;
        }
    }
}
