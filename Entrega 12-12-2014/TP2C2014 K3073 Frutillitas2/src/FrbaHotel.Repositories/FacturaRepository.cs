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
    public class FacturaRepository : BaseRepository<Factura>
    {

        public override IEnumerable<Factura> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Factura Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Factura entity)
        {
            throw new NotImplementedException();
        }

        public long Insert(Factura factura, TarjetaDeCredito tarjeta)
        {
            using (var transaction = new TransactionScope())
            {
                SqlCommand command = DBConnection.CreateStoredProcedure("InsertFactura");
                AddFacturaParameters(factura, command);
                long numeroFactura = (long)DBConnection.ExecuteScalar(command);

                InsertItemsFactura(factura.Items, numeroFactura);

                if (tarjeta != null)
                {
                    InsertTarjeta(tarjeta, numeroFactura);
                }

                transaction.Complete();

                return numeroFactura;
            }
        }

        private void InsertTarjeta(TarjetaDeCredito tarjeta, long numeroFactura)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("InsertTarjetaDeCredito");
            AddTarjetaDeCreditoParameters(numeroFactura, tarjeta, command);
            DBConnection.ExecuteNonQuery(command);
        }

        private void AddTarjetaDeCreditoParameters(long numeroFactura, TarjetaDeCredito tarjeta, SqlCommand command)
        {
            command.Parameters.AddWithValue("@facturaNumero", numeroFactura);
            command.Parameters.AddWithValue("@codigo", tarjeta.Codigo);
            command.Parameters.AddWithValue("@codigoSeguridad", tarjeta.CodigoSeguridad);
            command.Parameters.AddWithValue("@fechaVencimiento", tarjeta.FechaVencimiento);
            command.Parameters.AddWithValue("@numero", tarjeta.Numero);
        }

        private void InsertItemsFactura(List<FacturaItem> list, long numeroFactura)
        {
            foreach (FacturaItem fi in list)
            {
                SqlCommand command = DBConnection.CreateStoredProcedure("InsertFacturaItem");
                AddFacturaItemsdParameters(numeroFactura, fi, command);
                DBConnection.ExecuteNonQuery(command);
            }
        }

        private void AddFacturaItemsdParameters(long numeroFactura, FacturaItem facturaItem, SqlCommand command)
        {
            command.Parameters.AddWithValue("@facturaNumero", numeroFactura);
            command.Parameters.AddWithValue("@precio", facturaItem.Precio);
            command.Parameters.AddWithValue("@descripcion", facturaItem.Descripcion);
        }

        private void AddFacturaParameters(Factura factura, SqlCommand command)
        {
            command.Parameters.AddWithValue("@estadiaId", factura.EstadiaId);
            command.Parameters.AddWithValue("@fecha", factura.Fecha);
            command.Parameters.AddWithValue("@tipoPagoId", factura.TipoPagoId);
            command.Parameters.AddWithValue("@total", factura.Total);
            command.Parameters.AddWithValue("@clienteId", factura.ClienteId);
        }

        public override void Update(Factura entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Factura entity)
        {
            throw new NotImplementedException();
        }
    }
}
        