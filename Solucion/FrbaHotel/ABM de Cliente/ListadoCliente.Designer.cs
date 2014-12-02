namespace FrbaHotel.ABM_de_Cliente
{
    partial class ListadoCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtnroIdentificacion = new System.Windows.Forms.TextBox();
            this.lblNroIdentificacion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 96);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 22);
            this.txtNombre.TabIndex = 52;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(24, 251);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(143, 40);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(717, 228);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(143, 42);
            this.btnBuscar.TabIndex = 61;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            this.dgClientes.Location = new System.Drawing.Point(24, 311);
            this.dgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(1127, 183);
            this.dgClientes.TabIndex = 59;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.DataPropertyName = "Modificar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Modificar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(681, 94);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(251, 24);
            this.cmbTipoDocumento.TabIndex = 58;
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(472, 93);
            this.lblTipoIdentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(201, 25);
            this.lblTipoIdentificacion.TabIndex = 57;
            this.lblTipoIdentificacion.Text = "Tipo de identificación:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 96);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 51;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(155, 144);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(251, 22);
            this.txtApellido.TabIndex = 63;
            this.txtApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(19, 144);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 25);
            this.lblApellido.TabIndex = 62;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnroIdentificacion
            // 
            this.txtnroIdentificacion.Location = new System.Drawing.Point(681, 140);
            this.txtnroIdentificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtnroIdentificacion.Name = "txtnroIdentificacion";
            this.txtnroIdentificacion.Size = new System.Drawing.Size(251, 22);
            this.txtnroIdentificacion.TabIndex = 65;
            this.txtnroIdentificacion.TextChanged += new System.EventHandler(this.txtnroIdentificacion_TextChanged);
            this.txtnroIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnroIdentificacion_KeyPress);
            // 
            // lblNroIdentificacion
            // 
            this.lblNroIdentificacion.AutoSize = true;
            this.lblNroIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroIdentificacion.Location = new System.Drawing.Point(472, 140);
            this.lblNroIdentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroIdentificacion.Name = "lblNroIdentificacion";
            this.lblNroIdentificacion.Size = new System.Drawing.Size(193, 25);
            this.lblNroIdentificacion.TabIndex = 64;
            this.lblNroIdentificacion.Text = "Nro de identificación:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 192);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 22);
            this.txtEmail.TabIndex = 67;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(19, 192);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 66;
            this.lblEmail.Text = "Email:";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(24, 13);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(143, 40);
            this.btnCrear.TabIndex = 68;
            this.btnCrear.Text = "Crear Cliente";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 539);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtnroIdentificacion);
            this.Controls.Add(this.lblNroIdentificacion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.lblTipoIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Name = "ListadoCliente";
            this.Text = "ListadoCliente";
            this.Load += new System.EventHandler(this.ListadoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtnroIdentificacion;
        private System.Windows.Forms.Label lblNroIdentificacion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
    }
}