using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities.DTOs;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IHabitacionService
    {
        IEnumerable<HabitacionDTO> GetAll(bool frente, int? numero, int? piso, string descripcion, int? hotelId, int? tipoHabitacion, bool activa);

        Habitacion Get(int idHabitacion);

        int Save(Habitacion habitacion);

        bool ExistsHabitacion(int hotelId, int numero, int piso);
    }
}
