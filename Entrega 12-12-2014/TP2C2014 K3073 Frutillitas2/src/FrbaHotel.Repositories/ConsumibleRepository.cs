using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class ConsumibleRepository
    {
        public IEnumerable<Consumible> GetAll()
        {
            var consumibles = new List<Consumible>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetConsumibles");

            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow row in collection)
            {
                consumibles.Add(this.CreateConsumible(row));
            }

            return consumibles;
        }

        public IEnumerable<Consumible> GetByIdEstadia(int idEstadia)
        {
            var consumibles = new List<Consumible>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetConsumiblesByIdEstadia");
            command.Parameters.AddWithValue("@idEstadia", idEstadia);

            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow row in collection)
            {
                consumibles.Add(this.CreateConsumible(row));
            }

            return consumibles;
        }

        private Consumible CreateConsumible(DataRow row)
        {
            return new Consumible
            {
                Codigo = Convert.ToInt32(row["codigo"]),
                Descripcion = row["descripcion"].ToString(),
                Precio = Convert.ToDecimal(row["precio"])
            };
        }
    }
}
