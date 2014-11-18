using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Entities.DTOs;
using FrbaHotel.Entities;
using FrbaHotel.Repositories;

namespace FrbaHotel.Services
{
    public class HabitacionService : IHabitacionService
    {
        public IEnumerable<HabitacionDTO> GetAll(bool frente, int? numero, int? piso, string descripcion, int? hotelId, int? tipoHabitacion)
        {
            var habitacionesDTO = new List<HabitacionDTO>();

            var repository = new HabitacionRepository();
            IEnumerable<Habitacion> habitaciones = repository.GetAll(frente, numero, piso, descripcion, hotelId, tipoHabitacion);

            foreach (Habitacion habitacion in habitaciones)
            {
                habitacionesDTO.Add(new HabitacionDTO 
                                        {
                                            Activa = habitacion.Activa,
                                            Codigo = habitacion.Id,
                                            Descripcion = habitacion.Descripcion,
                                            Frente = habitacion.Frente,
                                            Hotel = habitacion.Hotel.Nombre,
                                            Modificar = "Modificar",
                                            Numero = habitacion.Numero,
                                            Piso = habitacion.Piso,
                                            TipoHabitacion = habitacion.TipoHabitacion.Descripcion
                                        });
            }

            return habitacionesDTO;
        }
    }
}
