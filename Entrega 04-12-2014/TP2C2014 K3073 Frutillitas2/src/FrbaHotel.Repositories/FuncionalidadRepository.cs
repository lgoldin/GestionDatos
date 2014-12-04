using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class FuncionalidadRepository : BaseRepository<Funcionalidad>
    {
        public override IEnumerable<Funcionalidad> GetAll()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            SqlCommand command = DBConnection.CreateStoredProcedure("GetFuncionalidades");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow funcionalidad in collection)
            {
                funcionalidades.Add(this.CreateFuncionalidad(funcionalidad));
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

            SqlCommand command = DBConnection.CreateStoredProcedure("GetFuncionalidadesByRol");
            command.Parameters.AddWithValue("@rolId", rolId);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow funcionalidad in collection)
            {
                funcionalidades.Add(this.CreateFuncionalidadOnlyId(funcionalidad));
            }
            
            return funcionalidades;
        }

        public Funcionalidad CreateFuncionalidad(DataRow row)
        {
            Funcionalidad funcionalidad = new Funcionalidad();
            funcionalidad.Nombre = row["nombre"].ToString();
            funcionalidad.Id = Convert.ToInt32(row["id"]);
            return funcionalidad;
        }

        public Funcionalidad CreateFuncionalidadOnlyId(DataRow row)
        {
            Funcionalidad funcionalidad = new Funcionalidad();
            funcionalidad.Id = Convert.ToInt32(row["funcionalidadId"]);
            funcionalidad.Nombre = row["nombre"].ToString();
            return funcionalidad;
        }
    }
}
