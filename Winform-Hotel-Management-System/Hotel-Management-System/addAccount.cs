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
    public partial class addAccount : Form
    {
        public addAccount()
        {
            InitializeComponent();
        }
        Sqlcon sqlcon = new Sqlcon();
        private void btAccountEnter_Click(object sender, EventArgs e)
        {
            SqlConnection sql_connection = sqlcon.Sql_connection();
            try
            {
                sql_connection.Open();
                string commandStr = "insert account (username,pwd,权限,备注) values" +
                    $"('{tbAccountName.Text}','{tbAccountPwd.Text}','{cbAccountPower.Text}','{tbAccountText.Text}')";
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
            tbAccountName.Clear();
            tbAccountName.Focus();
            tbAccountPwd.Clear();
            cbAccountPower.SelectedIndex = 0;
            tbAccountText.Clear();
        }

        private void btAccountCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
