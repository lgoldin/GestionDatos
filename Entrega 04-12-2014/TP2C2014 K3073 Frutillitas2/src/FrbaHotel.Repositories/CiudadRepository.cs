using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class CiudadRepository : BaseRepository<Ciudad>
    {
        public override int Insert(Ciudad entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Ciudad entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Ciudad entity)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Ciudad> GetAll()
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            SqlCommand command = DBConnection.CreateStoredProcedure("GetCiudades");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow ciudad in collection)
            {
                ciudades.Add(this.CreateCiudad(ciudad));
            }

            return ciudades;
        }

        public override Ciudad Get(int id)
        {
            throw new NotImplementedException();
        }

        private Ciudad CreateCiudad(DataRow row)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.Nombre = row["nombre"].ToString();
            ciudad.Id = Convert.ToInt32(row["id"]);
            ciudad.Pais = new Pais();
            ciudad.Pais.Id = Convert.ToInt32(row["paisId"]);
            return ciudad;
        }
    }
}
