using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.Services.Interfaces
{
    public interface IListadoEstadisticoService
    {
        DataTable Get(string spName, DateTime fechaDesde, DateTime fechaHasta);
    }
}
