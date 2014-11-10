namespace FrbaHotel
{
    partial class Index
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
            this.btnUsuarioForm = new System.Windows.Forms.Button();
            this.btnRolForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuarioForm
            // 
            this.btnUsuarioForm.Location = new System.Drawing.Point(55, 21);
            this.btnUsuarioForm.Name = "btnUsuarioForm";
            this.btnUsuarioForm.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarioForm.TabIndex = 0;
            this.btnUsuarioForm.Text = "UsuarioForm";
            this.btnUsuarioForm.UseVisualStyleBackColor = true;
            this.btnUsuarioForm.Click += new System.EventHandler(this.btnUsuarioForm_Click);
            // 
            // btnRolForm
            // 
            this.btnRolForm.Location = new System.Drawing.Point(55, 94);
            this.btnRolForm.Name = "btnRolForm";
            this.btnRolForm.Size = new System.Drawing.Size(75, 23);
            this.btnRolForm.TabIndex = 1;
            this.btnRolForm.Text = "RolForm";
            this.btnRolForm.UseVisualStyleBackColor = true;
            this.btnRolForm.Click += new System.EventHandler(this.btnRolForm_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnRolForm);
            this.Controls.Add(this.btnUsuarioForm);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarioForm;
        private System.Windows.Forms.Button btnRolForm;

    }
}

