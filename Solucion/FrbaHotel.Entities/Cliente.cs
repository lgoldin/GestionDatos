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

        public string TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Mail { get; set; }

        public string  Telefono { get; set; }

        public string Nacionalidad { get; set; }

        public Direccion Direccion { get; set; }
    }
}
