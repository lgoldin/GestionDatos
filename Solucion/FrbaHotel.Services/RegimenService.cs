﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class RegimenService : IRegimenService
    {
        public IEnumerable<Regimen> GetAll()
        {
            var regimenes = new List<Regimen>();
           

            var repository = new RegimenRepository();
            repository.GetAll().ToList().ForEach(regimenes.Add);
            
            return regimenes;
        }

        public List<Regimen> GetByHotelId(int hotelId)
        {
            var regimenes = new List<Regimen>();
            var repository = new RegimenRepository();
            repository.GetByHotelId(hotelId).ToList().ForEach(regimenes.Add);
            return regimenes;
        }

        public Regimen GetByCodigo(int codigo)
        {
            return this.GetAll().FirstOrDefault(x => x.Codigo == codigo);
        }
    }
}
