using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class HotelRepository : BaseRepository<Hotel>
    {
        public override IEnumerable<Hotel> GetAll()
        {
            var hoteles = new List<Hotel>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetHoteles");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow hotel in collection)
            {
                hoteles.Add(this.CreateHotel(hotel));
            }
            
            return hoteles;
        }

        public override Hotel Get(int id)
        {
            return this.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public override int Insert(Hotel entity)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("NombreDelSP");
            AddHotelParameters(entity, command);
            return DBConnection.ExecuteNonQuery(command);
        }

        public override void Update(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Hotel entity)
        {
            throw new NotImplementedException();
        }

        private Hotel CreateHotel(DataRow row)
        {
            return new Hotel
            {
                Id = Convert.ToInt32(row["Id"]),
                Nombre = !string.IsNullOrEmpty(row["Nombre"].ToString()) ? row["Nombre"].ToString() : "Hotel" + row["Id"].ToString(),
                Direccion = row["Direccion"].ToString(),
                Ciudad = new Ciudad 
                            { 
                                Id = Convert.ToInt32(row["CiudadId"]), 
                                Nombre = row["CiudadNombre"].ToString(), 
                                Pais = new Pais 
                                            { 
                                                Id = Convert.ToInt32(row["PaisId"]),
                                                Nombre = row["PaisNombre"].ToString(),
                                                Nacionalidad = row["PaisNacionalidad"].ToString()
                                            }
                            },
                Estrellas = Convert.ToInt32(row["Estrellas"]),
                FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]),
                RecargaEstrella = Convert.ToInt32(row["RecargaEstrella"]),
                Mail = row["Mail"].ToString()
            };
        }

        private void AddHotelParameters(Hotel hotel, SqlCommand command)
        {
        }
    }
}
