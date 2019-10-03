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

namespace inputMessages
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
            //tbInput.ForeColor = Color.Blue;
        }
        public string connecStr = "server=.;user=sa;pwd=sqlwxg;database=guangyunkeji";
        private void btInput_Click(object sender, EventArgs e)
        {

            SqlConnection sql_connection = new SqlConnection(connecStr);
            try
            {
                sql_connection.Open();


                string commandStr = "insert kuaimai (worknum,name,email,company,department,position," +
                    "superior,birthday,workdate,positivetime,annualvocation)" +
                    $"values('{tbWorknum.Text}','{tbName.Text}','{tbEmail.Text}','{tbCompany.Text}'," +
                    $"'{tbDepart.Text}','{tbPosition.Text}','{tbSuperior.Text}','{tbBirth.Text}','{dtPickerWork.Value}'," +
                    $"'{dtPickerPositive.Value}','{tbAnnual.Text}')";
                SqlCommand sql_command = new SqlCommand(commandStr, sql_connection);
                sql_command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error!!!");
            }
            finally
            {
                sql_connection.Close();
            }
            tbWorknum.Clear();
            tbName.Clear();
            tbEmail.Clear();
            tbDepart.Clear();
            tbPosition.Clear();
            tbSuperior.Clear();
            tbBirth.Clear();
            dtPickerWork.Value = DateTime.Now;
            dtPickerPositive.Value = DateTime.Now;
            tbAnnual.Clear();
            tbCompany.Clear();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCheck.Text == "")
                {
                    MessageBox.Show("请输入工号信息", "错误提示");
                }
                else
                {
                    tbWorknum.Text = tbCheck.Text;
                    tbName.Text = (string)CheckValued("name", tbCheck.Text);
                    tbEmail.Text = (string)CheckValued("email", tbCheck.Text);
                    tbCompany.Text = (string)CheckValued("company", tbCheck.Text);
                    tbDepart.Text = (string)CheckValued("department", tbCheck.Text);
                    tbPosition.Text = (string)CheckValued("position", tbCheck.Text);
                    tbSuperior.Text = (string)CheckValued("superior", tbCheck.Text);
                    tbBirth.Text = (string)CheckValued("birthday", tbCheck.Text);
                    dtPickerWork.Value = (DateTime)CheckValued("workdate", tbCheck.Text);
                    dtPickerPositive.Value = (DateTime)CheckValued("positivetime", tbCheck.Text);
                    int annual = (int)CheckValued("annualvocation", tbCheck.Text);
                    tbAnnual.Text = annual.ToString();

                    btInput.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("查无此人", "查询提示");
                tbCheck.Clear();
            }
        }
        private object CheckValued(string column, string id)
        {
            SqlConnection sql_connection = new SqlConnection(connecStr);


            sql_connection.Open();
            string commandStr = $"select {column} from kuaimai where worknum='{id}'";
            SqlCommand sql_command = new SqlCommand(commandStr, sql_connection);
            object varstr =  sql_command.ExecuteScalar();
            sql_connection.Close();
            return varstr;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbWorknum.Clear();
            tbName.Clear();
            tbEmail.Clear();
            tbDepart.Clear();
            tbPosition.Clear();
            tbSuperior.Clear();
            tbBirth.Clear();
            dtPickerWork.Value = DateTime.Now;
            dtPickerPositive.Value = DateTime.Now;
            tbAnnual.Clear();
            tbCompany.Clear();
            tbCheck.Clear();
            btInput.Enabled = true;
        }
        public bool check_bool = false;
        private void btSameCheck_Click(object sender, EventArgs e)
        {
            int num = tbSameBirth.TextLength;
            if (tbSameBirth.Text.Contains("-"))
            {
                check_bool = true;
            }
            if (tbSameBirth.Text != "" && num == 5 && check_bool == true)
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = OutValues().Tables[0];
            }
            else
            {
                MessageBox.Show("请输入正确格式生日日期","错误提示");
            }
            //dataGridView1 = null;
            
            //tbInput.Clear();
            //SqlConnection sql_connen = new SqlConnection(connecStr);
            //try
            //{
                //sql_connen.Open();
                //string commandStr = $"select * from kuaimai where birthday = '{tbSameBirth.Text}'";
                //SqlCommand sql_command = new SqlCommand(commandStr, sql_connen);

                //SqlDataReader sql_dtreader = sql_command.ExecuteReader();
                //while (sql_dtreader.Read())
                //{
                //    tbInput.AppendText((string)sql_dtreader.GetValue(1)+"\t");
                //    tbInput.AppendText((string)sql_dtreader.GetValue(2)+"\n");

                //}
            //}
            //catch (Exception ex )
            //{

            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    sql_connen.Close();
            //}
        }

        private DataSet OutValues()
        {
            SqlConnection sql_connec = new SqlConnection(connecStr);
            DataSet data_set = new DataSet();
            try
            {
                sql_connec.Open();
                string adapStr = $"select * from kuaimai where birthday = '{tbSameBirth.Text}'";
                SqlDataAdapter sql_adap = new SqlDataAdapter(adapStr, connecStr);
                sql_adap.Fill(data_set,"kuaimai");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql_connec.Close();
            }
            return data_set;   
        }
        private void btClearhistory_Click(object sender, EventArgs e)
        {
            tbSameBirth.Clear();
            dataGridView1.Visible = false;
            //tbInput.Clear();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "github"&&tbPassword.Text == "github")
            {
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名或密码输入有误，请重新输入","登录失败提示");
                tbUsername.Clear();
                tbPassword.Clear();
                tbUsername.Focus();
            }
        }

     
    }
}
