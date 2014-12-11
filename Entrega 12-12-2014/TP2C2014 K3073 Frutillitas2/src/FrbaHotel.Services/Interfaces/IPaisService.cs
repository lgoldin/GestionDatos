using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IPaisService
    {
        IEnumerable<Pais> GetAll();

        List<Ciudad> GetCiudades(Pais pais);
    }
}
