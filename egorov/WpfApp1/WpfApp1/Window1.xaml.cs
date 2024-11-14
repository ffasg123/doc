using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;



namespace WpfApp1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connection = "data source=stud-mssql.sttec.yar.ru,38325;user id=user260_db;password=user260;MultipleActiveResultSets=True;App=EntityFramework";
            string command = "SELECT login, password FROM 3110Сотрудники WHERE login='" + TxtLogin.Text + "'and password='" + TxtPassword.Text + "'";

            string login = "";
            string password = "";

            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                login = sqlDataReader.GetString(0);
                password = sqlDataReader.GetString(1);

            }
            if ((login == TxtLogin.Text) && (password == TxtPassword.Text))
            {
                MessageBox.Show("Успешный вход!");
                Window3 form4 = new Window3();
                form4.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль или логин");
            }
        }

        private bool ValidateUser(string login, string password)
        {
            // Здесь можно реализовать логику для проверки логина и пароля с вашей базой данных
            // Для примера, используем простую проверку
            return login == "admin" && password == "1234"; // Пример логина и пароля
        }

        private void TxtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
