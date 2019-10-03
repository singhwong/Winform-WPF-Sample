using System;
using System.Collections.Generic;
using System.Data;
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
    /// accountTable.xaml 的交互逻辑
    /// </summary>
    public partial class accountTable : Window
    {
        public accountTable()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dgvAccountTable.ItemsSource = CheckAccountValue().Tables[0].DefaultView;
        }
        private MainWindow main_window = new MainWindow();
        public DataSet CheckAccountValue()
        {
            SqlConnection sql_connection = main_window.Sqlcon();
            DataSet data_set = new DataSet();
            try
            {
                sql_connection.Open();
                string adapterStr = "select * from account";
                SqlDataAdapter sql_adapter = new SqlDataAdapter(adapterStr, sql_connection);
                sql_adapter.Fill(data_set, "account");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql_connection.Close();
            }
            return data_set;
        }
    }
}
