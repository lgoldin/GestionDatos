using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;
using FrbaHotel.Entities.DTOs;

namespace FrbaHotel.Services
{
    public class ReservaService : IReservaService
    {

        #region IReservaService Members

        public List<Regimen> GetActiveReservaRegimenesByHotelId(int hotelId)
        {
            ReservaRepository repository = new ReservaRepository();
            List<Regimen> regimenes = repository.GetActiveReservaRegimenesByHotelId(hotelId);
            return regimenes;
        }

        #endregion
    }
}
