using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;

namespace FrbaHotel.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public override IEnumerable<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();

            SqlCommand command = DBConnection.CreateCommand();
            command.CommandText = "SELECT * FROM Usuario";
            
            SqlDataReader reader = DBConnection.EjecutarComandoSelect(command);
            while (reader.Read())
            {
                usuarios.Add(this.CreateUsuario(reader));
            }

            return usuarios;

        }

        public override Usuario Get(int id)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("NombreDelSP");
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = DBConnection.EjecutarComandoSelect(command);

            if (reader.Read())
            {
                return this.CreateUsuario(reader);
            }

            return null;
        }

        public override int Insert(Usuario entity)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("NombreDelSP");
            AddUsuarioParameters(entity, command);
            return DBConnection.ExecuteNonQuery(command);
        }

        public override void Update(Usuario entity)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("NombreDelSP");
            AddUsuarioParameters(entity, command);
            DBConnection.ExecuteNonQuery(command);
        }

        public override void Delete(Usuario entity)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("NombreDelSP");
            command.Parameters.AddWithValue("@id", entity.Id);
            DBConnection.ExecuteNonQuery(command);
        }

        public Usuario GetByUsernameAndPassword(string username, string password)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("NombreDelSP");
            command.Parameters.AddWithValue("@userName", username);
            command.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = DBConnection.EjecutarComandoSelect(command);

            Usuario usuario = null;

            if (reader.Read())
            {
                return this.CreateUsuario(reader);
            }

            return usuario;
        }

        private Usuario CreateUsuario(SqlDataReader reader)
        {
            Usuario usuario = new Usuario();
            usuario.Apellido = reader["apellido"].ToString();
            usuario.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
            usuario.Mail = reader["mail"].ToString();
            usuario.Nombre = reader["nombre"].ToString();
            usuario.NumeroDocumento = reader["numeroDocumento"].ToString();
            usuario.Telefono = reader["telefono"].ToString();
            usuario.TipoDeDocumento = new TipoDocumento { Id = Convert.ToInt32(reader["TipoDocumentoId"]), Nombre = reader["TipoDocumentoNombre"].ToString() };
            usuario.Direccion = new Direccion { Calle = reader["direccion"].ToString() };
            usuario.Id = Convert.ToInt32(reader["id"]);
            usuario.HotelUsuario = new Hotel { Id = Convert.ToInt32(reader["hotelId"]) };
            usuario.Rol = new Rol { Id = Convert.ToInt32(reader["rolId"]), Nombre = reader["rol"].ToString()};
            usuario.Username = reader["userName"].ToString();

            return usuario;
        }

        private static void AddUsuarioParameters(Usuario usuario, SqlCommand command)
        {
            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@apellido", usuario.Apellido);
            command.Parameters.AddWithValue("@direccionCalle", usuario.Direccion.Calle);
            command.Parameters.AddWithValue("@direccionNumero", usuario.Direccion.Numero);
            command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
            command.Parameters.AddWithValue("@mail", usuario.Mail);
            command.Parameters.AddWithValue("@numeroDocumento", usuario.NumeroDocumento);
            command.Parameters.AddWithValue("@telefono", usuario.Telefono);
            command.Parameters.AddWithValue("@tipoDocumento", usuario.TipoDeDocumento.Id);
            command.Parameters.AddWithValue("@hotelId", usuario.HotelUsuario.Id);
            command.Parameters.AddWithValue("@password", usuario.Password);
            command.Parameters.AddWithValue("@rolId", usuario.Rol.Id);
            command.Parameters.AddWithValue("@userName", usuario.Username);
        }
    }
}
