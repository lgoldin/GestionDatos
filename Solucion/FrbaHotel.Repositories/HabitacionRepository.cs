using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;

namespace FrbaHotel.Repositories
{
    public class HabitacionRepository : BaseRepository<Habitacion>
    {
        public override IEnumerable<Habitacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Habitacion Get(int id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Habitacion entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Habitacion> GetAll(bool frente, string numero, string piso, string descripcion, int? hotelId, int? tipoHabitacion)
        {
            return new List<Habitacion>();
        }
    }
}
