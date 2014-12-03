using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class EstadiaService : IEstadiaService
    {
        public Estadia GetByCodigoReserva(int codigoReserva)
        {
            var repository = new EstadiaRepository();
            return repository.GetByCodigoReserva(codigoReserva);
        }

        public void RegistrarConsumibles(IList<Consumible> consumibles, int idEstadia)
        {
            var repository = new EstadiaRepository();
            repository.RegistrarConsumibles(consumibles, idEstadia);
        }

        public Estadia GetById(int id)
        {
            var repository = new EstadiaRepository();
            return repository.Get(id);
        }

        public int Save(Estadia estadia)
        {
            var repository = new EstadiaRepository();

            if (estadia.IsNew)
            {
                return repository.Insert(estadia);
            }
            else
            {
                repository.Update(estadia);
                return estadia.Id;
            }
        }
    }
}
