using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;

namespace FrbaHotel.Repositories
{
    public class RolUsuarioRepository : BaseRepository<RolUsuario>
    {
        public override IEnumerable<RolUsuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public override RolUsuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(RolUsuario entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            AddRolUsuarioParameters(entity, _comando);
            return DBConnection.EjecutarComandoNonQuery(_comando);
        }

        public override void Update(RolUsuario entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(RolUsuario entity)
        {
            throw new NotImplementedException();
        }

        private static void AddRolUsuarioParameters(RolUsuario rolUsuario, SqlCommand _comando)
        {
            
        }
    }
}
