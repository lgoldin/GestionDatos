using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Transactions;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public override IEnumerable<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            
            SqlCommand command = DBConnection.CreateStoredProcedure("GetUsuarios");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow usuario in collection)
            {
                Usuario entity = this.CreateUsuario(usuario);

                command = DBConnection.CreateStoredProcedure("GetHotelesByIdUsuario");
                command.Parameters.AddWithValue("@usuarioId", entity.Id);
                collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
                foreach (DataRow hotel in collection)
                {
                    entity.Hoteles.Add(this.CreateHotel(hotel));
                }

                usuarios.Add(entity);
            }
            
            return usuarios;
        }

        public override Usuario Get(int id)
        {
            return this.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public override int Insert(Usuario entity)
        {
            int id;
            using (var transaction = new TransactionScope())
            {
                SqlCommand command = DBConnection.CreateStoredProcedure("InsertUsuario");
                InsertUsuarioParameters(entity, command);
                id = DBConnection.ExecuteScalar(command);

                foreach (Hotel hotel in entity.Hoteles)
                {
                    command = DBConnection.CreateStoredProcedure("InsertUsuarioHotel");
                    AddUsuarioHotelesParameters(id, hotel, command);
                    DBConnection.ExecuteNonQuery(command);
                }
                
                transaction.Complete();
            }

            return id;
        }

        public override void Update(Usuario entity)
        {
            using (var transaction = new TransactionScope())
            {
                SqlCommand command = DBConnection.CreateStoredProcedure("UpdateUsuario");
                UpdateUsuarioParameters(entity, command);
                DBConnection.ExecuteNonQuery(command);

                foreach (Hotel hotel in entity.Hoteles)
                {
                    command = DBConnection.CreateStoredProcedure("InsertUsuarioHotel");
                    AddUsuarioHotelesParameters(entity.Id, hotel, command);
                    DBConnection.ExecuteNonQuery(command);
                }

                transaction.Complete();
            }
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
            usuario.TipoDocumento = new TipoDocumento { Id = Convert.ToInt32(reader["TipoDocumentoId"]), Nombre = reader["TipoDocumentoNombre"].ToString() };
            usuario.Direccion = new Direccion { Calle = reader["direccion"].ToString() };
            usuario.Id = Convert.ToInt32(reader["id"]);
            usuario.Rol = new Rol { Id = Convert.ToInt32(reader["rolId"]), Nombre = reader["rol"].ToString()};
            usuario.Username = reader["userName"].ToString();

            return usuario;
        }

        private Usuario CreateUsuario(DataRow reader)
        {
            Usuario usuario = new Usuario();
            usuario.Apellido = reader["apellido"].ToString();
            usuario.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
            usuario.Mail = reader["mail"].ToString();
            usuario.Nombre = reader["nombre"].ToString();
            usuario.NumeroDocumento = reader["numeroDocumento"].ToString();
            usuario.Telefono = reader["telefono"].ToString();
            usuario.TipoDocumento = new TipoDocumento { Id = Convert.ToInt32(reader["TipoDocumentoId"]), Nombre = reader["TipoDocumentoNombre"].ToString() };
            usuario.Direccion = new Direccion { Calle = reader["direccion"].ToString() };
            usuario.Id = Convert.ToInt32(reader["id"]);
            usuario.Rol = new Rol { Id = Convert.ToInt32(reader["rolId"]), Nombre = reader["rol"].ToString() };
            usuario.Username = reader["userName"].ToString();
            usuario.Hoteles = new List<Hotel>();

            return usuario;
        }

        private static void InsertUsuarioParameters(Usuario usuario, SqlCommand command)
        {
            command.Parameters.AddWithValue("@username", usuario.Username);
            command.Parameters.AddWithValue("@password", usuario.HashedPassword);
            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@apellido", usuario.Apellido);
            command.Parameters.AddWithValue("@tipoDocumentoId", usuario.TipoDocumento.Id);
            command.Parameters.AddWithValue("@numeroDocumento", usuario.NumeroDocumento);
            command.Parameters.AddWithValue("@mail", usuario.Mail);
            command.Parameters.AddWithValue("@telefono", usuario.Telefono);
            command.Parameters.AddWithValue("@direccion", usuario.Direccion.Calle);
            command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
            command.Parameters.AddWithValue("@rolId", usuario.Rol.Id);
            
        }

        private static void UpdateUsuarioParameters(Usuario usuario, SqlCommand command)
        {
            InsertUsuarioParameters(usuario, command);
            command.Parameters.AddWithValue("@id", usuario.Id);
        }

        private void AddUsuarioHotelesParameters(int idUsuario, Hotel hotel, SqlCommand command)
        {
            command.Parameters.AddWithValue("@usuarioId", idUsuario);
            command.Parameters.AddWithValue("@hotelId", hotel.Id);
        }

        private Hotel CreateHotel(DataRow row)
        {
            return new Hotel
            {
                Id = Convert.ToInt32(row["Id"]),
                Nombre = !string.IsNullOrEmpty(row["Nombre"].ToString()) ? row["Nombre"].ToString() : "Hotel" + row["Id"].ToString(),
                Direccion = row["Direccion"].ToString(),
                Ciudad = new Ciudad
                {
                    Id = Convert.ToInt32(row["CiudadId"]),
                    Nombre = row["CiudadNombre"].ToString(),
                    Pais = new Pais
                    {
                        Id = Convert.ToInt32(row["PaisId"]),
                        Nombre = row["PaisNombre"].ToString(),
                        Nacionalidad = row["PaisNacionalidad"].ToString()
                    }
                },
                Estrellas = Convert.ToInt32(row["Estrellas"]),
                FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]),
                RecargaEstrella = Convert.ToInt32(row["RecargaEstrella"]),
                Mail = row["Mail"].ToString()
            };
        }
    }
}
