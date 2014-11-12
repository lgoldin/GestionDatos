using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class RolService : IRolService
    {
        public IEnumerable<Rol> GetAll()
        {
            var roles = new List<Rol>();
            roles.Add(new Rol { Id = 0, Nombre = "- No Especificado -" });

            var repository = new RolRepository();
            repository.GetAll().ToList().ForEach(roles.Add);
            
            return roles;
        }

        public int Insert(Rol rolUsuario)
        {
            var repository = new RolRepository();
            return repository.Insert(rolUsuario);
        }

        public void Update(Rol rolUsuario)
        {
            var repository = new RolRepository();
            repository.Update(rolUsuario);
        }

        public void Delete(Rol rol)
        {
            var repository = new RolRepository();
            repository.Delete(rol);
        }
    }
}
