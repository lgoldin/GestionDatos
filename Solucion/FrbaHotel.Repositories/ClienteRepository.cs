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
            SqlCommand command = DBConnection.CreateStoredProcedure("InsertCliente");
            AddClienteParameters(entity, command);
            return DBConnection.ExecuteScalar(command);
        }

        public override void Update(Cliente entity)
        {
            throw new NotImplementedException();
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
            cliente.Nacionalidad = Convert.ToInt32(row["nacionalidadId"]);
            cliente.Nombre = row["nombre"].ToString();
            cliente.NumeroDocumento = row["numeroDocumento"].ToString();
            cliente.Telefono = row["telefono"].ToString();
            cliente.TipoDeDocumento = new TipoDocumento() { Id = Convert.ToInt32(row["tipoDocumentoId"]), Nombre = (row["tipoDocumentoNombre"]).ToString() };
            cliente.Direccion = (row["direccion"]).ToString();
            cliente.Id = Convert.ToInt32(row["id"]);
            return cliente;
        }

        private static void AddClienteParameters(Cliente cliente, SqlCommand command)
        {
            command.Parameters.AddWithValue("@nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@apellido", cliente.Apellido);
            command.Parameters.AddWithValue("@direccion", cliente.Direccion);
            command.Parameters.AddWithValue("@fechaNacimiento", cliente.FechaNacimiento);
            command.Parameters.AddWithValue("@mail", cliente.Mail);
            command.Parameters.AddWithValue("@nacionalidadId", cliente.Nacionalidad);
            command.Parameters.AddWithValue("@numeroDocumento", cliente.NumeroDocumento);
            command.Parameters.AddWithValue("@telefono", cliente.Telefono);
            command.Parameters.AddWithValue("@tipoDocumentoId", cliente.TipoDeDocumento.Id);
        }

        public Cliente GetByEmail(string mail)
        {
            Cliente cliente = new Cliente();
            SqlCommand command = DBConnection.CreateStoredProcedure("GetClienteByEmail");
            command.Parameters.AddWithValue("@email", mail);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            if(collection.Count > 0)
            cliente = CreateCliente(collection[0]);
            return cliente;
        }

        public Cliente GetByTipoYNumeroDocumento(int tipoDocumento, string numeroDocumento)
        {
            Cliente cliente = new Cliente();
            SqlCommand command = DBConnection.CreateStoredProcedure("GetClienteByTipoYNumeroDocumento");
            command.Parameters.AddWithValue("@tipoDocoumentoId", tipoDocumento);
            command.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            if (collection.Count > 0)
                cliente = CreateCliente(collection[0]);
            return cliente;
        }
    }
}
