using System;
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

            List<Funcionalidad> list = repository.GetAll().ToList();
            return list;
        }

        public List<Funcionalidad> GetByRolId(int rolId)
        {
            List<Funcionalidad> list = new List<Funcionalidad>();
            FuncionalidadRepository repository = new FuncionalidadRepository();
            return repository.GetByRol(rolId);
        }

        #endregion
    }
}
