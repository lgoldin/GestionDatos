using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using System.Data;
using FrbaHotel.Repositories;

namespace FrbaHotel.Services
{
    public class ListadoEstadisticoService : IListadoEstadisticoService
    {
        public DataTable Get(string spName, DateTime fechaDesde, DateTime fechaHasta)
        {
            return new ListadoEstadisticoRepository().Get(spName, fechaDesde, fechaHasta);
        }
    }
}
