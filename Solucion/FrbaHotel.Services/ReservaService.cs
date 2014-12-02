﻿using System;
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

        public ReservaDTO GetReservaDTOByCodigo(int codigo)
        {
            ReservaRepository repository = new ReservaRepository();
            RegimenRepository regimenRepository = new RegimenRepository();
            Reserva reserva = repository.Get(codigo);
            if (reserva != null)
                return new ReservaDTO() { Codigo = reserva.Codigo, FechaDesde = reserva.FechaDesde.ToShortDateString(), FechaHasta = reserva.FechaHasta.ToShortDateString(), Regimen = regimenRepository.Get(reserva.RegimenCodigo).Descripcion };
            else return null;
        }

        public Reserva GetReservaByCodigo(int codigo)
        {
            ReservaRepository repository = new ReservaRepository();
            RegimenRepository regimenRepository = new RegimenRepository();
            Reserva reserva = repository.Get(codigo);
            return reserva;
        }

        public bool IsReservaAvailable(int hotelId, DateTime fechaDesde, DateTime fechaHasta, int tipoHabitacionCodigo)
        {
            ReservaRepository repository = new ReservaRepository();
            return repository.IsReservaAvailable(hotelId, fechaDesde, fechaHasta, tipoHabitacionCodigo);
        }

        #endregion
    }
}
