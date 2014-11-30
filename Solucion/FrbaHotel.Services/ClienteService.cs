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
    }
}
