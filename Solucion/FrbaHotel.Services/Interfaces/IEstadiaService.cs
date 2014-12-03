using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IEstadiaService
    {
        Estadia GetByCodigoReserva(int codigoReserva);

        void RegistrarConsumibles(IList<Consumible> consumibles, int idEstadia);

        int Save(Estadia estadia);
    }
}
