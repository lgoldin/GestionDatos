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
    public class EstadiaRepository : BaseRepository<Estadia>
    {
        public override int Insert(Estadia entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Estadia entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Estadia entity)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Estadia> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Estadia Get(int id)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("GetEstadiaById");
            command.Parameters.AddWithValue("@id", id);

            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow row in collection)
            {
                return this.CreateEstadia(row);
            }

            return null;
        }

        public Estadia GetByCodigoReserva(int codigoReserva)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("GetEstadiaByCodigoReserva");
            command.Parameters.AddWithValue("@codigoReserva", codigoReserva);
            command.Parameters.AddWithValue("@hotelId", Session.Hotel.Id);

            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow row in collection)
            {
                return this.CreateEstadia(row);
            }

            return null;
        }

        public void RegistrarConsumibles(IList<Consumible> consumibles, int idEstadia)
        {
            using(var scope = new TransactionScope())
            {
                foreach (Consumible consumible in consumibles)
                {
                    SqlCommand command = DBConnection.CreateStoredProcedure("InsertEstadiaConsumible");
                    command.Parameters.AddWithValue("@consumibleCodigo", consumible.Codigo);
                    command.Parameters.AddWithValue("@idEstadia", idEstadia);

                    DBConnection.ExecuteNonQuery(command);
                }

                scope.Complete();
            }
        }

        private Estadia CreateEstadia(DataRow row)
        {
            return new Estadia
            {
                CodigoReserva = Convert.ToInt32(row["reservaCodigo"]),
                FechaDesde = Convert.ToDateTime(row["fechaDesde"]),
                FechaHasta = Convert.ToDateTime(row["fechaHasta"]),
                Id = Convert.ToInt32(row["id"])
            };
        }
    }
}
