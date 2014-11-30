using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace FrbaHotel.Repositories
{
    public class ReservaRepository : BaseRepository<Reserva>
    {
        public override IEnumerable<Reserva> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Reserva Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Reserva entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Reserva entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Reserva entity)
        {
            throw new NotImplementedException();
        }

        public List<Regimen> GetActiveReservaRegimenesByHotelId(int hotelId)
        {
            List<Regimen> regimenes = new List<Regimen>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetActiveReservaRegimenesByHotelId");
            command.Parameters.AddWithValue("@hotelId", hotelId);
            command.Parameters.AddWithValue("@fecha", DateTime.Now);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow regimen in collection)
            {
                regimenes.Add(this.CreateRegimen(regimen));
            }

            return regimenes;
        }

        private Regimen CreateRegimen(DataRow row)
        {
            Regimen regimen = new Regimen();
            regimen.Descripcion = row["descripcion"].ToString();
            regimen.Codigo = Convert.ToInt32(row["codigo"]);
            return regimen;
        }
    }
}
