using System;
using System.Windows.Forms;

namespace CarRental
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создаем главную форму
            LoginForm loginForm = new LoginForm();

            // Запускаем цикл сообщений
            Application.Run(loginForm);

            // Когда форма закрывается, приложение завершается
        }
    }
}