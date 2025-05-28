using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarRental
{
    public partial class RegistrationForm : Form
    {
        private DatabaseHelper dbHelper;

        public RegistrationForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // Проверка обязательных полей
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Заполните все обязательные поля (логин, пароль, фамилию и имя)");
                return;
            }

            try
            {
                // 1. Проверка существования логина
                string checkQuery = "SELECT COUNT(*) FROM [Users] WHERE [Login] = ?";
                int userCount = Convert.ToInt32(dbHelper.ExecuteScalarWithParams(checkQuery,
                    new OleDbParameter("@Login", OleDbType.VarWChar) { Value = login }));

                if (userCount > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                    return;
                }

                // 2. Регистрация нового пользователя
                string insertQuery = @"INSERT INTO [Users] 
                            ([Login], [Password], [LastName], [FirstName], [MiddleName], [Phone]) 
                            VALUES 
                            (?, ?, ?, ?, ?, ?)";

                int rowsAffected = dbHelper.ExecuteParametrizedQuery(insertQuery,
                    new OleDbParameter("@Login", OleDbType.VarWChar) { Value = login },
                    new OleDbParameter("@Password", OleDbType.VarWChar) { Value = password },
                    new OleDbParameter("@LastName", OleDbType.VarWChar) { Value = lastName },
                    new OleDbParameter("@FirstName", OleDbType.VarWChar) { Value = firstName },
                    new OleDbParameter("@MiddleName", OleDbType.VarWChar) { Value = middleName },
                    new OleDbParameter("@Phone", OleDbType.VarWChar) { Value = phone });

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Регистрация прошла успешно!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось зарегистрировать пользователя");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}");
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Для формы регистрации просто закрываем ее,
                // не завершая приложение, так как она модальная
                if (this.DialogResult == DialogResult.None)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}