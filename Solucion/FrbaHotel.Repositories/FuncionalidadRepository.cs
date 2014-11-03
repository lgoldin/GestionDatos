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

            SqlCommand command = DBConnection.CreateStoredProcedure("NombreDelSP");
            command.Parameters.AddWithValue("@rolId", rolId);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow funcionalidad in collection)
            {
                funcionalidades.Add(this.CreateFuncionalidad(funcionalidad));
            }
            
            return funcionalidades;
        }

        public Funcionalidad CreateFuncionalidad(DataRow reader)
        {
            Funcionalidad funcionalidad = new Funcionalidad();
            funcionalidad.Nombre = reader["nombre"].ToString();
            funcionalidad.Id = Convert.ToInt32(reader["id"]);
            return funcionalidad;
        }
    }
}
