namespace CarRental
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            lblLogin = new Label();
            lblPassword = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblMiddleName = new Label();
            lblPhone = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtPhone = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(40, 47);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(55, 20);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 92);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(65, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Пароль:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(40, 139);
            lblLastName.Margin = new Padding(5, 0, 5, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(76, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Фамилия:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(40, 184);
            lblFirstName.Margin = new Padding(5, 0, 5, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(42, 20);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "Имя:";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(40, 231);
            lblMiddleName.Margin = new Padding(5, 0, 5, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(75, 20);
            lblMiddleName.TabIndex = 4;
            lblMiddleName.Text = "Отчество:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(40, 277);
            lblPhone.Margin = new Padding(5, 0, 5, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(72, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Телефон:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(134, 41);
            txtLogin.Margin = new Padding(5, 4, 5, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(198, 27);
            txtLogin.TabIndex = 6;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(134, 88);
            txtPassword.Margin = new Padding(5, 4, 5, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(134, 133);
            txtLastName.Margin = new Padding(5, 4, 5, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(198, 27);
            txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(134, 180);
            txtFirstName.Margin = new Padding(5, 4, 5, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(198, 27);
            txtFirstName.TabIndex = 9;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(134, 227);
            txtMiddleName.Margin = new Padding(5, 4, 5, 4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(198, 27);
            txtMiddleName.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(134, 272);
            txtPhone.Margin = new Padding(5, 4, 5, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(198, 27);
            txtPhone.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(134, 333);
            btnRegister.Margin = new Padding(5, 4, 5, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(134, 47);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(378, 401);
            Controls.Add(btnRegister);
            Controls.Add(txtPhone);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblPhone);
            Controls.Add(lblMiddleName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRegister;
    }
}