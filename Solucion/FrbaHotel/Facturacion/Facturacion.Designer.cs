namespace FrbaHotel.Facturacion
{
    partial class Facturacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNroEstadia = new System.Windows.Forms.Label();
            this.txtNroEstadia = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.lblMedioDePago = new System.Windows.Forms.Label();
            this.cmbMedioDePago = new System.Windows.Forms.ComboBox();
            this.groupDatosTarjeta = new System.Windows.Forms.GroupBox();
            this.dateVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.lblCodigoSeguridad = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.groupDatosTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturación";
            // 
            // lblNroEstadia
            // 
            this.lblNroEstadia.AutoSize = true;
            this.lblNroEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroEstadia.Location = new System.Drawing.Point(29, 79);
            this.lblNroEstadia.Name = "lblNroEstadia";
            this.lblNroEstadia.Size = new System.Drawing.Size(182, 25);
            this.lblNroEstadia.TabIndex = 1;
            this.lblNroEstadia.Text = "Número de estadía:";
            // 
            // txtNroEstadia
            // 
            this.txtNroEstadia.Location = new System.Drawing.Point(246, 82);
            this.txtNroEstadia.Name = "txtNroEstadia";
            this.txtNroEstadia.ReadOnly = true;
            this.txtNroEstadia.Size = new System.Drawing.Size(203, 22);
            this.txtNroEstadia.TabIndex = 2;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(346, 214);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(103, 41);
            this.btnFacturar.TabIndex = 3;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // lblMedioDePago
            // 
            this.lblMedioDePago.AutoSize = true;
            this.lblMedioDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedioDePago.Location = new System.Drawing.Point(29, 145);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(217, 25);
            this.lblMedioDePago.TabIndex = 5;
            this.lblMedioDePago.Text = "Ingrese medio de pago:";
            // 
            // cmbMedioDePago
            // 
            this.cmbMedioDePago.FormattingEnabled = true;
            this.cmbMedioDePago.Location = new System.Drawing.Point(246, 149);
            this.cmbMedioDePago.Name = "cmbMedioDePago";
            this.cmbMedioDePago.Size = new System.Drawing.Size(203, 24);
            this.cmbMedioDePago.TabIndex = 6;
            this.cmbMedioDePago.SelectedIndexChanged += new System.EventHandler(this.cmbMedioDePago_SelectedIndexChanged);
            // 
            // groupDatosTarjeta
            // 
            this.groupDatosTarjeta.Controls.Add(this.dateVencimiento);
            this.groupDatosTarjeta.Controls.Add(this.txtCodigo);
            this.groupDatosTarjeta.Controls.Add(this.lblCodigo);
            this.groupDatosTarjeta.Controls.Add(this.txtCodigoSeguridad);
            this.groupDatosTarjeta.Controls.Add(this.lblCodigoSeguridad);
            this.groupDatosTarjeta.Controls.Add(this.lblFechaVencimiento);
            this.groupDatosTarjeta.Controls.Add(this.txtNumero);
            this.groupDatosTarjeta.Controls.Add(this.lblNumero);
            this.groupDatosTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatosTarjeta.Location = new System.Drawing.Point(521, 25);
            this.groupDatosTarjeta.Name = "groupDatosTarjeta";
            this.groupDatosTarjeta.Size = new System.Drawing.Size(448, 224);
            this.groupDatosTarjeta.TabIndex = 7;
            this.groupDatosTarjeta.TabStop = false;
            this.groupDatosTarjeta.Text = "Datos Tarjeta";
            this.groupDatosTarjeta.Visible = false;
            // 
            // dateVencimiento
            // 
            this.dateVencimiento.Location = new System.Drawing.Point(222, 189);
            this.dateVencimiento.Name = "dateVencimiento";
            this.dateVencimiento.Size = new System.Drawing.Size(200, 27);
            this.dateVencimiento.TabIndex = 18;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(100, 80);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(157, 27);
            this.txtCodigo.TabIndex = 17;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 80);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 25);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(220, 135);
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(202, 27);
            this.txtCodigoSeguridad.TabIndex = 15;
            // 
            // lblCodigoSeguridad
            // 
            this.lblCodigoSeguridad.AutoSize = true;
            this.lblCodigoSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoSeguridad.Location = new System.Drawing.Point(6, 135);
            this.lblCodigoSeguridad.Name = "lblCodigoSeguridad";
            this.lblCodigoSeguridad.Size = new System.Drawing.Size(199, 25);
            this.lblCodigoSeguridad.TabIndex = 14;
            this.lblCodigoSeguridad.Text = "Código de seguridad:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(6, 187);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(209, 25);
            this.lblFechaVencimiento.TabIndex = 13;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(100, 27);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(157, 27);
            this.txtNumero.TabIndex = 12;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(6, 25);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(87, 25);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Número:";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 391);
            this.Controls.Add(this.groupDatosTarjeta);
            this.Controls.Add(this.cmbMedioDePago);
            this.Controls.Add(this.lblMedioDePago);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.txtNroEstadia);
            this.Controls.Add(this.lblNroEstadia);
            this.Controls.Add(this.label1);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.groupDatosTarjeta.ResumeLayout(false);
            this.groupDatosTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNroEstadia;
        private System.Windows.Forms.TextBox txtNroEstadia;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lblMedioDePago;
        private System.Windows.Forms.ComboBox cmbMedioDePago;
        private System.Windows.Forms.GroupBox groupDatosTarjeta;
        private System.Windows.Forms.DateTimePicker dateVencimiento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoSeguridad;
        private System.Windows.Forms.Label lblCodigoSeguridad;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
    }
}