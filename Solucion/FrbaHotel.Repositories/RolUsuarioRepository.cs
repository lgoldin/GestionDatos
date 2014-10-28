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
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            SqlDataReader reader = DBConnection.EjecutarComandoSelect(_comando);
            List<RolUsuario> rolUsuarios = new List<RolUsuario>();
            while (reader.Read())
            {
                RolUsuario rolUsuario = new RolUsuario();
                rolUsuario.Nombre = reader["nombre"].ToString();
                rolUsuario.Id = Convert.ToInt32(reader["id"]);
                rolUsuario.Activo = Convert.ToBoolean(reader["activo"]);
                rolUsuarios.Add(rolUsuario);
            }

            return rolUsuarios;
        }

        public override RolUsuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(RolUsuario entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            AddRolUsuarioParameters(entity, _comando);
            int rolId = DBConnection.EjecutarComandoNonQuery(_comando);

            foreach (Funcionalidad f in entity.Funcionalidades)
            {
                SqlCommand _comandoRolFuncionalidad = DBConnection.CrearComandoStoredProcedure("InsertarRolFuncionalidad");
                AddRolFuncionalidadParameters(f.Id, rolId, _comandoRolFuncionalidad);
                int rfId = DBConnection.EjecutarComandoNonQuery(_comandoRolFuncionalidad);
            }

            return rolId;
        }

        public override void Update(RolUsuario entity)
        {
            SqlCommand _comando = DBConnection.CrearComandoStoredProcedure("NombreDelSP");
            AddRolUsuarioParameters(entity, _comando);
            DBConnection.EjecutarComandoNonQuery(_comando);

            foreach (Funcionalidad f in entity.Funcionalidades)
            {
                SqlCommand _comandoRolFuncionalidad = DBConnection.CrearComandoStoredProcedure("EliminarYInsertarRolFuncionalidad");
                AddRolFuncionalidadParameters(f.Id, entity.Id, _comandoRolFuncionalidad);
                int rfId = DBConnection.EjecutarComandoNonQuery(_comandoRolFuncionalidad);
            }
        }

        public override void Delete(RolUsuario entity)
        {
            throw new NotImplementedException();
        }

        private static void AddRolUsuarioParameters(RolUsuario rolUsuario, SqlCommand _comando)
        {
            _comando.Parameters.AddWithValue("@nombre", rolUsuario.Nombre);
            _comando.Parameters.AddWithValue("@activo", rolUsuario.Activo);
        }

        private static void AddRolFuncionalidadParameters(int funcionalidadId, int rolId, SqlCommand _comando)
        {
            _comando.Parameters.AddWithValue("@funcionalidadId", funcionalidadId);
            _comando.Parameters.AddWithValue("@activo", rolId);
        }
    }
}
