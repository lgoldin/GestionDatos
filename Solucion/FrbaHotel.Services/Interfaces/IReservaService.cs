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

        void Update(Reserva reserva);

        Reserva GetReservaByCodigo(int codigo);

        List<Regimen> GetActiveReservaRegimenesByHotelId(int hotelId);

        int GetCountActiveReservaBetweenDatesByHotelId(int hotelId, DateTime fechaDesde, DateTime fechaHasta);

        int GetCountHabsAvailable(int hotelId, DateTime fechaDesde, DateTime fechaHasta, int tipoHabitacionCodigo);

        void Cancelar(IEnumerable<int> codigos, string motivo, Usuario usuario, bool noShow);

        IEnumerable<Reserva> GetReservasPosteriores(Reserva reserva);

        IEnumerable<Reserva> GetReservasVencidas();
    }
}
