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
            SqlCommand command = DBConnection.CreateStoredProcedure("InsertHotel");
            AddHotelParameters(entity, command);
            command.Connection.Open();
            command.ExecuteNonQuery();
            int hotelId = (int)command.Parameters["@id"].Value;

            InsertHotelRegimen(entity, hotelId);

            return hotelId;
        }

        public override void Update(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Hotel entity)
        {
            throw new NotImplementedException();
        }

        private void AddHotelParameters(Hotel hotel, SqlCommand command)
        {
            command.Parameters.AddWithValue("@ciudadId", hotel.Ciudad.Id);
            command.Parameters.AddWithValue("@direccion", hotel.Direccion);
            command.Parameters.AddWithValue("@estrellas", hotel.Estrellas);
            command.Parameters.AddWithValue("@fechaCreacion", hotel.FechaCreacion);
            command.Parameters.AddWithValue("@nombre", hotel.Nombre);
            command.Parameters.AddWithValue("@recargaEstrella", hotel.RecargaEstrella);
            command.Parameters.AddWithValue("@mail", hotel.Mail);
            command.Parameters.Add("@id",SqlDbType.Int).Direction = ParameterDirection.Output;
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

        private void InsertHotelRegimen(Hotel entity, int hotelId)
        {
            foreach (Regimen r in entity.Regimenes)
            {
                SqlCommand commandHotelRegimen = DBConnection.CreateStoredProcedure("InsertHotelRegimen");
                commandHotelRegimen.Parameters.AddWithValue("@hotelId", hotelId);
                commandHotelRegimen.Parameters.AddWithValue("@regimenCodigo", r.Codigo);
                DBConnection.ExecuteNonQuery(commandHotelRegimen);
            }
        }
    }
}
