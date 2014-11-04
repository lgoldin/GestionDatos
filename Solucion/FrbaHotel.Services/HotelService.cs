using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class HotelService : IHotelService
    {
        public IEnumerable<Hotel> GetAll()
        {
            var hoteles = new List<Hotel>();
            hoteles.Add(new Hotel { Id = 0, Nombre = "- No Especificado -" });

            var repository = new HotelRepository();
            repository.GetAll().ToList().ForEach(hoteles.Add);
            
            return hoteles;
        }

        public int Insert(Hotel hotel)
        {
            HotelRepository repository = new HotelRepository();
            return repository.Insert(hotel);
        }
    }
}
