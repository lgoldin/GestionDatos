﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Services;
using FrbaHotel.Entities;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            PaisService paisService = new PaisService();
            List<Pais> paises = paisService.GetAll().ToList();
            cmbNacionalidad.DataSource = paises;
            cmbNacionalidad.DisplayMember = "Nacionalidad";
            cmbNacionalidad.ValueMember = "Id";

            TipoDocumentoService tipoDocumentoService = new TipoDocumentoService();
            List<TipoDocumento> documentos = tipoDocumentoService.GetAll().ToList();
            cmbTipoDocumento.DataSource = documentos;
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.ValueMember = "Id";

            dateNacimiento.MaxDate = Session.Fecha;
            dateNacimiento.Value = Session.Fecha;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string error = ValidateForm();
            if (string.IsNullOrEmpty(error))
            {
                ClienteService clienteService = new ClienteService();
                if (clienteService.GetByMail(txtMail.Text).Id == 0)
                {
                    Cliente cliente = new Cliente();
                    cliente.Apellido = txtApellido.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.FechaNacimiento = dateNacimiento.Value;
                    cliente.Mail = txtMail.Text;
                    cliente.Nacionalidad = Convert.ToInt32(cmbNacionalidad.SelectedValue);
                    cliente.Nombre = txtNombre.Text;
                    cliente.NumeroDocumento = txtNumeroDocumento.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.TipoDeDocumento = new TipoDocumento();
                    cliente.TipoDeDocumento.Id = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
                    if (clienteService.GetByTipoYNumeroDocumento(cliente.TipoDeDocumento.Id, cliente.NumeroDocumento).Id == 0)
                    {
                        clienteService.Insert(cliente);
                        MessageBox.Show("El cliente se ha dado de alta");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con ese número y tipo de documento");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con ese mail");
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private string ValidateForm()
        {
            string errorMessage = string.Empty;
            if (Convert.ToInt32(cmbNacionalidad.SelectedValue) == 0)
            {
                errorMessage = "Seleccione una nacionalidad";
            }
            if (Convert.ToInt32(cmbTipoDocumento.SelectedValue) == 0)
            {
                errorMessage += System.Environment.NewLine + "Seleccione un tipo de documento";
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el apellido";
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba la dirección";
            }
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el mail";
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el nombre";
            }
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el numero de documento";
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el teléfono";
            }

            return errorMessage;
        }
    }
}
