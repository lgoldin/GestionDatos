﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class FuncionalidadService : IFuncionalidadService
    {
        #region IFuncionalidadService Members

        public List<Funcionalidad> GetAll()
        {
            FuncionalidadRepository repository = new FuncionalidadRepository();
            List<Funcionalidad> list = new List<Funcionalidad>();
            list.Add(new Funcionalidad() { Id = 1, Nombre = "Funcionalidad 1" });
            list.Add(new Funcionalidad() { Id = 2, Nombre = "Funcionalidad 2" });
            list.Add(new Funcionalidad() { Id = 3, Nombre = "Funcionalidad 3" });
            list.Add(new Funcionalidad() { Id = 4, Nombre = "Funcionalidad 4" });

            //list = repository.GetAll();
            return list;
        }

        #endregion

       
    }
}