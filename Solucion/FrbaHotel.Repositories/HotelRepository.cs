using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace FrbaHotel.Repositories
{
    public class HotelRepository : BaseRepository<Hotel>
    {
        public override IEnumerable<Hotel> GetAll()
        {
            return this.GetAll(null, null, null, null);
        }

        public IEnumerable<Hotel> GetAll(string nombre, int? estrellas, int? paisId, int? ciudadId )
        {
            var hoteles = new List<Hotel>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetHoteles");
            AddGetHotelParameters(nombre,estrellas, paisId, ciudadId, command);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow hotel in collection)
            {
                hoteles.Add(this.CreateHotel(hotel));
            }
            
            return hoteles;
        }

        private void AddGetHotelParameters(string nombre, int? estrellas, int? paisId, int? ciudadId, SqlCommand command)
        {
            command.Parameters.AddWithValue("@ciudadId", ciudadId);
            command.Parameters.AddWithValue("@estrellas", estrellas);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@paisId", paisId);
        }

        
        public override Hotel Get(int id)
        {
            return this.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public override int Insert(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public int Insert(Hotel entity, int usuarioId)
        {
            using (var transaction = new TransactionScope())
            {
                SqlCommand command = DBConnection.CreateStoredProcedure("InsertHotel");
                AddHotelParameters(entity, command);
                int hotelId = DBConnection.ExecuteScalar(command);

                InsertHotelRegimen(entity, hotelId);
                InsertHotelUsuario(hotelId, usuarioId);

                transaction.Complete();

                return hotelId;
            }
        }

        private void InsertHotelUsuario(int hotelId, int usuarioId)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("InsertHotelUsuario");
            command.Parameters.AddWithValue("@hotelId", hotelId);
            command.Parameters.AddWithValue("@usuarioId", usuarioId);
            DBConnection.ExecuteNonQuery(command);
        }

        public int InsertHotelInhabilitado(HotelInhabilitacion hotelInhabilitado)
        {
                SqlCommand command = DBConnection.CreateStoredProcedure("InsertHotelInhabilitado");
                AddHotelInhabilitadoParameters(hotelInhabilitado, command);
                return DBConnection.ExecuteNonQuery(command);
        }

        public override void Update(Hotel entity)
        {
            using (var transaction = new TransactionScope())
            {
                SqlCommand command = DBConnection.CreateStoredProcedure("UpdateHotel");
                AddHotelParameters(entity, command);
                command.Parameters.AddWithValue("@id", entity.Id);
                DBConnection.ExecuteNonQuery(command);

                InsertHotelRegimen(entity, entity.Id);

                transaction.Complete();
            }
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
            if(hotel.FechaCreacion.Year > 1900)
            command.Parameters.AddWithValue("@fechaCreacion", hotel.FechaCreacion);
            command.Parameters.AddWithValue("@nombre", hotel.Nombre);
            command.Parameters.AddWithValue("@mail", hotel.Mail);
            command.Parameters.AddWithValue("@telefono", hotel.Telefono);
        }

        private void AddHotelInhabilitadoParameters(HotelInhabilitacion hotelInhabilitado, SqlCommand command)
        {
            command.Parameters.AddWithValue("@hotelId", hotelInhabilitado.HotelId);
            command.Parameters.AddWithValue("@descripcion", hotelInhabilitado.Descripcion);
            command.Parameters.AddWithValue("@fechaCreacion", hotelInhabilitado.FechaCreacion);
            command.Parameters.AddWithValue("@fechaFin", hotelInhabilitado.FechaFin);
            command.Parameters.AddWithValue("@fechaInicio", hotelInhabilitado.FechaInicio);
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
                Mail = row["Mail"].ToString(),
                Telefono = row["Telefono"].ToString()
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
