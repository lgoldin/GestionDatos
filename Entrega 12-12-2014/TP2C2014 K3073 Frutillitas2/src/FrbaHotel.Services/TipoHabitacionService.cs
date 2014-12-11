using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Entities;
using FrbaHotel.Entities.DTOs;
using FrbaHotel.Repositories;
using System.Security.Cryptography;

namespace FrbaHotel.Services
{
    public class TipoHabitacionService : ITipoHabitacionService
    {
        public IEnumerable<TipoHabitacion> GetAll()
        {
            var tipos = new List<TipoHabitacion>();
            tipos.Add(new TipoHabitacion { Codigo = 0, Descripcion = "- No Especificado -" });

            var repository = new TipoHabitacionRepository();
            repository.GetAll().ToList().ForEach(tipos.Add);

            return tipos;
        }

        public TipoHabitacion GetByCodigo(int codigo)
        {
            TipoHabitacion res = null;
            foreach (TipoHabitacion tipo in GetAll())
            {
                if (tipo.Codigo == codigo)
                    res = tipo;
            }
            
            return res;
        }
    }
}
