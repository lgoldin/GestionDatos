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
            
            var repository = new RolRepository();
            roles = repository.GetAll().ToList();
            roles.Add(new Rol { Id = -1, Nombre = "- No Especificado -" });
            
            roles.OrderBy(x => x.Id);
            
            return roles;
        }
    }
}
