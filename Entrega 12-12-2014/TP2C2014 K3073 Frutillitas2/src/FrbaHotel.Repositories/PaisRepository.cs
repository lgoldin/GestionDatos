using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class PaisRepository : BaseRepository<Pais>
    {
        public override IEnumerable<Pais> GetAll()
        {
            List<Pais> paises = new List<Pais>();
            SqlCommand command = DBConnection.CreateStoredProcedure("GetPaises");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow pais in collection)
            {
                paises.Add(this.CreatePais(pais));
            }
           
            return paises;
        }

        public override int Insert(Pais entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Pais entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Pais entity)
        {
            throw new NotImplementedException();
        }

        public override Pais Get(int id)
        {
            throw new NotImplementedException();
        }

        private Pais CreatePais(DataRow row)
        {
            Pais pais = new Pais();
            pais.Nombre = row["nombre"].ToString();
            pais.Id = Convert.ToInt32(row["id"]);
            pais.Nacionalidad = row["nacionalidad"].ToString();
            return pais;
        }

        public List<Ciudad> GetCiudades(Pais pais)
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            SqlCommand command = DBConnection.CreateStoredProcedure("GetCiudadesByPaisId");
            command.Parameters.AddWithValue("@paisId", pais.Id);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow ciudad in collection)
            {
                ciudades.Add(this.CreateCiudad(ciudad));
            }

            return ciudades;
        }

        private Ciudad CreateCiudad(DataRow row)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.Nombre = row["nombre"].ToString();
            ciudad.Id = Convert.ToInt32(row["id"]);      
            return ciudad;
        }
    }
}
