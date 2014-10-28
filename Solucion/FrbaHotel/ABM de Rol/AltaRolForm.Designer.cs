namespace FrbaHotel.ABM_de_Rol
{
    partial class frmAltaRol
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.lstFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(24, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(74, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alta-Rol";
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRol.Location = new System.Drawing.Point(24, 53);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(122, 20);
            this.lblNombreRol.TabIndex = 1;
            this.lblNombreRol.Text = "Nombre del Rol:";
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionalidades.Location = new System.Drawing.Point(24, 119);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(129, 20);
            this.lblFuncionalidades.TabIndex = 3;
            this.lblFuncionalidades.Text = "Funcionalidades:";
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbActivo.Location = new System.Drawing.Point(28, 85);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(71, 24);
            this.chbActivo.TabIndex = 4;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // lstFuncionalidades
            // 
            this.lstFuncionalidades.FormattingEnabled = true;
            this.lstFuncionalidades.Location = new System.Drawing.Point(28, 151);
            this.lstFuncionalidades.Name = "lstFuncionalidades";
            this.lstFuncionalidades.Size = new System.Drawing.Size(120, 94);
            this.lstFuncionalidades.TabIndex = 5;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(157, 53);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRol.TabIndex = 6;
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRol.Location = new System.Drawing.Point(28, 275);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(118, 31);
            this.btnAgregarRol.TabIndex = 7;
            this.btnAgregarRol.Text = "Crear Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // frmAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 353);
            this.Controls.Add(this.btnAgregarRol);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.lstFuncionalidades);
            this.Controls.Add(this.chbActivo);
            this.Controls.Add(this.lblFuncionalidades);
            this.Controls.Add(this.lblNombreRol);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaRol";
            this.Text = "Alta_Rol";
            this.Load += new System.EventHandler(this.frmAltaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.Label lblFuncionalidades;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.CheckedListBox lstFuncionalidades;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Button btnAgregarRol;
    }
}