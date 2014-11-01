﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Rol
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public bool Activo { get; set; }

        public List<Funcionalidad> Funcionalidades { get; set; }
    }
}
