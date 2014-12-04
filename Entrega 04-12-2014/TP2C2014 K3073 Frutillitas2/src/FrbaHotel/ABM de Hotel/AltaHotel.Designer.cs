namespace FrbaHotel.ABM_de_Hotel
{
    partial class AltaHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chListRegimenes = new System.Windows.Forms.CheckedListBox();
            this.cmbPaises = new System.Windows.Forms.ComboBox();
            this.cmbCiudades = new System.Windows.Forms.ComboBox();
            this.estrellas = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblRegimenes = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.estrellas.SuspendLayout();
            this.SuspendLayout();
            // 
            // chListRegimenes
            // 
            this.chListRegimenes.FormattingEnabled = true;
            this.chListRegimenes.Location = new System.Drawing.Point(183, 341);
            this.chListRegimenes.Margin = new System.Windows.Forms.Padding(4);
            this.chListRegimenes.Name = "chListRegimenes";
            this.chListRegimenes.Size = new System.Drawing.Size(249, 106);
            this.chListRegimenes.TabIndex = 42;
            // 
            // cmbPaises
            // 
            this.cmbPaises.FormattingEnabled = true;
            this.cmbPaises.Location = new System.Drawing.Point(181, 245);
            this.cmbPaises.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(251, 24);
            this.cmbPaises.TabIndex = 41;
            this.cmbPaises.SelectedIndexChanged += new System.EventHandler(this.cmbPaises_SelectedIndexChanged);
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Location = new System.Drawing.Point(181, 295);
            this.cmbCiudades.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(251, 24);
            this.cmbCiudades.TabIndex = 40;
            this.cmbCiudades.SelectedIndexChanged += new System.EventHandler(this.cmbCiudades_SelectedIndexChanged);
            // 
            // estrellas
            // 
            this.estrellas.Controls.Add(this.rb1);
            this.estrellas.Controls.Add(this.rb5);
            this.estrellas.Controls.Add(this.rb4);
            this.estrellas.Controls.Add(this.rb2);
            this.estrellas.Controls.Add(this.rb3);
            this.estrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estrellas.Location = new System.Drawing.Point(51, 153);
            this.estrellas.Margin = new System.Windows.Forms.Padding(4);
            this.estrellas.Name = "estrellas";
            this.estrellas.Padding = new System.Windows.Forms.Padding(4);
            this.estrellas.Size = new System.Drawing.Size(383, 65);
            this.estrellas.TabIndex = 39;
            this.estrellas.TabStop = false;
            this.estrellas.Text = "Estrellas";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(15, 28);
            this.rb1.Margin = new System.Windows.Forms.Padding(4);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(41, 29);
            this.rb1.TabIndex = 18;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(291, 28);
            this.rb5.Margin = new System.Windows.Forms.Padding(4);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(41, 29);
            this.rb5.TabIndex = 14;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(223, 28);
            this.rb4.Margin = new System.Windows.Forms.Padding(4);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(41, 29);
            this.rb4.TabIndex = 16;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(84, 28);
            this.rb2.Margin = new System.Windows.Forms.Padding(4);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(41, 29);
            this.rb2.TabIndex = 17;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(155, 28);
            this.rb3.Margin = new System.Windows.Forms.Padding(4);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(41, 29);
            this.rb3.TabIndex = 15;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(181, 115);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(251, 22);
            this.txtMail.TabIndex = 38;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(183, 487);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(249, 22);
            this.txtTelefono.TabIndex = 37;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(183, 526);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(249, 22);
            this.txtDireccion.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 22);
            this.txtNombre.TabIndex = 35;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(45, 112);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(54, 25);
            this.lblMail.TabIndex = 34;
            this.lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(49, 485);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 25);
            this.lblTelefono.TabIndex = 33;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(49, 526);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(99, 25);
            this.lblDireccion.TabIndex = 32;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(45, 297);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(81, 25);
            this.lblCiudad.TabIndex = 30;
            this.lblCiudad.Text = "Ciudad:";
            this.lblCiudad.Click += new System.EventHandler(this.lblCiudad_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(45, 245);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(56, 25);
            this.lblPais.TabIndex = 29;
            this.lblPais.Text = "Pais:";
            this.lblPais.Click += new System.EventHandler(this.lblPais_Click);
            // 
            // lblRegimenes
            // 
            this.lblRegimenes.AutoSize = true;
            this.lblRegimenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimenes.Location = new System.Drawing.Point(45, 341);
            this.lblRegimenes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegimenes.Name = "lblRegimenes";
            this.lblRegimenes.Size = new System.Drawing.Size(116, 25);
            this.lblRegimenes.TabIndex = 28;
            this.lblRegimenes.Text = "Regimenes:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 65);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Alta-Hotel";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(50, 608);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(156, 37);
            this.btnCrear.TabIndex = 45;
            this.btnCrear.Text = "Crear Hotel";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 667);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.chListRegimenes);
            this.Controls.Add(this.cmbPaises);
            this.Controls.Add(this.cmbCiudades);
            this.Controls.Add(this.estrellas);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblRegimenes);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltaHotel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AltaHotel_Load);
            this.estrellas.ResumeLayout(false);
            this.estrellas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chListRegimenes;
        private System.Windows.Forms.ComboBox cmbPaises;
        private System.Windows.Forms.ComboBox cmbCiudades;
        private System.Windows.Forms.GroupBox estrellas;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblRegimenes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
    }
}