namespace FrbaHotel.Login
{
    partial class LoginForm
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
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.ButtonIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(211, 35);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(224, 20);
            this.TextBoxUsername.TabIndex = 0;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(211, 84);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(224, 20);
            this.TextBoxPassword.TabIndex = 2;
            // 
            // ButtonIngresar
            // 
            this.ButtonIngresar.Location = new System.Drawing.Point(12, 146);
            this.ButtonIngresar.Name = "ButtonIngresar";
            this.ButtonIngresar.Size = new System.Drawing.Size(601, 72);
            this.ButtonIngresar.TabIndex = 3;
            this.ButtonIngresar.Text = "Ingresar";
            this.ButtonIngresar.UseVisualStyleBackColor = true;
            this.ButtonIngresar.Click += new System.EventHandler(this.ButtonIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(12, 224);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(601, 72);
            this.btnGuest.TabIndex = 7;
            this.btnGuest.Text = "Ingresar como invitado";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 308);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonIngresar);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Name = "LoginForm";
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.MaskedTextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuest;
    }
}