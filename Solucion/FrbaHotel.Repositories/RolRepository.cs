using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class RolRepository : BaseRepository<Rol>
    {
        public override IEnumerable<Rol> GetAll()
        {
            var roles = new List<Rol>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetRoles");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow rol in collection)
            {
                roles.Add(this.CreateRol(rol));
            }
            
            return roles;
        }

        public override Rol Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Rol entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Rol entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Rol entity)
        {
            throw new NotImplementedException();
        }

        private Rol CreateRol(SqlDataReader reader)
        {
            return new Rol
                {
                    Activo = Convert.ToBoolean(reader["Activo"]),
                    Nombre = reader["Nombre"].ToString(),
                    Id = Convert.ToInt32(reader["Id"])
                };
        }

        private Rol CreateRol(DataRow row)
        {
            return new Rol
            {
                Activo = Convert.ToBoolean(row["Activo"]),
                Nombre = row["Nombre"].ToString(),
                Id = Convert.ToInt32(row["Id"])
            };
        }

    }
}
