using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class TipoHabitacionRepository : BaseRepository<TipoHabitacion>
    {
        public override IEnumerable<TipoHabitacion> GetAll()
        {
            var tipos = new List<TipoHabitacion>();
            SqlCommand command = DBConnection.CreateStoredProcedure("GetTiposHabitaciones");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow tipo in collection)
            {
                tipos.Add(this.CreateTipoHabitacion(tipo));
            }

            return tipos;
        }

        public override TipoHabitacion Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(TipoHabitacion entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(TipoHabitacion entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(TipoHabitacion entity)
        {
            throw new NotImplementedException();
        }

        private TipoHabitacion CreateTipoHabitacion(DataRow tipo)
        {
            return new TipoHabitacion
            {
                Codigo = Convert.ToInt32(tipo["codigo"]),
                Descripcion = tipo["descripcion"].ToString(),
                Porcentual = Convert.ToDecimal(tipo["porcentual"])
            };
        }
    }
}
