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
    public class HotelService : IHotelService
    {
        public IEnumerable<Hotel> GetAll(string nombre, int? estrellas, int? paisId, int? ciudadId)
        {
            var hoteles = new List<Hotel>();
            hoteles.Add(new Hotel { Id = 0, Nombre = "- No Especificado -" });

            var repository = new HotelRepository();
            repository.GetAll(nombre, estrellas, paisId, ciudadId).ToList().ForEach(hoteles.Add);
            
            return hoteles;
        }

        public int Insert(Hotel hotel, int usuarioId)
        {
            HotelRepository repository = new HotelRepository();
            return repository.Insert(hotel, usuarioId);
        }

        public List<HotelDTO> GetAllDTO(string nombre, int? estrellas, int? pais, int? ciudad)
        {
            List<HotelDTO> hotelesDTO = new List<HotelDTO>();
            List<Hotel> hoteles = this.GetAll(nombre, estrellas, pais, ciudad).ToList();

            foreach (Hotel h in hoteles)
            {
                if (h.Id != 0)
                {
                    hotelesDTO.Add(new HotelDTO()
                        {
                            Ciudad = h.Ciudad.Nombre,
                            Direccion = h.Direccion,
                            Estrellas = h.Estrellas,
                            FechaCreacion = h.FechaCreacion.ToString(),
                            Id = h.Id,
                            Mail = h.Mail,
                            Nombre = h.Nombre,
                            Pais = h.Ciudad.Pais.Nombre,
                            Telefono = h.Telefono,
                            Modificar = "Modificar",
                            Inhabilitar = "Inhabilitar"
                        });
                }
            }

            return hotelesDTO;
        }

        public void Update(Hotel hotel)
        {
            var repository = new HotelRepository();
            repository.Update(hotel);
            
        }

        public IEnumerable<Hotel> GetByIdUsuario(int idUsuario)
        {
            var hoteles = new List<Hotel>();
            hoteles.Add(new Hotel { Id = 0, Nombre = "- No Especificado -" });

            var repository = new HotelRepository();
            repository.GetByIdUsuario(idUsuario).ToList().ForEach(hoteles.Add);

            return hoteles;
        }

        #region IHotelService Members


        public Hotel GetById(int id)
        {
            return this.GetAll(null,null,null,null).FirstOrDefault(x => x.Id == id);
        }


        public int InsertHotelInhabilitado(HotelInhabilitacion hotelInhabilitado)
        {
            var repository = new HotelRepository();
            return repository.InsertHotelInhabilitado(hotelInhabilitado);
        }

        #endregion
    }
}
