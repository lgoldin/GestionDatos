using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;

namespace FrbaHotel.Services
{
    public class HotelCargoPorEstrellaService : IHotelCargoPorEstrellaService
    {
        public double GetCargo()
        {
            HotelCargoPorEstrellaRepository repository = new HotelCargoPorEstrellaRepository();
            return repository.GetCargo();
        }
    }
}
