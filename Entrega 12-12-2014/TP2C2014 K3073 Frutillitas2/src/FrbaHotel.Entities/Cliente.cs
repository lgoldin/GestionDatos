using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public TipoDocumento TipoDeDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Mail { get; set; }

        public string  Telefono { get; set; }

        public int Nacionalidad { get; set; }

        public string Direccion { get; set; }

        public bool Habilitado { get; set; }
    }
}
