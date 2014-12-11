namespace FrbaHotel.ABM_de_Habitacion
{
    partial class HabitacionForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkActiva = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkFrente = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tipo Habitacion";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(420, 76);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 20);
            this.txtPiso.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Piso";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(420, 39);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Numero";
            // 
            // chkActiva
            // 
            this.chkActiva.AutoSize = true;
            this.chkActiva.Checked = true;
            this.chkActiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiva.Location = new System.Drawing.Point(182, 157);
            this.chkActiva.Name = "chkActiva";
            this.chkActiva.Size = new System.Drawing.Size(15, 14);
            this.chkActiva.TabIndex = 65;
            this.chkActiva.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Activa";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(420, 116);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Descripcion";
            // 
            // chkFrente
            // 
            this.chkFrente.AutoSize = true;
            this.chkFrente.Location = new System.Drawing.Point(182, 122);
            this.chkFrente.Name = "chkFrente";
            this.chkFrente.Size = new System.Drawing.Size(15, 14);
            this.chkFrente.TabIndex = 61;
            this.chkFrente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Frente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 207);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(562, 41);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(154, 38);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(100, 21);
            this.cmbHotel.TabIndex = 67;
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(154, 75);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoHabitacion.TabIndex = 68;
            // 
            // HabitacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 274);
            this.Controls.Add(this.cmbTipoHabitacion);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkActiva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkFrente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Name = "HabitacionForm";
            this.Text = "ABM Habitacion";
            this.Load += new System.EventHandler(this.HabitacionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkActiva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkFrente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
    }
}