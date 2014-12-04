﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IConsumibleService
    {
        IEnumerable<Consumible> GetByIdEstadia(int idEstadia);

        IEnumerable<Consumible> GetAll();
    }
}
