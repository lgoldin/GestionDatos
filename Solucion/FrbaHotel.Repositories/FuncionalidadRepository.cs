using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;

namespace FrbaHotel.Repositories
{
    public class FuncionalidadRepository : BaseRepository<Funcionalidad>
    {
        public override IEnumerable<Funcionalidad> GetAll()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            SqlCommand comando = DBConnection.CreateCommand();
            comando.CommandText = "SELECT * FROM Funcionalidad";
            SqlDataReader reader = DBConnection.EjecutarComandoSelect(comando);

            while (reader.Read())
            {
                Funcionalidad funcionalidad = CreateFuncionalidad(reader);
                funcionalidades.Add(funcionalidad);
            }

            return funcionalidades;
        }

        public override int Insert(Funcionalidad entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Funcionalidad entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Funcionalidad entity)
        {
            throw new NotImplementedException();
        }

        public override Funcionalidad Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Funcionalidad> GetByRol(int rolId)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            SqlCommand _comando = DBConnection.CreateStoredProcedure("NombreDelSP");
            _comando.Parameters.AddWithValue("@rolId", rolId);
            SqlDataReader reader = DBConnection.EjecutarComandoSelect(_comando);

            while (reader.Read())
            {
                Funcionalidad funcionalidad = CreateFuncionalidad(reader);
                funcionalidades.Add(funcionalidad);
            }

            return funcionalidades;
        }

        public Funcionalidad CreateFuncionalidad(SqlDataReader reader)
        {
            Funcionalidad funcionalidad = new Funcionalidad();
            funcionalidad.Nombre = reader["nombre"].ToString();
            funcionalidad.Id = Convert.ToInt32(reader["id"]);
            return funcionalidad;
        }
    }
}
