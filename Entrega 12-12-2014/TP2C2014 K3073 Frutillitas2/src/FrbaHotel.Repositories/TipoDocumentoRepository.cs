using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Repositories
{
    public class TipoDocumentoRepository : BaseRepository<TipoDocumento>
    {
        public override IEnumerable<TipoDocumento> GetAll()
        {
            var tipos = new List<TipoDocumento>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetTiposDocumento");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow tipoDocumento in collection)
            {
                tipos.Add(this.CreateTipoDocumento(tipoDocumento));
            }
            
            return tipos;
        }

        public override TipoDocumento Get(int id)
        {
            return this.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public override int Insert(TipoDocumento entity)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("NombreDelSP");
            AddTipoDocumentoParameters(entity, command);
            return DBConnection.ExecuteNonQuery(command);
        }

        public override void Update(TipoDocumento entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(TipoDocumento entity)
        {
            throw new NotImplementedException();
        }

        private TipoDocumento CreateTipoDocumento(DataRow row)
        {
            return new TipoDocumento
            {
                Nombre = row["Nombre"].ToString(),
                Id = Convert.ToInt32(row["Id"])
            };
        }

        private void AddTipoDocumentoParameters(TipoDocumento tipoDocumento, SqlCommand command)
        {
        }
    }
}
