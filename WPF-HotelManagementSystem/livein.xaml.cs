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
    /// livein.xaml 的交互逻辑
    /// </summary>
    public partial class livein : Window
    {
        public livein()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private MainWindow main_window = new MainWindow();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddRetister();
            AddRegisterHistory();
            tbLiveInNum.Clear();
            cbLiveInType.SelectedIndex = 0;
            tbLiveInName.Clear();
            tbLiveInId.Clear();
            tbLiveInTel.Clear();
            tbLiveInSign.Clear();
            tbLiveInIncome.Clear();
            cbLiveInStatus.SelectedIndex = 0;
            tbLiveInRemark.Clear();
        }
        private void AddRetister()
        {
            SqlConnection sql_connection = main_window.Sqlcon();
            try
            {
                sql_connection.Open();
                string commandStr = "insert register (房间号,房间类型,入住人,身份证号,联系方式,交易码,实收,房间状态,入住时间,备注)values" +
               $"('{Convert.ToInt32(tbLiveInNum.Text)}','{cbLiveInType.Text}','{tbLiveInName.Text}','{tbLiveInId.Text}'," +
               $"'{tbLiveInTel.Text}','{tbLiveInSign.Text}','{Convert.ToDecimal(tbLiveInIncome.Text)}'," +
               $"'{cbLiveInStatus.Text}','{DateTime.Now}','{tbLiveInRemark.Text}')";
                SqlCommand sql_command = new SqlCommand(commandStr, sql_connection);
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
        private void AddRegisterHistory()
        {
            SqlConnection sql_connection = main_window.Sqlcon();
            try
            {
                sql_connection.Open();
                string commandStr = "insert registerHistory (房间号,房间类型,入住人,身份证号," +
                    "联系方式,交易码,实收,入住时间,备注) values " +
                    $"('{Convert.ToInt32(tbLiveInNum.Text)}','{cbLiveInType.Text}','{tbLiveInName.Text}'," +
                    $"'{tbLiveInId.Text}','{tbLiveInTel.Text}','{tbLiveInSign.Text}','{Convert.ToDecimal(tbLiveInIncome.Text)}'," +
                    $"'{DateTime.Now}','{tbLiveInRemark.Text}')";
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
        private void SetIncome()
        {
            SqlConnection sql_connection = main_window.Sqlcon();
            try
            {
                sql_connection.Open();
                string commandStr = "insert money (收入金额,收入时间,房间号,入住人,身份证号,联系方式,备注) values" +
                $"('{Convert.ToDecimal(tbLiveInRemark.Text)}','{DateTime.Now}','{Convert.ToInt32(tbLiveInNum.Text)}'," +
                $"'{tbLiveInName.Text}'.'{tbLiveInId.Text}','{tbLiveInTel.Text}','{tbLiveInRemark.Text}')";
                SqlCommand sql_command = new SqlCommand(commandStr, sql_connection);
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
