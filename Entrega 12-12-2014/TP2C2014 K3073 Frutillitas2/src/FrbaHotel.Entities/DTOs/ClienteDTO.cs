using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }

        public string FechaNacimiento { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string TipoDeDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Mail { get; set; }

        public string Modificar { get; set; }
    }
}
