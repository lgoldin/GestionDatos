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
    public class FacturaTipoPagoRepository : BaseRepository<FacturaTipoPago>
    {
        public override IEnumerable<FacturaTipoPago> GetAll()
        {
            var tiposDePago = new List<FacturaTipoPago>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetFacturaTipoPago");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow tipoPago in collection)
            {
                tiposDePago.Add(this.CreateFacturaTipoPago(tipoPago));
            }
            
            return tiposDePago;
        }

        private FacturaTipoPago CreateFacturaTipoPago(DataRow row)
        {
            return new FacturaTipoPago
            {
                Descripcion = row["descripcion"].ToString(),
                Id = Convert.ToInt32(row["id"])
            };
        }

        public override FacturaTipoPago Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(FacturaTipoPago entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(FacturaTipoPago entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(FacturaTipoPago entity)
        {
            throw new NotImplementedException();
        }
    }
}
