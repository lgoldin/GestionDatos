using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class CiudadService : ICiudadService
    {
        public IEnumerable<Ciudad> GetAll()
        {
            var ciudades = new List<Ciudad>();
            ciudades.Add(new Ciudad { Id = 0, Nombre = "- No Especificado -" });

            var repository = new CiudadRepository();
            repository.GetAll().ToList().ForEach(ciudades.Add);
            
            return ciudades;
        }
    }
}
