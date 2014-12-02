using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Entities;
using FrbaHotel.Repositories;
using FrbaHotel.Entities.DTOs;

namespace FrbaHotel.Services
{
    public class ClienteService : IClienteService
    {
        public Cliente GetByMail(string mail)
        {
            ClienteRepository clienteRepository = new ClienteRepository();
            return clienteRepository.GetByEmail(mail);
        }

        public int Insert(Cliente cliente)
        {
            ClienteRepository clienteRepository = new ClienteRepository();
            return clienteRepository.Insert(cliente);
        }

        public Cliente GetByTipoYNumeroDocumento(int tipoDocumento, string numeroDocumento)
        {
            ClienteRepository clienteRepository = new ClienteRepository();
            return clienteRepository.GetByTipoYNumeroDocumento(tipoDocumento, numeroDocumento);
        }

        public IEnumerable<Cliente> GetAll(string nombre, string apellido, string mail, string numeroDocumento, int? tipoDocumento)
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente { Id = 0, Nombre = "- No Especificado -" });

            var repository = new ClienteRepository();
            repository.GetAll(nombre, apellido, mail, numeroDocumento, tipoDocumento).ToList().ForEach(clientes.Add);

            return clientes;
        }

        public List<ClienteDTO> GetAllDTO(string nombre, string apellido, string mail, string numeroDocumento, int? tipoDocumentoId)
        {
            List<ClienteDTO> clientesDTO = new List<ClienteDTO>();
            List<Cliente> clientes = this.GetAll(nombre, apellido, mail, numeroDocumento, tipoDocumentoId).ToList();

            foreach (Cliente c in clientes)
            {
                if (c.Id != 0)
                {
                    clientesDTO.Add(new ClienteDTO()
                    {
                        Apellido = c.Apellido,
                        FechaNacimiento = c.FechaNacimiento.ToString(),
                        Id = c.Id,
                        Mail = c.Mail,
                        Nombre = c.Nombre,
                        NumeroDocumento = c.NumeroDocumento,
                        TipoDeDocumento = c.TipoDeDocumento.Nombre,
                        Modificar = "Modificar",
                        Eliminar = "Eliminar"
                    });
                }
            }

            return clientesDTO;
        }

        public Cliente GetById(int id)
        {
            ClienteRepository clienteRepository = new ClienteRepository();
            return clienteRepository.Get(id);   
        }

        public void Update(Cliente cliente)
        {
            ClienteRepository clienteRepository = new ClienteRepository();
            clienteRepository.Update(cliente);   
        }
    }
}
