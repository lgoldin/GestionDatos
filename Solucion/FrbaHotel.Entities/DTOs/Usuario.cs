using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }

        public string  Username { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string TipoDocumento{ get; set;}

        public string NumeroDocumento { get; set; }

        public string Mail { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }
       
        public string FechaNacimiento { get; set; }

        public string Modificar { get; set; }

        public bool Habilitado { get; set; }
    }
}
