using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace FrbaHotel.Entities
{
    public static class Session
    {
        public static Usuario Usuario { get; set; }

        public static Hotel Hotel { get; set; }

        public static DateTime Fecha 
        {
            get
            {
                return Convert.ToDateTime(ConfigurationSettings.AppSettings["Fecha"]);
            }
        }
    }
}
