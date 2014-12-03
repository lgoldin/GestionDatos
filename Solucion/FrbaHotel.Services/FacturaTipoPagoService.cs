using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class FacturaTipoPagoService : IFacturaTipoPagoService
    {
        public IEnumerable<FacturaTipoPago> GetAll()
        {
            var tiposDePago = new List<FacturaTipoPago>();
            tiposDePago.Add(new FacturaTipoPago { Id = 0, Descripcion = "- No Especificado -" });

            var repository = new FacturaTipoPagoRepository();
            repository.GetAll().ToList().ForEach(tiposDePago.Add);
            
            return tiposDePago;
        }
    }
}
