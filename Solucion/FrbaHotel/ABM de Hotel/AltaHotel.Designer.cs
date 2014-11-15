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
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.estrellas.SuspendLayout();
            this.SuspendLayout();
            // 
            // chListRegimenes
            // 
            this.chListRegimenes.FormattingEnabled = true;
            this.chListRegimenes.Location = new System.Drawing.Point(137, 299);
            this.chListRegimenes.Name = "chListRegimenes";
            this.chListRegimenes.Size = new System.Drawing.Size(188, 94);
            this.chListRegimenes.TabIndex = 42;
            // 
            // cmbPaises
            // 
            this.cmbPaises.FormattingEnabled = true;
            this.cmbPaises.Location = new System.Drawing.Point(136, 221);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(189, 21);
            this.cmbPaises.TabIndex = 41;
            this.cmbPaises.SelectedIndexChanged += new System.EventHandler(this.cmbPaises_SelectedIndexChanged);
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Location = new System.Drawing.Point(136, 262);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(189, 21);
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
            this.estrellas.Location = new System.Drawing.Point(38, 146);
            this.estrellas.Name = "estrellas";
            this.estrellas.Size = new System.Drawing.Size(287, 53);
            this.estrellas.TabIndex = 39;
            this.estrellas.TabStop = false;
            this.estrellas.Text = "Estrellas";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(11, 23);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(36, 24);
            this.rb1.TabIndex = 18;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(218, 23);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(36, 24);
            this.rb5.TabIndex = 14;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(167, 23);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(36, 24);
            this.rb4.TabIndex = 16;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(63, 23);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(36, 24);
            this.rb2.TabIndex = 17;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(116, 23);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(36, 24);
            this.rb3.TabIndex = 15;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(136, 115);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(189, 20);
            this.txtMail.TabIndex = 38;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 418);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(188, 20);
            this.txtTelefono.TabIndex = 37;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 449);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(188, 20);
            this.txtDireccion.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 35;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(34, 113);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 20);
            this.lblMail.TabIndex = 34;
            this.lblMail.Text = "Mail:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(37, 416);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTelefono.TabIndex = 33;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(37, 449);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 32;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(34, 263);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(63, 20);
            this.lblCiudad.TabIndex = 30;
            this.lblCiudad.Text = "Ciudad:";
            this.lblCiudad.Click += new System.EventHandler(this.lblCiudad_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(34, 221);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(43, 20);
            this.lblPais.TabIndex = 29;
            this.lblPais.Text = "Pais:";
            this.lblPais.Click += new System.EventHandler(this.lblPais_Click);
            // 
            // lblRegimenes
            // 
            this.lblRegimenes.AutoSize = true;
            this.lblRegimenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimenes.Location = new System.Drawing.Point(34, 299);
            this.lblRegimenes.Name = "lblRegimenes";
            this.lblRegimenes.Size = new System.Drawing.Size(94, 20);
            this.lblRegimenes.TabIndex = 28;
            this.lblRegimenes.Text = "Regimenes:";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(34, 496);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(147, 20);
            this.lblFechaCreacion.TabIndex = 27;
            this.lblFechaCreacion.Text = "Fecha de Creacion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(34, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Alta-Hotel";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(38, 566);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(117, 30);
            this.btnCrear.TabIndex = 45;
            this.btnCrear.Text = "Crear Hotel";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 496);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // AltaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 627);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}