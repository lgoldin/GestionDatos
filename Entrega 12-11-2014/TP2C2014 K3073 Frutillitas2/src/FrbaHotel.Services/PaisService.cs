using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class PaisService : IPaisService
    {
        public IEnumerable<Pais> GetAll()
        {
            var paises = new List<Pais>();
            paises.Add(new Pais { Id = 0, Nombre = "- No Especificado -" });

            var repository = new PaisRepository();
            repository.GetAll().ToList().ForEach(paises.Add);
            
            return paises;
        }

        public int Insert(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public List<Ciudad> GetCiudades(Pais pais)
        {
            var ciudades = new List<Ciudad>();
            ciudades.Add(new Ciudad { Id = 0, Nombre = "- No Especificado -" });

            var repository = new PaisRepository();
            repository.GetCiudades(pais).ToList().ForEach(ciudades.Add);

            return ciudades;
        }
    }
}
