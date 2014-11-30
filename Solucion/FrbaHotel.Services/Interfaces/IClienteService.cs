using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetAll(string nombre, string apellido, string mail, string numeroDocumento, int? tipoDocumento);
        Cliente GetByMail(string mail);
        Cliente GetByTipoYNumeroDocumento(int tipoDocumento, string numeroDocumento);
        int Insert(Cliente cliente);
    }
}
