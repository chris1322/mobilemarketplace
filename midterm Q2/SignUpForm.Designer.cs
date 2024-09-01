namespace midterm_Q2
{
    partial class SignUpForm
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
            this.schkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.stxtCPassword = new System.Windows.Forms.TextBox();
            this.sCPassword = new System.Windows.Forms.Label();
            this.stxtUsername = new System.Windows.Forms.TextBox();
            this.sUsername = new System.Windows.Forms.Label();
            this.stxtPassword = new System.Windows.Forms.TextBox();
            this.sPassword = new System.Windows.Forms.Label();
            this.stxtEmail = new System.Windows.Forms.TextBox();
            this.sEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // schkShowPassword
            // 
            this.schkShowPassword.AutoSize = true;
            this.schkShowPassword.Location = new System.Drawing.Point(311, 199);
            this.schkShowPassword.Name = "schkShowPassword";
            this.schkShowPassword.Size = new System.Drawing.Size(125, 20);
            this.schkShowPassword.TabIndex = 12;
            this.schkShowPassword.Text = "Show Password";
            this.schkShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(418, 296);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // stxtCPassword
            // 
            this.stxtCPassword.Location = new System.Drawing.Point(311, 171);
            this.stxtCPassword.Name = "stxtCPassword";
            this.stxtCPassword.PasswordChar = '*';
            this.stxtCPassword.Size = new System.Drawing.Size(182, 22);
            this.stxtCPassword.TabIndex = 10;
            // 
            // sCPassword
            // 
            this.sCPassword.AutoSize = true;
            this.sCPassword.Location = new System.Drawing.Point(308, 152);
            this.sCPassword.Name = "sCPassword";
            this.sCPassword.Size = new System.Drawing.Size(115, 16);
            this.sCPassword.TabIndex = 9;
            this.sCPassword.Text = "Confirm Password";
            // 
            // stxtUsername
            // 
            this.stxtUsername.Location = new System.Drawing.Point(311, 64);
            this.stxtUsername.Name = "stxtUsername";
            this.stxtUsername.Size = new System.Drawing.Size(182, 22);
            this.stxtUsername.TabIndex = 8;
            // 
            // sUsername
            // 
            this.sUsername.AutoSize = true;
            this.sUsername.Location = new System.Drawing.Point(308, 45);
            this.sUsername.Name = "sUsername";
            this.sUsername.Size = new System.Drawing.Size(70, 16);
            this.sUsername.TabIndex = 7;
            this.sUsername.Text = "Username";
            // 
            // stxtPassword
            // 
            this.stxtPassword.Location = new System.Drawing.Point(311, 117);
            this.stxtPassword.Name = "stxtPassword";
            this.stxtPassword.PasswordChar = '*';
            this.stxtPassword.Size = new System.Drawing.Size(182, 22);
            this.stxtPassword.TabIndex = 14;
            // 
            // sPassword
            // 
            this.sPassword.AutoSize = true;
            this.sPassword.Location = new System.Drawing.Point(308, 98);
            this.sPassword.Name = "sPassword";
            this.sPassword.Size = new System.Drawing.Size(67, 16);
            this.sPassword.TabIndex = 13;
            this.sPassword.Text = "Password";
            // 
            // stxtEmail
            // 
            this.stxtEmail.Location = new System.Drawing.Point(311, 248);
            this.stxtEmail.Name = "stxtEmail";
            this.stxtEmail.Size = new System.Drawing.Size(182, 22);
            this.stxtEmail.TabIndex = 16;
            // 
            // sEmail
            // 
            this.sEmail.AutoSize = true;
            this.sEmail.Location = new System.Drawing.Point(308, 229);
            this.sEmail.Name = "sEmail";
            this.sEmail.Size = new System.Drawing.Size(41, 16);
            this.sEmail.TabIndex = 15;
            this.sEmail.Text = "Email";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stxtEmail);
            this.Controls.Add(this.sEmail);
            this.Controls.Add(this.stxtPassword);
            this.Controls.Add(this.sPassword);
            this.Controls.Add(this.schkShowPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.stxtCPassword);
            this.Controls.Add(this.sCPassword);
            this.Controls.Add(this.stxtUsername);
            this.Controls.Add(this.sUsername);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox schkShowPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox stxtCPassword;
        private System.Windows.Forms.Label sCPassword;
        private System.Windows.Forms.TextBox stxtUsername;
        private System.Windows.Forms.Label sUsername;
        private System.Windows.Forms.TextBox stxtPassword;
        private System.Windows.Forms.Label sPassword;
        private System.Windows.Forms.TextBox stxtEmail;
        private System.Windows.Forms.Label sEmail;
    }
}