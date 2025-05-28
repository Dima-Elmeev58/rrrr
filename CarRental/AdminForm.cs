﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;

namespace CarRental
{
    public partial class AdminForm : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable currentDataTable;

        public AdminForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadTables();
        }

        private void LoadTables()
        {
            cmbTables.Items.AddRange(new object[] { "Users", "Cars", "Rentals" });
            cmbTables.SelectedIndex = 0;
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem == null) return;

            string tableName = cmbTables.SelectedItem.ToString();
            try
            {
                string query = $"SELECT * FROM [{tableName}]";
                currentDataTable = dbHelper.ExecuteQuery(query);
                dataGridView.DataSource = currentDataTable;
                dataGridView.Columns["ID"].ReadOnly = true; // Запрещаем редактирование ID
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки таблицы: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentDataTable == null) return;

            DataRow newRow = currentDataTable.NewRow();
            currentDataTable.Rows.Add(newRow);
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.RowCount - 1].Cells[1];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null || currentDataTable == null) return;

            try
            {
                int rowIndex = dataGridView.CurrentRow.Index;
                DataRow row = ((DataRowView)dataGridView.CurrentRow.DataBoundItem).Row;
                row.Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem == null || currentDataTable == null) return;

            string tableName = cmbTables.SelectedItem.ToString();

            try
            {
                using (OleDbConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    // Создаем адаптер с базовым запросом
                    OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM [{tableName}] WHERE 1=0", conn);

                    // Генерируем команды автоматически
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                    builder.QuotePrefix = "[";
                    builder.QuoteSuffix = "]";

                    // Назначаем сгенерированные команды
                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();

                    // Включаем логирование для отладки
                    Debug.WriteLine("Insert Command: " + adapter.InsertCommand.CommandText);
                    Debug.WriteLine("Update Command: " + adapter.UpdateCommand.CommandText);
                    Debug.WriteLine("Delete Command: " + adapter.DeleteCommand.CommandText);

                    // Выполняем обновление
                    int rowsAffected = adapter.Update(currentDataTable);

                    MessageBox.Show($"Сохранено изменений: {rowsAffected}", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Обновляем данные
                    cmbTables_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}\n\nПроверьте данные и повторите попытку.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}