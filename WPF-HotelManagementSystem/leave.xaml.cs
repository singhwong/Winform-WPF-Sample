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
    /// leave.xaml 的交互逻辑
    /// </summary>
    public partial class leave : Window
    {
        public leave()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        MainWindow main_window = new MainWindow();
        private void btLiveCancle_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btLeaveEnter_Click(object sender, RoutedEventArgs e)
        {
            main_window.UpdateRoomStatus(cbLeaveStatus.Text,Convert.ToInt32(tbLeaveNum.Text));
            DeleteRegisterRoom(Convert.ToInt32(tbLeaveNum.Text));
            UpdateHistoryLeaveDate();
        }
        private void DeleteRegisterRoom(int room_num)
        {
            SqlConnection sql_connection = main_window.Sqlcon();
            try
            {
                sql_connection.Open();
                string commandStr = $"delete register where 房间号='{room_num}'";
                SqlCommand sql_command = new SqlCommand(commandStr,sql_connection);
                sql_command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql_connection.Close();
            }
        }
        private void UpdateHistoryLeaveDate()
        {
            SqlConnection sql_connection = main_window.Sqlcon();
            try
            {
                sql_connection.Open();
                string commandStr = $"update registerHistory set 退房时间='{DateTime.Now}' " +
                    $"where 交易码='{tbLeaveSign.Text}'";
                SqlCommand sql_command = new SqlCommand(commandStr,sql_connection);
                sql_command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql_connection.Close();
            }
        }
    }
}
