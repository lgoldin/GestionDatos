﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Login;

namespace FrbaHotel
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Activate();
            loginForm.Show();
            loginForm.BringToFront();

            Application.OpenForms["Index"].SendToBack();
        }
    }
}
