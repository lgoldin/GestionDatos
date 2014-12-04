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
    public class ReservaRepository : BaseRepository<Reserva>
    {
        public override IEnumerable<Reserva> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Reserva Get(int codigo)
        {
            Reserva reserva = null;
            SqlCommand command = DBConnection.CreateStoredProcedure("GetReservaByCodigo");
            command.Parameters.AddWithValue("@codigo", codigo);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            if (collection.Count > 0)
            {
                DataRow reader = collection[0];
                reserva = new Reserva() { Codigo = Convert.ToInt32(reader["codigo"]), FechaDesde = Convert.ToDateTime(reader["fechaDesde"]), FechaHasta = Convert.ToDateTime(reader["fechaHasta"]), RegimenCodigo = Convert.ToInt32(reader["regimenCodigo"]), HotelId = Convert.ToInt32(reader["hotelId"]) };
            }

            SqlCommand tipoHabitacionCommand = DBConnection.CreateStoredProcedure("GetTipoHabitacionByReserva");
            tipoHabitacionCommand.Parameters.AddWithValue("@reservaCodigo", codigo);
            DataRowCollection tipoHabitacionCollection = DBConnection.EjecutarStoredProcedureSelect(tipoHabitacionCommand).Rows;

            if (tipoHabitacionCollection.Count > 0)
            {
                DataRow reader = tipoHabitacionCollection[0];
                reserva.TipoHabitacionCodigo = Convert.ToInt32(reader["tipoHabitacionCodigo"]);
            }           

            return reserva;
        }

        public override int Insert(Reserva reserva)
        {
            int codigo;
            using (var transaction = new TransactionScope())
            {
                SqlCommand command = DBConnection.CreateStoredProcedure("InsertReserva");
                command.Parameters.AddWithValue("@fechaDesde", reserva.FechaDesde);
                command.Parameters.AddWithValue("@fechaHasta", reserva.FechaHasta);
                command.Parameters.AddWithValue("@regimenCodigo", reserva.RegimenCodigo);
                command.Parameters.AddWithValue("@hotelId", reserva.HotelId);
                command.Parameters.AddWithValue("@estadoId", reserva.EstadoId);
                command.Parameters.AddWithValue("@clienteId", reserva.ClienteId);
                command.Parameters.AddWithValue("@fechaCreacion", reserva.FechaCreacion);
                codigo = DBConnection.ExecuteScalar(command);

                SqlCommand reservaHabitacionCommand = DBConnection.CreateStoredProcedure("InsertReservaTipoHabitacion");
                reservaHabitacionCommand.Parameters.AddWithValue("@reservaCodigo", codigo);
                reservaHabitacionCommand.Parameters.AddWithValue("@tipoHabitacionCodigo", reserva.TipoHabitacionCodigo);
                DBConnection.ExecuteNonQuery(reservaHabitacionCommand);

                transaction.Complete();
            }

            return codigo;
        }

        public override void Update(Reserva reserva)
        {
            using (var transaction = new TransactionScope())
            {
                SqlCommand command = DBConnection.CreateStoredProcedure("UpdateReserva");
                command.Parameters.AddWithValue("@codigo", reserva.Codigo);
                command.Parameters.AddWithValue("@fechaDesde", reserva.FechaDesde);
                command.Parameters.AddWithValue("@fechaHasta", reserva.FechaHasta);
                command.Parameters.AddWithValue("@regimenCodigo", reserva.RegimenCodigo);
                command.Parameters.AddWithValue("@hotelId", reserva.HotelId);
                DBConnection.ExecuteNonQuery(command);

                SqlCommand reservaHabitacionDeleteCommand = DBConnection.CreateStoredProcedure("DeleteReservaTipoHabitacion");
                reservaHabitacionDeleteCommand.Parameters.AddWithValue("@reservaCodigo", reserva.Codigo);
                DBConnection.ExecuteNonQuery(reservaHabitacionDeleteCommand);

                SqlCommand reservaHabitacionCommand = DBConnection.CreateStoredProcedure("InsertReservaTipoHabitacion");
                reservaHabitacionCommand.Parameters.AddWithValue("@reservaCodigo", reserva.Codigo);
                reservaHabitacionCommand.Parameters.AddWithValue("@tipoHabitacionCodigo", reserva.TipoHabitacionCodigo);
                DBConnection.ExecuteNonQuery(reservaHabitacionCommand);

                transaction.Complete();
            }
        }

        public override void Delete(Reserva entity)
        {
            throw new NotImplementedException();
        }

        public List<Regimen> GetActiveReservaRegimenesByHotelId(int hotelId)
        {
            List<Regimen> regimenes = new List<Regimen>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetActiveReservaRegimenesByHotelId");
            command.Parameters.AddWithValue("@hotelId", hotelId);
            command.Parameters.AddWithValue("@fecha", Session.Fecha);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow regimen in collection)
            {
                regimenes.Add(this.CreateRegimen(regimen));
            }

            return regimenes;
        }

        public List<Reserva> GetActiveReservaBetweenDatesByHotelId(int hotelId, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Reserva> reservas = new List<Reserva>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetActiveReservaBetweenDatesByHotel");
            command.Parameters.AddWithValue("@hotelId", hotelId);
            command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            foreach (DataRow reserva in collection)
            {
                reservas.Add(new Reserva() { Codigo = Convert.ToInt32(reserva["codigo"]), HotelId = hotelId});
            }

            return reservas;
        }

        public bool IsReservaAvailable(int hotelId, DateTime fechaDesde, DateTime fechaHasta, int tipoHabitacionCodigo)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("CountPosibleReserva");
            command.Parameters.AddWithValue("@hotelId", hotelId);
            command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
            command.Parameters.AddWithValue("@tipoHabitacionCodigo", tipoHabitacionCodigo);
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;

            DataRow reader = collection[0];

            return Convert.ToInt32(reader[0]) > 0;
        }

        public void Cancelar(int codigo, string motivo, Usuario usuario)
        {
            using (var transaction = new TransactionScope())
            {
                int estadoId = usuario.Username == "guest" ? 4 /*Guest*/ : 3 /*Recepcion*/;
                SqlCommand logCommand = DBConnection.CreateStoredProcedure("InsertReservaLog");
                logCommand.Parameters.AddWithValue("@reservaCodigo", codigo);
                logCommand.Parameters.AddWithValue("@fecha", Session.Fecha);
                logCommand.Parameters.AddWithValue("@usuarioId", usuario.Id);
                logCommand.Parameters.AddWithValue("@tipoId", 3/*Cancelacion*/);
                logCommand.Parameters.AddWithValue("@motivo", motivo);
                DBConnection.ExecuteNonQuery(logCommand);

                SqlCommand command = DBConnection.CreateStoredProcedure("UpdateEstadoReserva");
                command.Parameters.AddWithValue("@codigo", codigo);
                command.Parameters.AddWithValue("@estadoId", estadoId);
                DBConnection.ExecuteNonQuery(command);

                transaction.Complete();
            }            
        }

        private Regimen CreateRegimen(DataRow row)
        {
            Regimen regimen = new Regimen();
            regimen.Descripcion = row["descripcion"].ToString();
            regimen.Codigo = Convert.ToInt32(row["codigo"]);
            return regimen;
        }
    }
}
