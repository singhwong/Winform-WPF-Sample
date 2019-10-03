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
    /// addRoom.xaml 的交互逻辑
    /// </summary>
    public partial class addRoom : Window
    {
        public addRoom()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        MainWindow main_window = new MainWindow();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AddRoom()
        {
            SqlConnection sql_connection = main_window.Sqlcon();
            try
            {
                sql_connection.Open();
                string commandStr = "insert roomTable (房间号,房间类型,所在楼层,价格,房间状态,备注) values" +
                    $"('{tbAddroomNum.Text}','{cbAddroomType.Text}','{cbAddroomLevel.Text}'," +
                    $"'{tbAddroomPrice.Text}','{cbAddroomStatus.Text}','{tbAddroomRemark.Text}')";
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

        private void btAddroomEnter_Click(object sender, RoutedEventArgs e)
        {
            AddRoom();
        }
       
    }
}
