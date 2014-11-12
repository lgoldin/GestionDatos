using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Repositories;
using FrbaHotel.Entities;

namespace FrbaHotel.Services
{
    public class TipoDocumentoService : ITipoDocumentoService
    {
        public IEnumerable<TipoDocumento> GetAll()
        {
            var tipos = new List<TipoDocumento>();
            tipos.Add(new TipoDocumento { Id = 0, Nombre = "- No Especificado -" });

            var repository = new TipoDocumentoRepository();
            repository.GetAll().ToList().ForEach(tipos.Add);
            
            return tipos;
        }
    }
}
