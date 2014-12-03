using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class FacturaService : IFacturaService
    {
        public long Insert(Factura factura, TarjetaDeCredito tarjeta)
        {
            FacturaRepository facturaRepository = new FacturaRepository();
            return facturaRepository.Insert(factura, tarjeta);
        }
    }
}
