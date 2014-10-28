using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class RolUsuarioService : IRolUsuarioService
    {

        #region IRolUsuarioService Members

        public List<RolUsuario> GetAll()
        {
            RolUsuarioRepository rolUsuarioRepository = new RolUsuarioRepository();
            //List<RolUsuario> roles = rolUsuarioRepository.GetAll().ToList();
            List<RolUsuario> roles = new List<RolUsuario>();
            roles.Add(new RolUsuario() { Activo = true, Nombre = "Rol 1", Id = 1 });
            roles.Add(new RolUsuario() { Activo = true, Nombre = "Rol 2", Id = 2 });
            roles.Add(new RolUsuario() { Activo = false, Nombre = "Rol 3", Id = 3 });
            return roles;
        }

        public int Insert(RolUsuario rolUsuario)
        {
            RolUsuarioRepository rolUsuarioRepository = new RolUsuarioRepository();
            int id = rolUsuarioRepository.Insert(rolUsuario);
            return id;
        }

        public void Update(RolUsuario rolUsuario)
        {
            RolUsuarioRepository rolUsuarioRepository = new RolUsuarioRepository();
            rolUsuarioRepository.Update(rolUsuario);
        }

        #endregion
    }
}
