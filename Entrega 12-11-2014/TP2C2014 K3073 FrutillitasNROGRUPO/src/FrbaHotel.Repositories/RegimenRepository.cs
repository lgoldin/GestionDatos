using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class RegimenRepository : BaseRepository<Regimen>
    {
        public override IEnumerable<Regimen> GetAll()
        {
            var regimenes = new List<Regimen>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetRegimenes");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow regimen in collection)
            {
                regimenes.Add(this.CreateRegimen(regimen));
            }
            
            return regimenes;
        }

        public override Regimen Get(int id)
        {
            return this.GetAll().FirstOrDefault(x => x.Codigo == id);
        }

        public override int Insert(Regimen entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Regimen entity)
        {
            throw new NotImplementedException();
        }

        

        private Regimen CreateRegimen(DataRow row)
        {
            return new Regimen
            {
                Activo = Convert.ToBoolean(row["activo"]),
                Descripcion = row["descripcion"].ToString(),
                Codigo = Convert.ToInt32(row["codigo"]),
                Precio = Convert.ToDecimal(row["precio"])
            };
        }

        public override void Delete(Regimen entity)
        {
            throw new NotImplementedException();
        }
    }
}
