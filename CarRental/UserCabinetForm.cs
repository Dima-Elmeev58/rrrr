using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserCabinetForm : Form
    {
        private User currentUser;
        private DatabaseHelper dbHelper;

        public UserCabinetForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            dbHelper = new DatabaseHelper();
            LoadUserData();
            LoadCars();
        }

        private void LoadUserData()
        {
            lblFullName.Text = $"{currentUser.LastName} {currentUser.FirstName} {currentUser.MiddleName}";
            lblPhone.Text = currentUser.Phone;
        }

        private void LoadCars()
        {
            string query = "SELECT * FROM Cars WHERE Available = True";
            DataTable dt = dbHelper.ExecuteQuery(query);
            cmbCars.DataSource = dt;
            cmbCars.DisplayMember = "Brand";
            cmbCars.ValueMember = "ID";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbCars.SelectedItem == null || string.IsNullOrEmpty(txtDays.Text))
            {
                MessageBox.Show("Выберите автомобиль и укажите количество дней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtDays.Text, out int days) || days <= 0)
            {
                MessageBox.Show("Введите корректное количество дней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRowView selectedCar = (DataRowView)cmbCars.SelectedItem;
            decimal dailyPrice = Convert.ToDecimal(selectedCar["DailyPrice"]);
            decimal totalPrice = dailyPrice * days;

            lblTotalPrice.Text = $"Итого: {totalPrice:C2}";
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Проверка выбранного автомобиля
                if (cmbCars.SelectedItem == null)
                {
                    MessageBox.Show("Выберите автомобиль из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Проверка количества дней
                if (string.IsNullOrWhiteSpace(txtDays.Text) || !int.TryParse(txtDays.Text, out int days) || days <= 0)
                {
                    MessageBox.Show("Введите корректное количество дней (целое число больше 0)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Проверка текущего пользователя
                if (currentUser == null)
                {
                    MessageBox.Show("Ошибка авторизации. Пожалуйста, войдите снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // 4. Проверка dbHelper
                if (dbHelper == null)
                {
                    dbHelper = new DatabaseHelper();
                }

                // 5. Получаем данные выбранного автомобиля
                DataRowView selectedCar = cmbCars.SelectedItem as DataRowView;
                if (selectedCar == null)
                {
                    MessageBox.Show("Ошибка при выборе автомобиля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int carId = Convert.ToInt32(selectedCar["ID"]);
                decimal dailyPrice = Convert.ToDecimal(selectedCar["DailyPrice"]);
                decimal totalPrice = dailyPrice * days;

                // 6. Параметризованный запрос
                string insertQuery = @"INSERT INTO Rentals 
                            (UserID, CarID, StartDate, EndDate, TotalPrice) 
                            VALUES 
                            (@UserID, @CarID, @StartDate, @EndDate, @TotalPrice)";

                var parameters = new OleDbParameter[]
                {
            new OleDbParameter("@UserID", currentUser.Id),
            new OleDbParameter("@CarID", carId),
            new OleDbParameter("@StartDate", DateTime.Today),
            new OleDbParameter("@EndDate", DateTime.Today.AddDays(days)),
            new OleDbParameter("@TotalPrice", totalPrice)
                };

                // 7. Выполнение запроса
                int rowsAffected = dbHelper.ExecuteParametrizedQuery(insertQuery, parameters);

                if (rowsAffected > 0)
                {
                    // Обновляем доступность автомобиля
                    string updateQuery = "UPDATE Cars SET Available = False WHERE ID = @CarID";
                    dbHelper.ExecuteParametrizedQuery(updateQuery,
                        new OleDbParameter("@CarID", carId));

                    MessageBox.Show("Автомобиль успешно арендован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCars();
                    lblTotalPrice.Text = "Итого: 0.00";
                    txtDays.Clear();
                }
                else
                {
                    MessageBox.Show("Не удалось оформить аренду", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при аренде автомобиля: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Закрываем текущую форму
            this.Close();

            // Показываем форму авторизации
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void UserCabinetForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {

        }
    }
}