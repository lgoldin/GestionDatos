using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IClienteService
    {
        Cliente GetByMail(string mail);
        int Insert(Cliente cliente);
    }
}
