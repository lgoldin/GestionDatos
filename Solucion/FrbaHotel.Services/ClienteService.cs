using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Entities;
using FrbaHotel.Repositories;

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
    }
}
