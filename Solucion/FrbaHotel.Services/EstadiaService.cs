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
    }
}
