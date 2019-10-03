using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dtpMainStart.SelectedDate = DateTime.Now;
            dtpMainEnd.SelectedDate = DateTime.Now;
            dtpAdminStart.SelectedDate = DateTime.Now;
            dtpAdminEnd.SelectedDate = DateTime.Now;
            cbRoomLevel.SelectedIndex = 0;
            cbRoomStatus.SelectedIndex = 0;
            cbRoomType.SelectedIndex = 0;
            cbAdminLevel.SelectedIndex = 0;
            cbAdminStatus.SelectedIndex = 0;
            cbAdminType.SelectedIndex = 0;
        }
        public SqlConnection Sqlcon()
        {
            string sqlStr = "server=.;user=sa;pwd=sqlwxg;database=HotelManagementSystem";
            SqlConnection sql_connection = new SqlConnection(sqlStr);
            try
            {
                sql_connection.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql_connection.Close();
            }
            return sql_connection;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            dgvRegister.Visibility = Visibility.Visible;
            dgvRoom.Visibility = Visibility.Collapsed;
            dgvIncome.Visibility = Visibility.Collapsed;
            dgvHistory.Visibility = Visibility.Collapsed;
            if (tbMainId.Text != "")
            {
                GetRegisterValue("身份证号", tbMainId.Text, dtpMainStart.SelectedDate.Value, dtpMainEnd.SelectedDate.Value);
            }
            else if (tbMainTel.Text != "")
            {
                GetRegisterValue("联系方式", tbMainTel.Text, dtpMainStart.SelectedDate.Value, dtpMainEnd.SelectedDate.Value);
            }
            else if (tbMainNum.Text != "")
            {
                GetRegisterValue("房间号", tbMainNum.Text, dtpMainStart.SelectedDate.Value, dtpMainEnd.SelectedDate.Value);
            }
            else if (tbMainName.Text != "")
            {
                GetRegisterValue("入住人", tbMainName.Text, dtpMainStart.SelectedDate.Value, dtpMainEnd.SelectedDate.Value);
            }
            else if (tbMainId.Text == "" && tbMainName.Text == "" && tbMainTel.Text == "" & tbMainNum.Text == ""
                               && dtpMainStart.SelectedDate != DateTime.Now.Date || dtpMainEnd.SelectedDate != DateTime.Now.Date)
            {
                GetRegisterValue("", "", dtpMainStart.SelectedDate.Value, dtpMainEnd.SelectedDate.Value);
            }
            else
            {
                GetRegisterValue("", "", dtpMainStart.SelectedDate.Value, dtpMainEnd.SelectedDate.Value);
            }

        }
        private void GetRegisterValue(string columnStr, string valueStr, DateTime Start_time, DateTime End_time)
        {
            string adapterStr = "";
            SqlConnection sql_connection = Sqlcon();
            DataSet data_set = new DataSet();
            try
            {
                sql_connection.Open();
                if (tbMainId.Text == "" && tbMainName.Text == "" && tbMainTel.Text == "" & tbMainNum.Text == "")
                {
                    adapterStr = "select * from register";
                    if (dtpMainStart.SelectedDate != DateTime.Now.Date || dtpMainEnd.SelectedDate != DateTime.Now.Date)
                    {
                        adapterStr = $"select * from register where 入住时间>'{Start_time.Date}' and 入住时间<'{End_time.Date}'";
                    }
                }
                else
                {
                    adapterStr = $"select * from register where {columnStr}='{valueStr}'";
                }

                SqlDataAdapter sql_adapter = new SqlDataAdapter(adapterStr, sql_connection);
                sql_adapter.Fill(data_set, "register");
                dgvRegister.ItemsSource = data_set.Tables[0].DefaultView;
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            livein live_in = new livein();
            live_in.Show();
        }
        private void GetRoomValue(string level, string status, string type, string num, string value)//标记&&&&&&&&&&&&&&&&&&&&&&&&
        {
            string adapterStr;
            SqlConnection sql_connection = Sqlcon();
            DataSet data_set = new DataSet();
            try
            {
                sql_connection.Open();
                if (level == "Null" && status == "Null" && type == "Null" && num == "")
                {
                    adapterStr = "select * from roomTable";
                }
                else
                {
                    adapterStr = $"select * from roomTable where {value}";
                }
                SqlDataAdapter sql_adapter = new SqlDataAdapter(adapterStr, sql_connection);
                sql_adapter.Fill(data_set, "roomTable");
                dgvRoom.ItemsSource = data_set.Tables[0].DefaultView;
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dgvHistory.Visibility = Visibility.Collapsed;
            dgvRegister.Visibility = Visibility.Collapsed;
            dgvIncome.Visibility = Visibility.Collapsed;
            dgvRoom.Visibility = Visibility.Visible;
            Bool_value();
            string newvalue = "";
            //CheckRoomValue(newvalue);
            if (cbRoomLevel.SelectedIndex != 0 || cbRoomStatus.SelectedIndex != 0 || cbRoomType.SelectedIndex != 0)
            {
                GetRoomValue(cbRoomLevel.Text, cbRoomStatus.Text, cbRoomType.Text, tbRoomNum.Text,
                    CheckRoomValue(newvalue));
                level_bool = false;
                status_bool = false;
                type_bool = false;
            }

            else if (tbRoomNum.Text != "")
            {
                newvalue = "房间号" + "=" + "'" + Convert.ToInt32(tbRoomNum.Text) + "'";
                GetRoomValue(cbRoomLevel.Text, cbRoomStatus.Text, cbRoomType.Text, tbRoomNum.Text, newvalue);
            }
            else
            {
                GetRoomValue("Null", "Null", "Null", "", "");
            }

        }
        private bool level_bool = false;
        private bool status_bool = false;
        private bool type_bool = false;

        private void Bool_value()
        {
            if (cbRoomLevel.SelectedIndex != 0)
            {
                level_bool = true;
            }
            if (cbRoomStatus.SelectedIndex != 0)
            {
                status_bool = true;
            }
            if (cbRoomType.SelectedIndex != 0)
            {
                type_bool = true;
            }
        }
        private string CheckRoomValue(string value)
        {
            if (level_bool == true && status_bool == false && type_bool == false)
            {
                value = "所在楼层" + "=" + "'" + cbRoomLevel.Text + "'";
            }
            else if (level_bool == false && status_bool == true && type_bool == false)
            {
                value = "房间状态" + "=" + "'" + cbRoomStatus.Text + "'";
            }
            else if (level_bool == false && status_bool == false && type_bool == true)
            {
                value = "房间类型" + "=" + "'" + cbRoomType.Text + "'";
            }
            else if (level_bool == true && status_bool == true && type_bool == false)
            {
                value = "所在楼层" + "=" + "'" + cbRoomLevel.Text + "'" + " and " + "房间状态" + "=" + "'" + cbRoomStatus.Text + "'";
            }
            else if (level_bool == false && status_bool == true && type_bool == true)
            {
                value = "房间状态" + "=" + "'" + cbRoomStatus.Text + "'" + " and " + "房间类型" + "=" + "'" + cbRoomType.Text + "'";
            }
            else if (level_bool == true && status_bool == false && type_bool == true)
            {
                value = "所在楼层" + "=" + "'" + cbRoomLevel.Text + "'" + " and " + "房间类型" + "=" + "'" + cbRoomType.Text + "'";
            }
            else if (level_bool == true && status_bool == true && type_bool == true)
            {
                value = "所在楼层" + "=" + "'" + cbRoomLevel.Text + "'" + " and " + "房间类型" + "=" + "'" + cbRoomType.Text + "'"
                    + " and " + "房间状态" + "=" + "'" + cbRoomStatus.Text + "'";
            }
            return value;
        }
        private void btMainLeave_Click(object sender, RoutedEventArgs e)
        {
            leave new_leave = new leave();
            new_leave.Show();
        }

        private void btMainClear_Click(object sender, RoutedEventArgs e)
        {
            clear new_clear = new clear();
            new_clear.Show();
        }

        private void bt1_Copy_Click(object sender, RoutedEventArgs e)
        {
            addAccount add_account = new addAccount();
            add_account.Show();
        }

        private void bt1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            accountTable account_Table = new accountTable();
            account_Table.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            addRoom add_Room = new addRoom();
            add_Room.Show();
        }



        private void btMainResert_Click(object sender, RoutedEventArgs e)
        {
            tbMainId.Clear();
            tbMainName.Clear();
            tbMainNum.Clear();
            tbMainTel.Clear();
            dtpMainStart.SelectedDate = DateTime.Now.Date;
            dtpMainEnd.SelectedDate = DateTime.Now.Date;
        }

        private void tbMainId_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbMainName.IsEnabled = false;
            tbMainNum.IsEnabled = false;
            tbMainTel.IsEnabled = false;
            dtpMainStart.IsEnabled = false;
            dtpMainEnd.IsEnabled = false;
            if (tbMainId.Text == "")
            {
                tbMainName.IsEnabled = true;
                tbMainNum.IsEnabled = true;
                tbMainTel.IsEnabled = true;
                dtpMainStart.IsEnabled = true;
                dtpMainEnd.IsEnabled = true;
            }
        }

        private void tbMainTel_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbMainName.IsEnabled = false;
            tbMainNum.IsEnabled = false;
            tbMainId.IsEnabled = false;
            dtpMainStart.IsEnabled = false;
            dtpMainEnd.IsEnabled = false;
            if (tbMainTel.Text == "")
            {
                tbMainName.IsEnabled = true;
                tbMainNum.IsEnabled = true;
                tbMainId.IsEnabled = true;
                dtpMainStart.IsEnabled = true;
                dtpMainEnd.IsEnabled = true;
            }
        }

        private void tbMainName_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbMainId.IsEnabled = false;
            tbMainNum.IsEnabled = false;
            tbMainTel.IsEnabled = false;
            dtpMainStart.IsEnabled = false;
            dtpMainEnd.IsEnabled = false;
            if (tbMainName.Text == "")
            {
                tbMainId.IsEnabled = true;
                tbMainNum.IsEnabled = true;
                tbMainTel.IsEnabled = true;
                dtpMainStart.IsEnabled = true;
                dtpMainEnd.IsEnabled = true;
            }
        }

        private void tbMainNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbMainName.IsEnabled = false;
            tbMainId.IsEnabled = false;
            tbMainTel.IsEnabled = false;
            dtpMainStart.IsEnabled = false;
            dtpMainEnd.IsEnabled = false;
            if (tbMainNum.Text == "")
            {
                tbMainName.IsEnabled = true;
                tbMainId.IsEnabled = true;
                tbMainTel.IsEnabled = true;
                dtpMainStart.IsEnabled = true;
                dtpMainEnd.IsEnabled = true;
            }
        }
        public void UpdateRoomStatus(string status_value, int room_num)
        {
            SqlConnection sql_connection = Sqlcon();
            try
            {
                sql_connection.Open();
                string commandStr = $"update roomTable set 房间状态='{status_value}' where 房间号='{room_num}'";
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            cbRoomLevel.SelectedIndex = 0;
            cbRoomStatus.SelectedIndex = 0;
            cbRoomType.SelectedIndex = 0;
            tbRoomNum.Clear();
        }

        private void cbRoomLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            tbRoomNum.IsEnabled = false;
            if (cbRoomLevel.SelectedIndex == 0)
            {
                tbRoomNum.IsEnabled = true;
            }
        }

        private void cbRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            tbRoomNum.IsEnabled = false;
            if (cbRoomType.SelectedIndex == 0)
            {
                tbRoomNum.IsEnabled = true;
            }
        }

        private void cbRoomStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            tbRoomNum.IsEnabled = false;
            if (cbRoomStatus.SelectedIndex == 0)
            {
                tbRoomNum.IsEnabled = true;
            }
        }

        private void tbRoomNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            cbRoomStatus.IsEnabled = false;
            cbRoomType.IsEnabled = false;
            cbRoomLevel.IsEnabled = false;
            if (tbRoomNum.Text == "")
            {
                cbRoomStatus.IsEnabled = true;
                cbRoomType.IsEnabled = true;
                cbRoomLevel.IsEnabled = true;
            }
        }
        private bool Admin_levelBool = false;
        private bool Admin_statusBool = false;
        private bool Admin_typeBool = false;
        private void Admin_boolValue()
        {
            if (cbAdminLevel.SelectedIndex != 0)
            {
                Admin_levelBool = true;
            }
            if (cbAdminStatus.SelectedIndex != 0)
            {
                Admin_statusBool = true;
            }
            if (cbAdminType.SelectedIndex != 0)
            {
                Admin_typeBool = true;
            }
        }
        private string CheckAdminRoomValue(string value)
        {
            if (Admin_levelBool == true && Admin_statusBool == false && Admin_typeBool == false)
            {
                value = "所在楼层" + "=" + "'" + cbAdminLevel.Text + "'";
            }
            else if (Admin_levelBool == false && Admin_statusBool == true && Admin_typeBool == false)
            {
                value = "房间状态" + "=" + "'" + cbAdminStatus.Text + "'";
            }
            else if (Admin_levelBool == false && Admin_statusBool == false && Admin_typeBool == true)
            {
                value = "房间类型" + "=" + "'" + cbAdminType.Text + "'";
            }
            else if (Admin_levelBool == true && Admin_statusBool == true && Admin_typeBool == false)
            {
                value = "所在楼层" + "=" + "'" + cbAdminLevel.Text + "'" + " and " + "房间状态" + "=" + "'" + cbAdminStatus.Text + "'";
            }
            else if (Admin_levelBool == false && Admin_statusBool == true && Admin_typeBool == true)
            {
                value = "房间状态" + "=" + "'" + cbAdminStatus.Text + "'" + " and " + "房间类型" + "=" + "'" + cbAdminType.Text + "'";
            }
            else if (Admin_levelBool == true && Admin_statusBool == false && Admin_typeBool == true)
            {
                value = "所在楼层" + "=" + "'" + cbAdminLevel.Text + "'" + " and " + "房间类型" + "=" + "'" + cbAdminType.Text + "'";
            }
            else if (Admin_levelBool == true && Admin_statusBool == true && Admin_typeBool == true)
            {
                value = "所在楼层" + "=" + "'" + cbAdminLevel.Text + "'" + " and " + "房间类型" + "=" + "'" + cbAdminType.Text + "'"
                    + " and " + "房间状态" + "=" + "'" + cbAdminStatus.Text + "'";
            }
            return value;
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            dgvHistory.Visibility = Visibility.Collapsed;
            dgvRegister.Visibility = Visibility.Collapsed;
            dgvIncome.Visibility = Visibility.Collapsed;
            dgvRoom.Visibility = Visibility.Visible;
            Admin_boolValue();
            string admin_value = "";
            if (cbAdminLevel.SelectedIndex != 0 || cbAdminStatus.SelectedIndex != 0 || cbAdminType.SelectedIndex != 0)
            {
                GetRoomValue(cbAdminLevel.Text, cbAdminStatus.Text, cbAdminType.Text, tbAdminNum.Text,
                    CheckAdminRoomValue(admin_value));
                Admin_levelBool = false;
                Admin_statusBool = false;
                Admin_typeBool = false;
            }

            else if (tbAdminNum.Text != "")
            {
                admin_value = "房间号" + "=" + "'" + Convert.ToInt32(tbAdminNum.Text) + "'";
                GetRoomValue(cbAdminLevel.Text, cbAdminStatus.Text, cbAdminType.Text, tbAdminNum.Text, admin_value);
            }
            else
            {
                GetRoomValue("Null", "Null", "Null", "", "");
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            cbAdminLevel.SelectedIndex = 0;
            cbAdminStatus.SelectedIndex = 0;
            cbAdminType.SelectedIndex = 0;
            tbAdminNum.Clear();
        }

        private void cbAdminStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbAdminNum.IsEnabled = false;
            if (cbAdminStatus.SelectedIndex==0)
            {
                tbAdminNum.IsEnabled = true;
            }
        }

        private void cbAdminLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbAdminNum.IsEnabled = false;
            if (cbAdminLevel.SelectedIndex == 0)
            {
                tbAdminNum.IsEnabled = true;
            }
        }

        private void cbAdminType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbAdminNum.IsEnabled = false;
            if (cbAdminType.SelectedIndex == 0)
            {
                tbAdminNum.IsEnabled = true;
            }
        }

        private void tbAdminNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            cbAdminLevel.IsEnabled = false;
            cbAdminStatus.IsEnabled = false;
            cbAdminType.IsEnabled = false;
            if (tbAdminNum.Text=="")
            {
                cbAdminLevel.IsEnabled = true;
                cbAdminStatus.IsEnabled = true;
                cbAdminType.IsEnabled = true;
            }
        }
       private DataSet CheckIncome(DateTime start_time,DateTime end_time)
        {
            SqlConnection sql_connection = Sqlcon();
            DataSet data_set = new DataSet();
            string adapterStr = "";
            try
            {
                sql_connection.Open();
                if (start_time.Date!=DateTime.Now.Date||end_time.Date!=DateTime.Now.Date)
                {
                    adapterStr = $"select * from money where 收入时间>'{start_time.Date}' and " +
                        $"收入时间<'{end_time.Date}'";
                }
                else
                {
                    adapterStr = "select * from money";
                }
                SqlDataAdapter sql_adapter = new SqlDataAdapter(adapterStr,sql_connection);
                sql_adapter.Fill(data_set,"money");
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

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {     
            dgvRoom.Visibility = Visibility.Collapsed;
            dgvRegister.Visibility = Visibility.Collapsed;
            dgvHistory.Visibility = Visibility.Collapsed;
            dgvIncome.Visibility = Visibility.Visible;
            dgvIncome.ItemsSource = CheckIncome(dtpAdminStart.SelectedDate.Value, dtpAdminEnd.SelectedDate.Value).Tables[0].DefaultView;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            dtpAdminStart.SelectedDate = DateTime.Now;
            dtpAdminEnd.SelectedDate = DateTime.Now;
        }

        private void btHistoryCheck_Click(object sender, RoutedEventArgs e)
        {
            dgvIncome.Visibility = Visibility.Collapsed;
            dgvRoom.Visibility = Visibility.Collapsed;
            dgvRegister.Visibility = Visibility.Collapsed;
            dgvHistory.Visibility = Visibility.Visible;
           
            if (tbHistoryName.Text!="")
            {
                CheckHistoryRegisterValue("入住人",tbHistoryName.Text);
            }
            else if (tbHistoryNum.Text!="")
            {
                CheckHistoryRegisterValue("房间号", tbHistoryNum.Text);
            }
            else if (tbHistoryTel.Text!="")
            {
                CheckHistoryRegisterValue("联系方式", tbHistoryTel.Text);
            }
            else if (tbHistoryId.Text!="")
            {
                CheckHistoryRegisterValue("身份证号", tbHistoryId.Text);
            }
            else
            {
                CheckHistoryRegisterValue("","");
            }
        }
        private void CheckHistoryRegisterValue(string columnStr,string value)
        {
            SqlConnection sql_connection = Sqlcon();
            DataSet data_set = new DataSet();
            string adapterStr;
            try
            {
                sql_connection.Open();
                if (tbHistoryName.Text==""&&tbHistoryNum.Text==""&&tbHistoryTel.Text==""&&tbHistoryId.Text=="")
                {
                    adapterStr = "select * from registerHistory";
                }
                else
                {
                    adapterStr = $"select * from registerHistory where {columnStr}='{value}'";
                }
                SqlDataAdapter sql_adapter = new SqlDataAdapter(adapterStr,sql_connection);
                sql_adapter.Fill(data_set,"registerHistory");
                dgvHistory.ItemsSource = data_set.Tables[0].DefaultView;
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

        private void btHistoryResert_Click(object sender, RoutedEventArgs e)
        {
            tbHistoryName.Clear();
            tbHistoryNum.Clear();
            tbHistoryTel.Clear();
            tbHistoryId.Clear();
        }

        private void tbHistoryId_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbHistoryName.IsEnabled = false;
            tbHistoryNum.IsEnabled = false;
            tbHistoryTel.IsEnabled = false;
            if (tbHistoryId.Text=="")
            {
                tbHistoryName.IsEnabled = true;
                tbHistoryNum.IsEnabled = true;
                tbHistoryTel.IsEnabled = true;
            }
        }

        private void tbHistoryName_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbHistoryId.IsEnabled = false;
            tbHistoryNum.IsEnabled = false;
            tbHistoryTel.IsEnabled = false;
            if (tbHistoryName.Text == "")
            {
                tbHistoryId.IsEnabled = true;
                tbHistoryNum.IsEnabled = true;
                tbHistoryTel.IsEnabled = true;
            }
        }

        private void tbHistoryTel_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbHistoryId.IsEnabled = false;
            tbHistoryNum.IsEnabled = false;
            tbHistoryName.IsEnabled = false;
            if (tbHistoryTel.Text == "")
            {
                tbHistoryId.IsEnabled = true;
                tbHistoryNum.IsEnabled = true;
                tbHistoryName.IsEnabled = true;
            }
        }

        private void tbHistoryNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbHistoryId.IsEnabled = false;
            tbHistoryName.IsEnabled = false;
            tbHistoryTel.IsEnabled = false;
            if (tbHistoryNum.Text == "")
            {
                tbHistoryId.IsEnabled = true;
                tbHistoryName.IsEnabled = true;
                tbHistoryTel.IsEnabled = true;
            }
        }
        private void UpdateRoomValue(string columns,int num)
        {
            SqlConnection sql_connection = Sqlcon();
            try
            {
                sql_connection.Open();
                string updateStr = $"update roomTable set {columns} where 房间号='{num}'";
                SqlCommand sql_command = new SqlCommand(updateStr,sql_connection);
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

        private void dgvRoom_CurrentCellChanged(object sender, EventArgs e)
        {
            //string columns = dgvRoom.CurrentColumn.Header.ToString() + "=" +
            //    dgvRoom.CurrentCell.Item.ToString();
            //int id=dgvRoom.CurrentCell.Rows
        }
    }
}
