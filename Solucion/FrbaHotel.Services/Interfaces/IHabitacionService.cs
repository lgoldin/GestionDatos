using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities.DTOs;

namespace FrbaHotel.Services.Interfaces
{
    public interface IHabitacionService
    {
        IEnumerable<HabitacionDTO> GetAll(bool frente, string numero, string piso, string descripcion, int? hotelId, int? tipoHabitacion);
    }
}
