﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace FrbaHotel.Repositories
{
    public class RolRepository : BaseRepository<Rol>
    {
        public override IEnumerable<Rol> GetAll()
        {
            var roles = new List<Rol>();

            SqlCommand command = DBConnection.CreateStoredProcedure("GetRoles");
            DataRowCollection collection = DBConnection.EjecutarStoredProcedureSelect(command).Rows;
            foreach (DataRow rol in collection)
            {
                roles.Add(this.CreateRol(rol));
            }
            
            return roles;
        }

        public override Rol Get(int id)
        {
            return this.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public override int Insert(Rol entity)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("InsertRol");
            AddRolParameters(entity, command);
            int rolId = (int)DBConnection.ExecuteScalar(command);

            InsertRolFuncionalidad(entity, rolId);

            return rolId;
        }

        public override void Update(Rol entity)
        {
            using (var transaction = new TransactionScope())
            {
                SqlCommand command = DBConnection.CreateStoredProcedure("UpdateRol");
                AddRolParameters(entity, command);
                command.Parameters.AddWithValue("@id", entity.Id);
                DBConnection.ExecuteNonQuery(command);

                InsertRolFuncionalidad(entity, entity.Id);

                transaction.Complete();
            }
        }

        public override void Delete(Rol entity)
        {
            SqlCommand command = DBConnection.CreateStoredProcedure("DeleteRol");
            command.Parameters.AddWithValue("@activo", entity.Activo);
            command.Parameters.AddWithValue("@id", entity.Id);
            DBConnection.ExecuteNonQuery(command);
        }

        private void InsertRolFuncionalidad(Rol entity, int rolId)
        {
            foreach (Funcionalidad f in entity.Funcionalidades)
            {
                SqlCommand commandRolFuncionalidad = DBConnection.CreateStoredProcedure("InsertRolFuncionalidad");
                AddRolFuncionalidadParameters(rolId, f.Id, commandRolFuncionalidad);
                DBConnection.ExecuteNonQuery(commandRolFuncionalidad);
            }
        }

        private Rol CreateRol(DataRow row)
        {
            return new Rol
            {
                Activo = Convert.ToBoolean(row["Activo"]),
                Nombre = row["Nombre"].ToString(),
                Id = Convert.ToInt32(row["Id"])
            };
        }

        private void AddRolFuncionalidadParameters(int rolId, int funcionalidadId, SqlCommand command)
        {
            command.Parameters.AddWithValue("@rolId", rolId);
            command.Parameters.AddWithValue("@funcionalidadId", funcionalidadId);
        }

        private void AddRolParameters(Rol rolUsuario, SqlCommand command)
        {
            command.Parameters.AddWithValue("@nombre", rolUsuario.Nombre);
            command.Parameters.AddWithValue("@activo", rolUsuario.Activo);
        }
    }
}
