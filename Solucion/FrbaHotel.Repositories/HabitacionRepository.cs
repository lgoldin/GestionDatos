using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class HabitacionRepository : BaseRepository<Habitacion>
    {
        public override IEnumerable<Habitacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Habitacion Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Habitacion> GetAll(bool frente, int? numero, int? piso, string descripcion, int? hotelId, int? tipoHabitacion, bool activa)
        {
            var habitaciones = new List<Habitacion>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetHabitaciones");
            command.Parameters.AddWithValue("@frente", frente);
            command.Parameters.AddWithValue("@numero", numero);
            command.Parameters.AddWithValue("@piso", piso);
            command.Parameters.AddWithValue("@descripcion", descripcion);
            command.Parameters.AddWithValue("@hotelId", hotelId);
            command.Parameters.AddWithValue("@tipoHabitacion", tipoHabitacion);
            command.Parameters.AddWithValue("@activa", activa);

            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow habitacion in collection)
            {
                habitaciones.Add(this.CreateHabitacion(habitacion));
            }

            return habitaciones;
        }

        private Habitacion CreateHabitacion(DataRow row)
        {
            return new Habitacion
            {
                Activa = Convert.ToBoolean(row["activa"]),
                Id = Convert.ToInt32(row["id"]),
                Descripcion = row["descripcion"].ToString(),
                Frente = row["frente"].Equals("S"),
                Hotel = this.CreateHotel(row),
                Numero = row["numero"].ToString(),
                Piso = row["piso"].ToString(),
                TipoHabitacion = this.CreateTipoHabitacion(row)
            };
        }

        private Hotel CreateHotel(DataRow row)
        {
            return new Hotel
            {
                Id = Convert.ToInt32(row["IdHotel"]),
                Nombre = !string.IsNullOrEmpty(row["Nombre"].ToString()) ? row["Nombre"].ToString() : "Hotel" + row["IdHotel"].ToString(),
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

        private TipoHabitacion CreateTipoHabitacion(DataRow tipo)
        {
            return new TipoHabitacion
            {
                Codigo = Convert.ToInt32(tipo["CodigoTipoHabitacion"]),
                Descripcion = tipo["DescripcionTipoHabitacion"].ToString(),
                Porcentual = Convert.ToDecimal(tipo["Porcentual"])
            };
        }
    }
}
