using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class HotelCargoPorEstrellaRepository
    {
        public double GetCargo()
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("GetHotelCargoEstrella");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            DataRow reader = collection[0];

            return Convert.ToDouble(reader[0]);
        }
    }
}
