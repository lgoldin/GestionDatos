using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Entities;
using FrbaHotel.Repositories;
using System.Security.Cryptography;

namespace FrbaHotel.Services
{
    public class UsuarioService : IUsuarioService
    {
        public Usuario Get(int idUsuario)
        {
            var repository = new UsuarioRepository();
            return repository.Get(idUsuario);
        }

        public int Save(Usuario usuario)
        {
            int id = usuario.Id;

            usuario.HashedPassword = this.HashPassword(usuario.Password);

            var repository = new UsuarioRepository();

            if (usuario.IsNew())
            {
                id = repository.Insert(usuario);
            }
            else
            {
               repository.Update(usuario);
            }

            return id;
        }

        public void Delete(Usuario usuario)
        {
            var repository = new UsuarioRepository();
            repository.Delete(usuario);
        }

        public IEnumerable<Usuario> GetAll(string username, string nombre, string apellido, int? tipoDocumentoId, string numeroDocumento, string mail, string telefono, string direccion, DateTime? fechaNacimiento, int? rolId)
        {
            var repository = new UsuarioRepository();
            return repository.GetAll(username, nombre, apellido, tipoDocumentoId, numeroDocumento, mail, telefono, direccion, fechaNacimiento, rolId);
        }

        private byte[] HashPassword(string password)
        {
            return SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
