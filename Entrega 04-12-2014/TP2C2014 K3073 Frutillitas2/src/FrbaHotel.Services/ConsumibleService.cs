using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class ConsumibleService : IConsumibleService
    {
        public IEnumerable<Consumible> GetByIdEstadia(int idEstadia)
        {
            var repository = new ConsumibleRepository();
            return repository.GetByIdEstadia(idEstadia);
        }

        public IEnumerable<Consumible> GetAll()
        {
            var consumibles = new List<Consumible>();
            consumibles.Add(new Consumible { Codigo = 0, Descripcion = "- No Especificado -" });

            var repository = new ConsumibleRepository();
            repository.GetAll().ToList().ForEach(consumibles.Add);

            return consumibles;
        }
    }
}
