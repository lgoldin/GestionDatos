using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IRolUsuarioService
    {
        List<RolUsuario> GetAll();

        int Insert(RolUsuario rolUsuario);

        void Update(RolUsuario rolUsuario);
    }
}
