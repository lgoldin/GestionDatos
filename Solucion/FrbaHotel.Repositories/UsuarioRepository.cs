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
            throw new NotImplementedException();
        }

        public override Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Usuario entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@userName", entity.Username);
            _comando.Parameters.AddWithValue("@passWord", entity.Password);
            return DBConnection.EjecutarComandoNonQuery(_comando);
        }

        public override void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Usuario GetByUsernameAndPassword(string username, string password)
        {
            if (username != "denuzai")
            {
                return null;
            }

            return new Usuario
                        {
                            Id = 431,
                            Username = username,
                            Password = password
                        };
        }
    }
}
