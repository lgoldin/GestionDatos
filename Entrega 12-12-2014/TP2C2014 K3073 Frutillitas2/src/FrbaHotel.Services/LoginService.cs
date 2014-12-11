using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;
using System.Security.Cryptography;

namespace FrbaHotel.Services
{
    public class LoginService : ILoginService
    {
        public Usuario Login(string username, string password)
        {
            var usuariosRepository = new UsuarioRepository();
            return usuariosRepository.GetByUsernameAndPassword(username, this.HashPassword(password));
        }

        private byte[] HashPassword(string password)
        {
            return SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
