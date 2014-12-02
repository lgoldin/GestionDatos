using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IHotelService
    {
        IEnumerable<Hotel> GetAll(string nombre, int? esttrellas, int? paisId, int? ciudadId);
        Hotel GetById(int id);
        int InsertHotelInhabilitado(HotelInhabilitacion hotelInhabilitado);
        int Insert(Hotel hotel, int usuarioId);
    }
}
