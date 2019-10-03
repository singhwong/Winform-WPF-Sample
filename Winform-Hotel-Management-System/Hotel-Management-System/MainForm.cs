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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Sqlcon sqlcon = new Sqlcon();
        private SqlConnection sql_connection;
        private SqlCommand sql_command;
        private SqlDataAdapter sql_adapter;
        private DataSet data_set;
        private SqlDataReader sql_reader;
        private int liveinNum;
        private bool IsLoad = false;
        private int leaveNum;
        private int clearNum;
        private int addaccountNum;
        private int addroomNum;
        private int houseIndex;
        private bool detailsStatus_bool = false;
        private bool detailsLevel_bool = false;
        private bool detailsType_bool = false;
        private bool mainStatus_bool = false;
        private bool mainLevel_bool = false;
        private bool mainType_bool = false;
        private string condition_str = "";
        private int incomeIndex;
        private int index = 30;
        private string[] userStr;
        private string[] pwdStr;
        private string[] powerStr;
        private bool IsHasRow;

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbLoadUser.Focus();
            cbMainStatus.SelectedIndex = 0;
            cbMainLevel.SelectedIndex = 0;
            cbMainType.SelectedIndex = 0;
            cbDetailsStatus.SelectedIndex = 0;
            cbDetailsLevel.SelectedIndex = 0;
            cbDetailsType.SelectedIndex = 0;
            dgvHouse.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.BackColor = Color.White;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView3.DefaultCellStyle.BackColor = Color.White;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView3.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgvHouse.DefaultCellStyle.BackColor = Color.White;
            dgvHouse.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvHouse.DefaultCellStyle.ForeColor = Color.Black;
            dgvHouse.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgvIncome.DefaultCellStyle.BackColor = Color.White;
            dgvIncome.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvIncome.DefaultCellStyle.ForeColor = Color.Black;
            dgvIncome.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            删除选定行ToolStripMenuItem.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            liveinNum++;
            liveIn live_in = new liveIn();
            live_in.Text = $"入住登记 {liveinNum}";
            live_in.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            leaveNum++;
            leave newleave = new leave();
            newleave.Text = $"退房登记 {leaveNum}";
            newleave.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clearNum++;
            clear newclear = new clear();
            newclear.Text = $"清扫登记 {clearNum}";
            newclear.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addaccountNum++;
            addAccount add_account = new addAccount();
            add_account.Text = $"添加账户 {addaccountNum}";
            add_account.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addroomNum++;
            addRoom add_room = new addRoom();
            add_room.Text = $"增加房间 {addroomNum}";
            add_room.Show();
        }

        public void AddRooms(int num, string type, string l, decimal price, string status, string remark)
        {
            sql_connection = sqlcon.Sql_connection();
            try
            {
                sql_connection.Open();
                string commandStr = "insert roomTable (房间号,房间类型,所在楼层,价格,房间状态,备注) values " +
                    $"('{num}','{type}','{l}','{price}','{status}','{remark}') ";
                sql_command = new SqlCommand(commandStr, sql_connection);
                sql_command.ExecuteNonQuery();
            }

            finally
            {
                sql_connection.Close();
            }
        }

        private DataSet CheckRooms(string status, string level, string type, string num, string conditionStr)
        {
            string adapterStr;
            sql_connection = sqlcon.Sql_connection();
            data_set = new DataSet();
            try
            {
                sql_connection.Open();
                if (status == "Null" && level == "Null" && type == "Null" && num == "")
                {
                    adapterStr = "select * from roomTable";
                }

                else
                {
                    adapterStr = $"select * from roomTable where ({conditionStr})";
                }
                sql_adapter = new SqlDataAdapter(adapterStr, sql_connection);
                sql_adapter.Fill(data_set, "roomTable");
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

        private void CheckDetails_bool()
        {
            if (cbDetailsStatus.SelectedIndex != 0)
            {
                detailsStatus_bool = true;
            }
            if (cbDetailsLevel.SelectedIndex != 0)
            {
                detailsLevel_bool = true;
            }
            if (cbDetailsType.SelectedIndex != 0)
            {
                detailsType_bool = true;
            }
        }

        private void Checks()
        {

            CheckDetails_bool();
            if (detailsStatus_bool == true && detailsLevel_bool == false && detailsType_bool == false)
            {
                condition_str = "房间状态" + "=" + "'" + cbDetailsStatus.Text + "'";
                dataGridView3.DataSource = CheckRooms(cbDetailsStatus.Text, cbDetailsLevel.Text,
                    cbDetailsType.Text, tbDetailsNum.Text, condition_str).Tables[0];
                detailsStatus_bool = false;
            }
            else if (detailsStatus_bool == false && detailsLevel_bool == true && detailsType_bool == false)
            {
                condition_str = "所在楼层" + "=" + "'" + cbDetailsLevel.Text + "'";
                dataGridView3.DataSource = CheckRooms(cbDetailsStatus.Text, cbDetailsLevel.Text,
                    cbDetailsType.Text, tbDetailsNum.Text, condition_str).Tables[0];
                detailsLevel_bool = false;
            }
            else if (detailsStatus_bool == false && detailsLevel_bool == false && detailsType_bool == true)
            {
                condition_str = "房间类型" + "=" + "'" + cbDetailsType.Text + "'";
                dataGridView3.DataSource = CheckRooms(cbDetailsStatus.Text, cbDetailsLevel.Text,
                    cbDetailsType.Text, tbDetailsNum.Text, condition_str).Tables[0];
                detailsType_bool = false;
            }
            else if (detailsStatus_bool == true && detailsLevel_bool == true && detailsType_bool == false)
            {
                condition_str = "房间状态" + "=" + "'" + cbDetailsStatus.Text + "'" + "and" +
                    "\t所在楼层" + "=" + "'" + cbDetailsLevel.Text + "'";
                dataGridView3.DataSource = CheckRooms(cbDetailsStatus.Text, cbDetailsLevel.Text,
                    cbDetailsType.Text, tbDetailsNum.Text, condition_str).Tables[0];
                detailsStatus_bool = false;
                detailsLevel_bool = false;
            }
            else if (detailsStatus_bool == false && detailsLevel_bool == true && detailsType_bool == true)
            {
                condition_str = "所在楼层" + "=" + "'" + cbDetailsLevel.Text + "'" + "and" +
                    "\t房间类型" + "=" + "'" + cbDetailsType.Text + "'";
                dataGridView3.DataSource = CheckRooms(cbDetailsStatus.Text, cbDetailsLevel.Text,
                    cbDetailsType.Text, tbDetailsNum.Text, condition_str).Tables[0];
                detailsLevel_bool = false;
                detailsType_bool = false;
            }
            else if (detailsStatus_bool == true && detailsLevel_bool == false && detailsType_bool == true)
            {
                condition_str = "房间类型" + "=" + "'" + cbDetailsType.Text + "'" + "and" +
                    "\t房间状态" + "=" + "'" + cbDetailsStatus.Text + "'";
                dataGridView3.DataSource = CheckRooms(cbDetailsStatus.Text, cbDetailsLevel.Text,
                    cbDetailsType.Text, tbDetailsNum.Text, condition_str).Tables[0];
                detailsStatus_bool = false;
                detailsType_bool = false;
            }
            else if (detailsStatus_bool == true && detailsLevel_bool == true && detailsType_bool == true)
            {
                condition_str = "房间状态" + "=" + "'" + cbDetailsStatus.Text + "'" + "and" +
                    "\t所在楼层" + "=" + "'" + cbDetailsLevel.Text + "'" + "and" + "\t房间类型" + "=" + "'" + cbDetailsType.Text + "'";
                dataGridView3.DataSource = CheckRooms(cbDetailsStatus.Text, cbDetailsLevel.Text,
                    cbDetailsType.Text, tbDetailsNum.Text, condition_str).Tables[0];
                detailsStatus_bool = false;
                detailsLevel_bool = false;
                detailsType_bool = false;
            }
            else if (detailsStatus_bool == false && detailsLevel_bool == false && detailsType_bool == false && tbDetailsNum.Text != "")
            {
                condition_str = "房间号" + "=" + "'" + tbDetailsNum.Text + "'";
                dataGridView3.DataSource = CheckRooms(cbDetailsStatus.Text, cbDetailsLevel.Text,
                    cbDetailsType.Text, tbDetailsNum.Text, condition_str).Tables[0];
            }
            else
            {
                condition_str = "";
                dataGridView3.DataSource = CheckRooms("Null", "Null", "Null", "", condition_str).Tables[0];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Checks();
        }

        private void CheckMain_bool()
        {
            if (cbMainStatus.SelectedIndex != 0)
            {
                mainStatus_bool = true;
            }
            if (cbMainLevel.SelectedIndex != 0)
            {
                mainLevel_bool = true;
            }
            if (cbMainType.SelectedIndex != 0)
            {
                mainType_bool = true;
            }
        }

        private void MainChecks()
        {

            CheckMain_bool();
            if (mainStatus_bool == true && mainLevel_bool == false && mainType_bool == false)
            {
                condition_str = "房间状态" + "=" + "'" + cbMainStatus.Text + "'";
                dgvHouse.DataSource = CheckRooms(cbMainStatus.Text, cbMainLevel.Text,
                    cbMainType.Text, tbMainNum.Text, condition_str).Tables[0];
                mainStatus_bool = false;
            }
            else if (mainStatus_bool == false && mainLevel_bool == true && mainType_bool == false)
            {
                condition_str = "所在楼层" + "=" + "'" + cbMainLevel.Text + "'";
                dgvHouse.DataSource = CheckRooms(cbMainStatus.Text, cbMainLevel.Text,
                    cbMainType.Text, tbMainNum.Text, condition_str).Tables[0];
                mainLevel_bool = false;
            }
            else if (mainStatus_bool == false && mainLevel_bool == false && mainType_bool == true)
            {
                condition_str = "房间类型" + "=" + "'" + cbMainType.Text + "'";
                dgvHouse.DataSource = CheckRooms(cbMainStatus.Text, cbMainLevel.Text,
                    cbMainType.Text, tbMainNum.Text, condition_str).Tables[0];
                mainType_bool = false;
            }
            else if (mainStatus_bool == true && mainLevel_bool == true && mainType_bool == false)
            {
                condition_str = "房间状态" + "=" + "'" + cbMainStatus.Text + "'" + "and" +
                    "\t所在楼层" + "=" + "'" + cbMainLevel.Text + "'";
                dgvHouse.DataSource = CheckRooms(cbMainStatus.Text, cbMainLevel.Text,
                    cbMainType.Text, tbMainNum.Text, condition_str).Tables[0];
                mainStatus_bool = false;
                mainLevel_bool = false;
            }
            else if (mainStatus_bool == false && mainLevel_bool == true && mainType_bool == true)
            {
                condition_str = "所在楼层" + "=" + "'" + cbMainLevel.Text + "'" + "and" +
                    "\t房间类型" + "=" + "'" + cbMainType.Text + "'";
                dgvHouse.DataSource = CheckRooms(cbMainStatus.Text, cbMainLevel.Text,
                    cbMainType.Text, tbMainNum.Text, condition_str).Tables[0];
                mainLevel_bool = false;
                mainType_bool = false;
            }
            else if (mainStatus_bool == true && mainLevel_bool == false && mainType_bool == true)
            {
                condition_str = "房间状态" + "=" + "'" + cbMainStatus.Text + "'" + "and" +
                   "\t房间类型" + "=" + "'" + cbMainType.Text + "'";
                dgvHouse.DataSource = CheckRooms(cbMainStatus.Text, cbMainLevel.Text,
                    cbMainType.Text, tbMainNum.Text, condition_str).Tables[0];
                mainStatus_bool = false;
                mainType_bool = false;
            }
            else if (mainStatus_bool == true && mainLevel_bool == true && mainType_bool == true)
            {
                condition_str = "房间状态" + "=" + "'" + cbMainStatus.Text + "'" + "and" +
                  "\t房间类型" + "=" + "'" + cbMainType.Text + "'" + "and" + "\t所在楼层" + "=" + "'" + cbMainLevel.Text + "'";
                dgvHouse.DataSource = CheckRooms(cbMainStatus.Text, cbMainLevel.Text,
                    cbMainType.Text, tbMainNum.Text, condition_str).Tables[0];
                mainStatus_bool = false;
                mainType_bool = false;
                mainLevel_bool = false;
            }
            else if (mainStatus_bool == false && mainLevel_bool == false && mainType_bool == false && tbMainNum.Text != "")
            {
                condition_str = "房间号" + "=" + "'" + tbMainNum.Text + "'";

                dgvHouse.DataSource = CheckRooms(cbMainStatus.Text, cbMainLevel.Text,
                    cbMainType.Text, tbMainNum.Text, condition_str).Tables[0];
            }
            else
            {
                condition_str = "";
                dgvHouse.DataSource = CheckRooms(cbMainStatus.Text, cbMainLevel.Text,
                   cbMainType.Text, tbMainNum.Text, condition_str).Tables[0];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dgvIncome.Visible = false;
            dgvHouse.Visible = true;
            MainChecks();
        }

        private void cbMainStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMainNum.Enabled = false;
            if (cbMainStatus.SelectedIndex == 0 && cbMainLevel.SelectedIndex == 0
                && cbMainType.SelectedIndex == 0)
            {
                tbMainNum.Enabled = true;
            }
        }

        private void cbMainLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbMainNum.Enabled = false;
            if (cbMainStatus.SelectedIndex == 0 && cbMainLevel.SelectedIndex == 0
                && cbMainType.SelectedIndex == 0)
            {

                tbMainNum.Enabled = true;
            }
        }

        private void cbMainType_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbMainNum.Enabled = false;
            if (cbMainStatus.SelectedIndex == 0 && cbMainLevel.SelectedIndex == 0
                && cbMainType.SelectedIndex == 0)
            {
                tbMainNum.Enabled = true;
            }
        }

        private void tbMainNum_TextChanged(object sender, EventArgs e)
        {
            cbMainStatus.Enabled = false;
            cbMainLevel.Enabled = false;
            cbMainType.Enabled = false;
            if (tbMainNum.Text == "")
            {
                cbMainStatus.Enabled = true;
                cbMainLevel.Enabled = true;
                cbMainType.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cbMainStatus.Text = "Null";
            cbMainLevel.Text = "Null";
            cbMainType.Text = "Null";
            tbMainNum.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cbDetailsStatus.Text = "Null";
            cbDetailsLevel.Text = "Null";
            cbDetailsType.Text = "Null";
            tbDetailsNum.Clear();
        }

        private void cbDetailsStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbDetailsNum.Enabled = false;
            if (cbDetailsStatus.SelectedIndex == 0 && cbDetailsLevel.SelectedIndex == 0 &&
                cbDetailsType.SelectedIndex == 0)
            {

                tbDetailsNum.Enabled = true;
            }
        }

        private void cbDetailsLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbDetailsNum.Enabled = false;
            if (cbDetailsStatus.SelectedIndex == 0 && cbDetailsLevel.SelectedIndex == 0 &&
               cbDetailsType.SelectedIndex == 0)
            {

                tbDetailsNum.Enabled = true;
            }
        }

        private void cbDetailsType_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbDetailsNum.Enabled = false;
            if (cbDetailsStatus.SelectedIndex == 0 && cbDetailsLevel.SelectedIndex == 0 &&
                cbDetailsType.SelectedIndex == 0)
            {

                tbDetailsNum.Enabled = true;
            }
        }

        private void tbDetailsNum_TextChanged(object sender, EventArgs e)
        {
            cbDetailsLevel.Enabled = false;
            cbDetailsType.Enabled = false;
            cbDetailsStatus.Enabled = false;
            if (tbDetailsNum.Text == "")
            {
                cbDetailsLevel.Enabled = true;
                cbDetailsType.Enabled = true;
                cbDetailsStatus.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbFirstNum.Text != "")
            {
                dataGridView1.DataSource = CheckRegister(tbFirstNum.Text, tbFirstName.Text,
                    tbFirstTel.Text, tbFirstID.Text, "register", "房间号", tbFirstNum.Text).Tables[0];
            }
            else if (tbFirstName.Text != "")
            {
                dataGridView1.DataSource = CheckRegister(tbFirstNum.Text, tbFirstName.Text,
                    tbFirstTel.Text, tbFirstID.Text, "register", "入住人", tbFirstName.Text).Tables[0];
            }
            else if (tbFirstTel.Text != "")
            {
                dataGridView1.DataSource = CheckRegister(tbFirstNum.Text, tbFirstName.Text,
                    tbFirstTel.Text, tbFirstID.Text, "register", "联系方式", tbFirstTel.Text).Tables[0];
            }
            else if (tbFirstID.Text != "")
            {
                dataGridView1.DataSource = CheckRegister(tbFirstNum.Text, tbFirstName.Text,
                    tbFirstTel.Text, tbFirstID.Text, "register", "身份证号", tbFirstID.Text).Tables[0];
            }
            else if (dtpFirst1.Value.Date != DateTime.Now.Date || dtpFirst2.Value.Date != DateTime.Now.Date)
            {

                dataGridView1.DataSource = CheckDate(dtpFirst1.Value.Date, dtpFirst2.Value.Date, "register", "入住时间").Tables[0];
            }
            else
            {
                dataGridView1.DataSource = CheckRegister(tbFirstNum.Text, tbFirstName.Text,
                    tbFirstTel.Text, tbFirstID.Text, "register", "", "").Tables[0];
            }
        }

        private DataSet CheckRegister(string tbNum, string tbName, string tbTel, string tbId, string tableStr, string column, string value)
        {
            string adapterStr;
            sql_connection = sqlcon.Sql_connection();
            data_set = new DataSet();
            try
            {
                sql_connection.Open();
                if (tbNum == "" && tbName == "" && tbTel == "" && tbId == "")
                {
                    adapterStr = $"select * from {tableStr}";
                }
                else
                {
                    adapterStr = $"select * from {tableStr} where {column}='{value}'";
                }
                sql_adapter = new SqlDataAdapter(adapterStr, sql_connection);
                sql_adapter.Fill(data_set, $"{tableStr}");
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

        private void tbFirstID_TextChanged(object sender, EventArgs e)
        {
            tbFirstName.Enabled = false;
            tbFirstNum.Enabled = false;
            tbFirstTel.Enabled = false;
            dtpFirst1.Enabled = false;
            dtpFirst2.Enabled = false;
            if (tbFirstID.Text == "")
            {
                tbFirstName.Enabled = true;
                tbFirstNum.Enabled = true;
                tbFirstTel.Enabled = true;
                dtpFirst1.Enabled = true;
                dtpFirst2.Enabled = true;
            }
        }

        private void tbFirstTel_TextChanged(object sender, EventArgs e)
        {
            tbFirstName.Enabled = false;
            tbFirstNum.Enabled = false;
            tbFirstID.Enabled = false;
            dtpFirst1.Enabled = false;
            dtpFirst2.Enabled = false;
            if (tbFirstTel.Text == "")
            {
                tbFirstName.Enabled = true;
                tbFirstNum.Enabled = true;
                tbFirstID.Enabled = true;
                dtpFirst1.Enabled = true;
                dtpFirst2.Enabled = true;
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            tbFirstID.Enabled = false;
            tbFirstNum.Enabled = false;
            tbFirstTel.Enabled = false;
            dtpFirst1.Enabled = false;
            dtpFirst2.Enabled = false;
            if (tbFirstName.Text == "")
            {
                tbFirstID.Enabled = true;
                tbFirstNum.Enabled = true;
                tbFirstTel.Enabled = true;
                dtpFirst1.Enabled = true;
                dtpFirst2.Enabled = true;
            }
        }

        private void tbFirstNum_TextChanged(object sender, EventArgs e)
        {
            tbFirstName.Enabled = false;
            tbFirstID.Enabled = false;
            tbFirstTel.Enabled = false;
            dtpFirst1.Enabled = false;
            dtpFirst2.Enabled = false;
            if (tbFirstNum.Text == "")
            {
                tbFirstID.Enabled = true;
                tbFirstName.Enabled = true;
                tbFirstTel.Enabled = true;
                dtpFirst1.Enabled = true;
                dtpFirst2.Enabled = true;
            }
        }

        public void UpdateStatus(string status, string num)
        {
            sql_connection = sqlcon.Sql_connection();
            try
            {
                sql_connection.Open();
                string commandStr = $"update roomTable set 房间状态='{status}'where 房间号='{num}'";
                sql_command = new SqlCommand(commandStr, sql_connection);
                sql_command.ExecuteNonQuery();
            }

            finally
            {
                sql_connection.Close();
            }
        }

        public void GetMoney(decimal money, DateTime time, int num, string name, string id, string tel, string remark)
        {
            sql_connection = sqlcon.Sql_connection();
            try
            {
                sql_connection.Open();
                string commandStr = $"insert money (收入金额,收入时间,房间号,入住人,身份证号,联系方式,备注) values" +
                    $"('{money}','{time}','{num}','{name}','{id}','{tel}','{remark}')";
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

        private DataSet CheckDate(DateTime startTime, DateTime endTime, string tableStr, string columnStr)
        {
            data_set = new DataSet();
            sql_connection = sqlcon.Sql_connection();
            string adapterStr;
            try
            {
                sql_connection.Open();
                if (startTime != DateTime.Now.Date || endTime != DateTime.Now.Date && startTime != endTime)
                {
                    adapterStr = $"select * from {tableStr} where {columnStr}>'{startTime}' and {columnStr}< '{endTime}'";
                }
                else
                {
                    adapterStr = $"select * from {tableStr} where {columnStr} < 0";//当开始日期与结束日期相同时，不进行查询显示，只能隔日查询
                }
                sql_adapter = new SqlDataAdapter(adapterStr, sql_connection);
                sql_adapter.Fill(data_set, tableStr);
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

        private void button5_Click(object sender, EventArgs e)
        {
            dgvHouse.Visible = false;
            dgvIncome.Visible = true;
            dgvIncome.DataSource = CheckDate(dtpPower1.Value.Date, dtpPower2.Value.Date, "money", "收入时间").Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            accountTable account_table = new accountTable();
            account_table.Show();
        }

        public DataSet CheckAccount()
        {
            data_set = new DataSet();
            sql_connection = sqlcon.Sql_connection();
            try
            {
                sql_connection.Open();
                string adapterStr = "select * from account";
                sql_adapter = new SqlDataAdapter(adapterStr, sql_connection);
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

        private void button14_Click(object sender, EventArgs e)
        {
            if (tbHistoryNum.Text != "")
            {
                dataGridView2.DataSource = CheckRegister(tbHistoryNum.Text, tbHistoryName.Text,
                    tbHistoryTel.Text, tbHistoryId.Text, "registerHistory", "房间号", tbHistoryNum.Text).Tables[0];
            }
            else if (tbHistoryName.Text != "")
            {
                dataGridView2.DataSource = CheckRegister(tbHistoryNum.Text, tbHistoryName.Text,
                    tbHistoryTel.Text, tbHistoryId.Text, "registerHistory", "入住人", tbHistoryName.Text).Tables[0];
            }
            else if (tbHistoryTel.Text != "")
            {
                dataGridView2.DataSource = CheckRegister(tbHistoryNum.Text, tbHistoryName.Text,
                    tbHistoryTel.Text, tbHistoryId.Text, "registerHistory", "联系方式", tbHistoryTel.Text).Tables[0];
            }
            else if (tbHistoryId.Text != "")
            {
                dataGridView2.DataSource = CheckRegister(tbHistoryNum.Text, tbHistoryName.Text,
                    tbHistoryTel.Text, tbHistoryId.Text, "registerHistory", "身份证号", tbHistoryId.Text).Tables[0];
            }

            else
            {
                dataGridView2.DataSource = CheckRegister(tbHistoryNum.Text, tbHistoryName.Text,
                    tbHistoryTel.Text, tbHistoryId.Text, "registerHistory", "", "").Tables[0];
            }
        }

        private void tbHistoryId_TextChanged(object sender, EventArgs e)
        {
            tbHistoryName.Enabled = false;
            tbHistoryNum.Enabled = false;
            tbHistoryTel.Enabled = false;
            if (tbHistoryId.Text == "")
            {
                tbHistoryName.Enabled = true;
                tbHistoryNum.Enabled = true;
                tbHistoryTel.Enabled = true;
            }
        }

        private void tbHistoryTel_TextChanged(object sender, EventArgs e)
        {
            tbHistoryName.Enabled = false;
            tbHistoryNum.Enabled = false;
            tbHistoryId.Enabled = false;
            if (tbHistoryTel.Text == "")
            {
                tbHistoryName.Enabled = true;
                tbHistoryNum.Enabled = true;
                tbHistoryId.Enabled = true;
            }
        }

        private void tbHistoryName_TextChanged(object sender, EventArgs e)
        {
            tbHistoryId.Enabled = false;
            tbHistoryNum.Enabled = false;
            tbHistoryTel.Enabled = false;
            if (tbHistoryName.Text == "")
            {
                tbHistoryId.Enabled = true;
                tbHistoryNum.Enabled = true;
                tbHistoryTel.Enabled = true;
            }
        }

        private void tbHistoryNum_TextChanged(object sender, EventArgs e)
        {
            tbHistoryName.Enabled = false;
            tbHistoryId.Enabled = false;
            tbHistoryTel.Enabled = false;
            if (tbHistoryNum.Text == "")
            {
                tbHistoryName.Enabled = true;
                tbHistoryId.Enabled = true;
                tbHistoryTel.Enabled = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tbHistoryId.Clear();
            tbHistoryName.Clear();
            tbHistoryNum.Clear();
            tbHistoryTel.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tbFirstNum.Clear();
            tbFirstName.Clear();
            tbFirstTel.Clear();
            tbFirstID.Clear();
            dtpFirst1.Value = DateTime.Now;
            dtpFirst2.Value = DateTime.Now;
        }

        private void GetAccountValue()
        {

            sql_connection = sqlcon.Sql_connection();
            userStr = new string[index];
            pwdStr = new string[index];
            powerStr = new string[index];
            int num = 0;
            try
            {
                sql_connection.Open();
                string commandStr = "select * from account";
                sql_command = new SqlCommand(commandStr, sql_connection);
                sql_reader = sql_command.ExecuteReader();
                IsHasRow = sql_reader.HasRows;
                while (sql_reader.Read())
                {
                    userStr[num] = sql_reader[1].ToString();
                    pwdStr[num] = sql_reader[2].ToString();
                    powerStr[num] = sql_reader[3].ToString();
                    num++;
                }
                sql_reader.Close();
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

        private void DeleteValue(int num, string tableStr)
        {
            sql_connection = sqlcon.Sql_connection();
            string commandStr = $"delete";
        }

        private void 删除选定行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leave newleave = new leave();
            if (dgvHouse.Visible == true)
            {
                newleave.DeleteLivein("roomTable", "id", Convert.ToInt32(dgvHouse.CurrentRow.Cells[0].Value));
                dgvHouse.Rows.RemoveAt(houseIndex);
            }
            else
            {
                newleave.DeleteLivein("money", "id", Convert.ToInt32(dgvIncome.CurrentRow.Cells[0].Value));
                dgvIncome.Rows.RemoveAt(incomeIndex);
            }


        }

        public void UpdateValue(string tableStr, string columnStr, int num)
        {
            sql_connection = sqlcon.Sql_connection();
            try
            {
                sql_connection.Open();
                string commandStr = $"update {tableStr} set {columnStr} where id='{num}'";
                sql_command = new SqlCommand(commandStr, sql_connection);
                sql_command.ExecuteNonQuery();
            }
            finally
            {
                sql_connection.Close();
            }
        }

        private void tbLoadEnter_Click(object sender, EventArgs e)
        {
            GetAccountValue();
            if (IsHasRow == false)
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox2.Enabled = true;
            }
            for (int i = 0; i < index; i++)
            {
                if (tbLoadUser.Text == userStr[i] && tbLoadPwd.Text == pwdStr[i] && powerStr[i] == "管理员")
                {
                    MessageBox.Show($"欢迎管理员{tbLoadUser.Text}登入", "登录提示");
                    IsLoad = true;
                    dgvHouse.ReadOnly = false;
                    删除选定行ToolStripMenuItem.Enabled = true;
                    groupBox4.Enabled = true;
                    groupBox5.Enabled = true;
                }
                else if (tbLoadUser.Text == userStr[i] && tbLoadPwd.Text == pwdStr[i] && powerStr[i] == "普通用户")
                {
                    MessageBox.Show($"欢迎普通员工{tbLoadUser.Text}登入", "登录提示");
                    IsLoad = true;
                    dgvHouse.ReadOnly = true;
                    删除选定行ToolStripMenuItem.Enabled = false;
                    groupBox4.Enabled = false;
                    groupBox5.Enabled = false;
                }
            }
            if (IsLoad || IsHasRow == false)
            {
                this.Text = "管理主窗口";
                this.MaximumSize = new Size(1050, 828);
                this.Size = this.MaximumSize;
                panel1.Visible = false;
                IsLoad = false;
            }
            else
            {

                MessageBox.Show("账户或密码输入有误,请重新输入", "登录提示");
            }
        }

        private void button16_Click_3(object sender, EventArgs e)
        {
            dtpPower1.Value = DateTime.Now;
            dtpPower2.Value = DateTime.Now;
        }

        private void dtpFirst1_ValueChanged(object sender, EventArgs e)
        {
            tbFirstName.Enabled = false;
            tbFirstNum.Enabled = false;
            tbFirstTel.Enabled = false;
            tbFirstID.Enabled = false;
            if (dtpFirst1.Value.Date == DateTime.Now.Date && dtpFirst2.Value.Date == DateTime.Now.Date)
            {
                tbFirstName.Enabled = true;
                tbFirstNum.Enabled = true;
                tbFirstTel.Enabled = true;
                tbFirstID.Enabled = true;
            }
        }

        private void dtpFirst2_ValueChanged(object sender, EventArgs e)
        {
            tbFirstName.Enabled = false;
            tbFirstNum.Enabled = false;
            tbFirstTel.Enabled = false;
            tbFirstID.Enabled = false;
            if (dtpFirst1.Value.Date == DateTime.Now.Date && dtpFirst2.Value.Date == DateTime.Now.Date)
            {
                tbFirstName.Enabled = true;
                tbFirstNum.Enabled = true;
                tbFirstTel.Enabled = true;
                tbFirstID.Enabled = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Text = "登录窗口";
            panel1.Visible = true;
            this.Size = new Size(364, 302);
            tbLoadUser.Clear();
            tbLoadUser.Focus();
            tbLoadPwd.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = Color.LightSkyBlue;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.White;
        }

        private void dgvIncome_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            incomeIndex = e.RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                dgvIncome.Rows[incomeIndex].Selected = true;
                dgvIncome.CurrentCell = dgvIncome.Rows[e.RowIndex].Cells[0];
            }
        }

        private void dgvHouse_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnStr = dgvHouse.Columns[e.ColumnIndex].HeaderText + "=" +
              "'" + dgvHouse.CurrentCell.Value.ToString() + "'";
            int num = (int)dgvHouse.Rows[e.RowIndex].Cells[0].Value;
            UpdateValue("roomTable", columnStr, num);
        }

        private void dgvHouse_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            houseIndex = e.RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                dgvHouse.Rows[houseIndex].Selected = true;
                dgvHouse.CurrentCell = dgvHouse.Rows[e.RowIndex].Cells[0];
            }
        }
    }
}
