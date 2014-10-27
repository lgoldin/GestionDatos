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

            SqlCommand _comando = DBConnection.CrearComando();
            _comando.CommandText = "SELECT * FROM Usuario";
            SqlDataReader reader = DBConnection.EjecutarComandoSelect(_comando);

            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                CreateUsuario(usuario, reader);
                usuarios.Add(usuario);
            }

            return usuarios;

        }

        public override Usuario Get(int id)
        {
            Usuario usuario = new Usuario();

            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = DBConnection.EjecutarComandoSelect(_comando);


            if (reader.Read())
            {
                CreateUsuario(usuario, reader);
            }

            return usuario;
        }

        public override int Insert(Usuario entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            AddUsuarioParameters(entity, _comando);
            return DBConnection.EjecutarComandoNonQuery(_comando);
        }

        public override void Update(Usuario entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            AddUsuarioParameters(entity, _comando);
            DBConnection.EjecutarComandoNonQuery(_comando);
        }

        public override void Delete(Usuario entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@id", entity.Id);
            DBConnection.EjecutarComandoNonQuery(_comando);
        }

        public Usuario GetByUsernameAndPassword(string username, string password)
        {
            Usuario usuario = new Usuario();

            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@userName", username);
            _comando.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = DBConnection.EjecutarComandoSelect(_comando);

            if (reader.Read())
            {
                CreateUsuario(usuario, reader);
            }

            return usuario;
        }

        private static void CreateUsuario(Usuario usuario, SqlDataReader reader)
        {
            usuario.Apellido = reader["apellido"].ToString();
            usuario.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
            usuario.Mail = reader["mail"].ToString();
            usuario.Nombre = reader["nombre"].ToString();
            usuario.NumeroDocumento = reader["numeroDocumente"].ToString();
            usuario.Telefono = reader["telefono"].ToString();
            usuario.TipoDeDocumento = (TipoDocumento)Convert.ToInt32(reader["tipoDocumento"]);
            usuario.Direccion = new Direccion() { Calle = reader["direccion"].ToString() };
            usuario.Id = Convert.ToInt32(reader["id"]);
            usuario.HotelUsuario = new Hotel() { Id = Convert.ToInt32(reader["hotelId"]) };
            usuario.Rol = new RolUsuario() { Id = Convert.ToInt32(reader["rolId"]), Rol = reader["rol"].ToString()};
            usuario.Username = reader["userName"].ToString();
        }

        private static void AddUsuarioParameters(Usuario usuario, SqlCommand _comando)
        {
            _comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            _comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
            _comando.Parameters.AddWithValue("@direccionCalle", usuario.Direccion.Calle);
            _comando.Parameters.AddWithValue("@direccionNumero", usuario.Direccion.Numero);
            _comando.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
            _comando.Parameters.AddWithValue("@mail", usuario.Mail);
            _comando.Parameters.AddWithValue("@numeroDocumento", usuario.NumeroDocumento);
            _comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
            _comando.Parameters.AddWithValue("@tipoDocumento", (int)usuario.TipoDeDocumento);
            _comando.Parameters.AddWithValue("@hotelId", usuario.HotelUsuario.Id);
            _comando.Parameters.AddWithValue("@password", usuario.Password);
            _comando.Parameters.AddWithValue("@rolId", usuario.Rol.Id);
            _comando.Parameters.AddWithValue("@userName", usuario.Username);
        }
    }
}
