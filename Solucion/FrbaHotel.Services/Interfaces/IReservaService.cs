using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using FrbaHotel.Entities.DTOs;

namespace FrbaHotel.Services.Interfaces
{
    public interface IReservaService
    {
        int Insert(Reserva reserva);

        List<Regimen> GetActiveReservaRegimenesByHotelId(int hotelId);

        int GetCountActiveReservaBetweenDatesByHotelId(int hotelId, DateTime fechaDesde, DateTime fechaHasta);

        ReservaDTO GetReservaByCodigo(int codigo);

        bool IsReservaAvailable(int hotelId, DateTime fechaDesde, DateTime fechaHasta, int tipoHabitacionCodigo);
    }
}
