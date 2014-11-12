using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IRolService
    {
        IEnumerable<Rol> GetAll();

        int Insert(Rol rolUsuario);

        void Update(Rol rolUsuario);
    }
}
