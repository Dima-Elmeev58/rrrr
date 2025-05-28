namespace CarRental
{
    partial class UserCabinetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCabinetForm));
            lblUserInfo = new Label();
            lblFullName = new Label();
            lblPhoneLabel = new Label();
            lblPhone = new Label();
            groupBox1 = new GroupBox();
            btnRent = new Button();
            lblTotalPrice = new Label();
            btnCalculate = new Button();
            txtDays = new TextBox();
            lblDays = new Label();
            cmbCars = new ComboBox();
            lblCar = new Label();
            btnLogout = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblUserInfo.Location = new Point(26, 31);
            lblUserInfo.Margin = new Padding(5, 0, 5, 0);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(161, 20);
            lblUserInfo.TabIndex = 0;
            lblUserInfo.Text = "Личный кабинет";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(26, 77);
            lblFullName.Margin = new Padding(5, 0, 5, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(0, 20);
            lblFullName.TabIndex = 1;
            // 
            // lblPhoneLabel
            // 
            lblPhoneLabel.AutoSize = true;
            lblPhoneLabel.Location = new Point(26, 123);
            lblPhoneLabel.Margin = new Padding(5, 0, 5, 0);
            lblPhoneLabel.Name = "lblPhoneLabel";
            lblPhoneLabel.Size = new Size(72, 20);
            lblPhoneLabel.TabIndex = 2;
            lblPhoneLabel.Text = "Телефон:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(120, 123);
            lblPhone.Margin = new Padding(5, 0, 5, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 20);
            lblPhone.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRent);
            groupBox1.Controls.Add(lblTotalPrice);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(txtDays);
            groupBox1.Controls.Add(lblDays);
            groupBox1.Controls.Add(cmbCars);
            groupBox1.Controls.Add(lblCar);
            groupBox1.Location = new Point(26, 184);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(466, 308);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Аренда автомобиля";
            // 
            // btnRent
            // 
            btnRent.Location = new Point(240, 169);
            btnRent.Margin = new Padding(5, 4, 5, 4);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(160, 47);
            btnRent.TabIndex = 6;
            btnRent.Text = "Арендовать";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalPrice.Location = new Point(26, 247);
            lblTotalPrice.Margin = new Padding(5, 0, 5, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(110, 20);
            lblTotalPrice.TabIndex = 5;
            lblTotalPrice.Text = "Итого: 0.00";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(26, 169);
            btnCalculate.Margin = new Padding(5, 4, 5, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(160, 47);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Рассчитать стоимость";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtDays
            // 
            txtDays.Location = new Point(174, 103);
            txtDays.Margin = new Padding(5, 4, 5, 4);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(66, 27);
            txtDays.TabIndex = 3;
            txtDays.TextChanged += txtDays_TextChanged;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(26, 108);
            lblDays.Margin = new Padding(5, 0, 5, 0);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(131, 20);
            lblDays.TabIndex = 2;
            lblDays.Text = "Количество дней:";
            // 
            // cmbCars
            // 
            cmbCars.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(134, 41);
            cmbCars.Margin = new Padding(5, 4, 5, 4);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(266, 28);
            cmbCars.TabIndex = 1;
            cmbCars.SelectedIndexChanged += cmbCars_SelectedIndexChanged;
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(26, 47);
            lblCar.Margin = new Padding(5, 0, 5, 0);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(99, 20);
            lblCar.TabIndex = 0;
            lblCar.Text = "Автомобиль:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(360, 31);
            btnLogout.Margin = new Padding(5, 4, 5, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(134, 47);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // UserCabinetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(534, 539);
            Controls.Add(btnLogout);
            Controls.Add(groupBox1);
            Controls.Add(lblPhone);
            Controls.Add(lblPhoneLabel);
            Controls.Add(lblFullName);
            Controls.Add(lblUserInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserCabinetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Личный кабинет";
            Load += UserCabinetForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Button btnLogout;
    }
}