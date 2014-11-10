using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IUsuarioService
    {
        Usuario Get(int idUsuario);

        int Save(Usuario usuario);
    }
}
