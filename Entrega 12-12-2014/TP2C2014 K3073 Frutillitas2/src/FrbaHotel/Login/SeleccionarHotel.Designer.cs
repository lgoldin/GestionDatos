namespace FrbaHotel.Login
{
    partial class SeleccionarHotel
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
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(124, 33);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(195, 21);
            this.cmbHotel.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Hotel";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(48, 76);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(271, 35);
            this.btnSeleccionar.TabIndex = 50;
            this.btnSeleccionar.Text = "Seleccionar hotel";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // SeleccionarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 141);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.label13);
            this.Name = "SeleccionarHotel";
            this.Text = "SeleccionarHotel";
            this.Load += new System.EventHandler(this.SeleccionarHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}