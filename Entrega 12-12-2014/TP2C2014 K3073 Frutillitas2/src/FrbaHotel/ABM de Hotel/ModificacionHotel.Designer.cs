namespace FrbaHotel.ABM_de_Hotel
{
    partial class ModificacionHotel
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
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.chListRegimenes = new System.Windows.Forms.CheckedListBox();
            this.cmbPaises = new System.Windows.Forms.ComboBox();
            this.cmbCiudades = new System.Windows.Forms.ComboBox();
            this.estrellas = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
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
            this.estrellas.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(111, 28);
            this.rb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rb3.Location = new System.Drawing.Point(181, 28);
            this.rb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(41, 29);
            this.rb3.TabIndex = 15;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(49, 607);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(229, 37);
            this.btnModificar.TabIndex = 64;
            this.btnModificar.Text = "Modificar Hotel";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(249, 28);
            this.rb4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(41, 29);
            this.rb4.TabIndex = 16;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // chListRegimenes
            // 
            this.chListRegimenes.FormattingEnabled = true;
            this.chListRegimenes.Location = new System.Drawing.Point(181, 348);
            this.chListRegimenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chListRegimenes.Name = "chListRegimenes";
            this.chListRegimenes.Size = new System.Drawing.Size(249, 106);
            this.chListRegimenes.TabIndex = 63;
            // 
            // cmbPaises
            // 
            this.cmbPaises.FormattingEnabled = true;
            this.cmbPaises.Location = new System.Drawing.Point(180, 252);
            this.cmbPaises.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(251, 24);
            this.cmbPaises.TabIndex = 62;
            this.cmbPaises.SelectedIndexChanged += new System.EventHandler(this.cmbPaises_SelectedIndexChanged);
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Location = new System.Drawing.Point(180, 303);
            this.cmbCiudades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(251, 24);
            this.cmbCiudades.TabIndex = 61;
            // 
            // estrellas
            // 
            this.estrellas.Controls.Add(this.rb1);
            this.estrellas.Controls.Add(this.rb5);
            this.estrellas.Controls.Add(this.rb4);
            this.estrellas.Controls.Add(this.rb2);
            this.estrellas.Controls.Add(this.rb3);
            this.estrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estrellas.Location = new System.Drawing.Point(49, 160);
            this.estrellas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estrellas.Name = "estrellas";
            this.estrellas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estrellas.Size = new System.Drawing.Size(383, 65);
            this.estrellas.TabIndex = 60;
            this.estrellas.TabStop = false;
            this.estrellas.Text = "Estrellas";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(41, 28);
            this.rb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rb5.Location = new System.Drawing.Point(317, 28);
            this.rb5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(41, 29);
            this.rb5.TabIndex = 14;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(180, 122);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(251, 22);
            this.txtMail.TabIndex = 59;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(181, 495);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(249, 22);
            this.txtTelefono.TabIndex = 58;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(181, 533);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(249, 22);
            this.txtDireccion.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 73);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 22);
            this.txtNombre.TabIndex = 56;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(44, 119);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(54, 25);
            this.lblMail.TabIndex = 55;
            this.lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(48, 492);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 25);
            this.lblTelefono.TabIndex = 54;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(48, 533);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(99, 25);
            this.lblDireccion.TabIndex = 53;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(44, 304);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(81, 25);
            this.lblCiudad.TabIndex = 52;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(44, 252);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(56, 25);
            this.lblPais.TabIndex = 51;
            this.lblPais.Text = "Pais:";
            // 
            // lblRegimenes
            // 
            this.lblRegimenes.AutoSize = true;
            this.lblRegimenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimenes.Location = new System.Drawing.Point(44, 348);
            this.lblRegimenes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegimenes.Name = "lblRegimenes";
            this.lblRegimenes.Size = new System.Drawing.Size(116, 25);
            this.lblRegimenes.TabIndex = 50;
            this.lblRegimenes.Text = "Regimenes:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(44, 73);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Modificación-Hotel";
            // 
            // ModificacionHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 688);
            this.Controls.Add(this.btnModificar);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificacionHotel";
            this.Text = "ModificacionHotel";
            this.Load += new System.EventHandler(this.ModificacionHotel_Load);
            this.estrellas.ResumeLayout(false);
            this.estrellas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.CheckedListBox chListRegimenes;
        private System.Windows.Forms.ComboBox cmbPaises;
        private System.Windows.Forms.ComboBox cmbCiudades;
        private System.Windows.Forms.GroupBox estrellas;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb5;
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
    }
}