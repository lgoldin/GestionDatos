namespace FrbaHotel.ABM_de_Usuario
{
    partial class ListadoUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelecionarFecha = new System.Windows.Forms.Button();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecionarFecha);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.cmbRol);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNumeroDocumento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // btnSelecionarFecha
            // 
            this.btnSelecionarFecha.Location = new System.Drawing.Point(655, 87);
            this.btnSelecionarFecha.Name = "btnSelecionarFecha";
            this.btnSelecionarFecha.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarFecha.TabIndex = 4;
            this.btnSelecionarFecha.Text = "Seleccionar";
            this.btnSelecionarFecha.UseVisualStyleBackColor = true;
            this.btnSelecionarFecha.Click += new System.EventHandler(this.btnSelecionarFecha_Click);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(549, 90);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 46;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(98, 118);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(100, 21);
            this.cmbRol.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Rol";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Fecha Nacimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(98, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(549, 52);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 41;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(549, 19);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Numero Documento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Apellido";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(307, 83);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 37;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(98, 87);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 31;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(307, 52);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDocumento.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tipo Documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(307, 19);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoDocumento.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(716, 177);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 177);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(12, 225);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(779, 255);
            this.dgvUsuario.TabIndex = 3;
            // 
            // ListadoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 492);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoUsuario";
            this.Text = "ListadoUsuario";
            this.Load += new System.EventHandler(this.ListadoUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Button btnSelecionarFecha;
    }
}