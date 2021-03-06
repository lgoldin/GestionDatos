﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IRegimenService
    {
        IEnumerable<Regimen> GetAll();
        List<Regimen> GetByHotelId(int hotelId);
        Regimen GetByCodigo(int codigo);
    }
}
