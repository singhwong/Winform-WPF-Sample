using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class leave : Form
    {
        public leave()
        {
            InitializeComponent();
        }
        MainForm mainform = new MainForm();
        Sqlcon sqlcon = new Sqlcon();
        SqlConnection sql_connection;
        SqlCommand sql_command;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mainform.UpdateStatus(cbLeaveStatus.Text, tbLeaveNum.Text);
               
                DeleteLivein("register", "房间号", Convert.ToInt32(tbLeaveNum.Text));
            }
            catch
            {
                MessageBox.Show("房间号输入格式有误，请重新输入","错误提示");

            }
            UpdateHistory();
            tbLeaveNum.Clear();
            cbLeaveStatus.SelectedIndex = 0;
            tbLeaveNum.Clear();
            tbLeaveNum.Focus();
            tbLeaveTrad.Clear();
            cbLeaveStatus.SelectedIndex = 0;

        }
        public void UpdateHistory()
        {
            sql_connection = sqlcon.Sql_connection();
            try
            {
                sql_connection.Open();
                string commandStr = $"update registerHistory set 退房时间='{DateTime.Now}' where 交易码='{tbLeaveTrad.Text}'";
                sql_command = new SqlCommand(commandStr, sql_connection);
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
        private void btLeaveCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DeleteLivein(string tableStr, string column, int num)
        {

            sql_connection = sqlcon.Sql_connection();
            try
            {
                sql_connection.Open();
                string commandStr = $"delete  {tableStr} where {column}='{num}'";
                sql_command = new SqlCommand(commandStr, sql_connection);
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
