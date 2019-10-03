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
    public partial class liveIn : Form
    {
        public liveIn()
        {
            InitializeComponent();
        }
        MainForm mainform = new MainForm();
        Sqlcon sqlcon = new Sqlcon();
        private void AddLive(string tableStr)
        {
            SqlConnection sql_connection = sqlcon.Sql_connection();
            DataSet data_set = new DataSet();
            string commandStr = "";
            try
            {
                sql_connection.Open();
                if (tableStr == "register")
                {
                    commandStr = $"insert {tableStr} (房间号,房间类型,入住人,身份证号,联系方式,交易码,实收,房间状态,入住时间,备注) values " +
                    $"('{Convert.ToInt32(tbLiveNum.Text)}','{cbLiveType.Text}','{tbLiveName.Text}','{tbLiveId.Text}','{tbLiveTel.Text}'," +
                    $"'{tbTrad.Text}','{Convert.ToDecimal(tbLiveIncome.Text)}','{cbLiveStatus.Text}','{DateTime.Now}','{tbLiveRemark.Text}')";
                }
                else if (tableStr == "registerHistory")
                {
                    commandStr = $"insert {tableStr} (房间号,房间类型,入住人,身份证号,联系方式,交易码,实收,入住时间,备注) values " +
                    $"('{Convert.ToInt32(tbLiveNum.Text)}','{cbLiveType.Text}','{tbLiveName.Text}','{tbLiveId.Text}','{tbLiveTel.Text}'," +
                    $"'{tbTrad.Text}','{Convert.ToDecimal(tbLiveIncome.Text)}','{DateTime.Now}','{tbLiveRemark.Text}')";
                }
                SqlCommand sql_command = new SqlCommand(commandStr, sql_connection);
                sql_command.ExecuteNonQuery();
            }
            finally
            {
                sql_connection.Close();
            }

        }

        private void btLiveEnter_Click(object sender, EventArgs e)
        {
            try
            {
                AddLive("register");
                AddLive("registerHistory");
                mainform.UpdateStatus(cbLiveStatus.Text, tbLiveNum.Text);
                mainform.GetMoney(Convert.ToDecimal(tbLiveIncome.Text), DateTime.Now, Convert.ToInt32(tbLiveNum.Text), tbLiveName.Text,
                    tbLiveId.Text, tbLiveTel.Text, tbLiveRemark.Text);
            }
            catch
            {

                MessageBox.Show("房间号或实收输入格式有误，请重新输入", "错误提示");
            }

            tbLiveNum.Clear();
            tbLiveNum.Focus();
            cbLiveType.SelectedIndex = 0;
            tbLiveName.Clear();
            tbLiveId.Clear();
            tbLiveTel.Clear();
            tbLiveIncome.Clear();
            cbLiveStatus.SelectedIndex = 0;
            tbTrad.Clear();
            tbLiveRemark.Clear();
        }

        private void tbLiveCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
