using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;
using FrbaHotel.Entities.DTOs;

namespace FrbaHotel.Services
{
    public class ReservaService : IReservaService
    {

        #region IReservaService Members

        public int Insert(Reserva reserva)
        {
            ReservaRepository repository = new ReservaRepository();
            return repository.Insert(reserva);
        }

        public List<Regimen> GetActiveReservaRegimenesByHotelId(int hotelId)
        {
            ReservaRepository repository = new ReservaRepository();
            List<Regimen> regimenes = repository.GetActiveReservaRegimenesByHotelId(hotelId);
            return regimenes;
        }


        public int GetCountActiveReservaBetweenDatesByHotelId(int hotelId, DateTime fechaDesde, DateTime fechaHasta)
        {
            ReservaRepository repository = new ReservaRepository();
            return repository.GetActiveReservaBetweenDatesByHotelId(hotelId, fechaDesde, fechaHasta).Count;
        }

        public Reserva GetReservaByCodigo(int codigo)
        {
            ReservaRepository repository = new ReservaRepository();
            Reserva reserva = repository.Get(codigo);
            return reserva;
        }

        public bool IsReservaAvailable(int hotelId, DateTime fechaDesde, DateTime fechaHasta, int tipoHabitacionCodigo)
        {
            ReservaRepository repository = new ReservaRepository();
            return repository.IsReservaAvailable(hotelId, fechaDesde, fechaHasta, tipoHabitacionCodigo);
        }

        public void Update(Reserva reserva)
        {
            ReservaRepository repository = new ReservaRepository();
            repository.Update(reserva);
        }

        public void Cancelar(int codigo, string motivo, Usuario usuario)
        {
            ReservaRepository repository = new ReservaRepository();
            repository.Cancelar(codigo, motivo, usuario);
        }

        #endregion
    }
}
