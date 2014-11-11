﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Services.Interfaces
{
    public interface IUsuarioService
    {
        Usuario Get(int idUsuario);

        int Save(Usuario usuario);

        void Delete(Usuario usuario);

        IEnumerable<Usuario> GetAll(string username, string nombre, string apellido, int? tipoDocumentoId, string numeroDocumento, string mail, string telefono, string direccion, DateTime? fechaNacimiento, int? rolId);
    }
}
