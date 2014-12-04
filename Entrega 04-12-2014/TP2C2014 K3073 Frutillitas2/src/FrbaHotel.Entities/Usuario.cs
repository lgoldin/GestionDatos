using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public string  Username { get; set; }

        public string Password { get; set; }

        public Rol Rol { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public TipoDocumento TipoDocumento{ get; set;}

        public string NumeroDocumento { get; set; }

        public string Mail { get; set; }

        public string Telefono { get; set; }

        public Direccion Direccion { get; set; }
       
        public DateTime? FechaNacimiento { get; set; }
        
        public List<Hotel> Hoteles { get; set; }

        public bool IsNew()
        {
            return this.Id == 0;
        }

        public byte[] HashedPassword { get; set; }

        public bool Habilitado { get; set; }
    }
}
