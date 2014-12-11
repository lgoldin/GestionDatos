using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class ListadoEstadisticoRepository
    {
        public DataTable Get(string spName, DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure(spName);
            command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
            return DBConnection.EjecutarStoredProcedureSelect(command);
        }
    }
}
