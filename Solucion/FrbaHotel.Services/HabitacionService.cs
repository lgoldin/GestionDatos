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
        public IEnumerable<HabitacionDTO> GetAll(bool frente, int? numero, int? piso, string descripcion, int? hotelId, int? tipoHabitacion, bool activa)
        {
            var habitacionesDTO = new List<HabitacionDTO>();

            var repository = new HabitacionRepository();
            IEnumerable<Habitacion> habitaciones = repository.GetAll(frente, numero, piso, descripcion, hotelId, tipoHabitacion, activa);

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

        public Habitacion Get(int idHabitacion)
        {
            var repository = new HabitacionRepository();
            return repository.Get(idHabitacion);
        }

        public int Save(Habitacion habitacion)
        {
            int id = habitacion.Id;

            var repository = new HabitacionRepository();

            if (habitacion.IsNew())
            {
                id = repository.Insert(habitacion);
            }
            else
            {
                repository.Update(habitacion);
            }

            return id;
        }
    }
}
