using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class LoginService : ILoginService
    {
        public Usuario Login(string username, string password)
        {
            var usuariosRepository = new UsuarioRepository();
            return usuariosRepository.GetByUsernameAndPassword(username, password);
        }
    }
}
