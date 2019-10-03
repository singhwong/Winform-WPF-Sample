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
    /// <summary>
    /// addAccount.xaml 的交互逻辑
    /// </summary>
    public partial class addAccount : Window
    {
        public addAccount()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private MainWindow main_window = new MainWindow();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AddAccount()
        {
            SqlConnection sql_connection = main_window.Sqlcon();
            try
            {
                sql_connection.Open();
                string commandStr = "insert account (username,pwd,权限,备注) values " +
                    $"('{tbAccount_name.Text}','{tbAccount_pwd.Text}','{cbAccount_power.Text}'," +
                    $"'{tbAccount_remark.Text}')";
                SqlCommand sql_command = new SqlCommand(commandStr,sql_connection);
                sql_command.ExecuteNonQuery();
            }
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            finally
            {
                sql_connection.Close();
            }
        }

        private void btAccount_enter_Click(object sender, RoutedEventArgs e)
        {
            AddAccount();
            tbAccount_name.Clear();
            tbAccount_pwd.Clear();
            cbAccount_power.SelectedIndex = 0;
            tbAccount_remark.Clear();
        }
    }
}
