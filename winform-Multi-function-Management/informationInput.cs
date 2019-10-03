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

namespace 多功能集成
{
    public partial class informationInput : Form
    {
        public informationInput()
        {
            InitializeComponent();
        }
        private SqlDataAdapter sql_adapter;
        private SqlCommand sql_command;
        private DataTable data_table;
        private SqlConnection sql_connection;
        private DataSet data_set;
        private int PageRows = 10;
        private int AllPage;
        private int AllRows;
        private int RowValues = 0;
        private int CurrentPage = 1;
        private int RowStartIndex = 0;
        private SqlConnection NewConnection()
        {
            string connectionStr = "server=.;user=sa;pwd=sqlwxg;database=guangyunkeji";//将字符串中的内容改为自己的数据库账户以及数据库，才可以正常运行
            sql_connection = new SqlConnection(connectionStr);
            return sql_connection;
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            bool isnull = true;
            sql_connection = NewConnection();
            try
            {
                if (IsNull(isnull) == false)
                    return;
                sql_connection.Open();
                string commandStr = "insert kuaimai (worknum,name,email,company," +//在数据库中定义的columnHeaders
                    "department,position,superior,birthday,workdate,positivetime,annualvocation) values" +
                    $"('{tbworkNum.Text}','{tbName.Text}','{tbEmail.Text}','{tbCompany.Text}'," +
                    $"'{tbDepart.Text}','{tbPosition.Text}','{tbSuperior.Text}','{tbBirthday.Text}','{dtpworkDate.Value}'," +
                    $"'{dtpPositive.Value}','{tbAnnual.Text}')";
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
            tbworkNum.Clear();
            tbName.Clear();
            tbDepart.Clear();
            tbCompany.Clear();
            tbEmail.Clear();
            tbPosition.Clear();
            tbSuperior.Clear();
            tbAnnual.Clear();
            dtpPositive.Value = DateTime.Now;
            dtpworkDate.Value = DateTime.Now;
            tbBirthday.Clear();

        }
        private bool IsNull(bool IsNull)
        {
            if (tbworkNum.Text.Trim() == "" && tbName.Text.Trim() == "")
            {
                IsNull = false;
            }
            else
            {
                IsNull = true;
            }
            return IsNull;
        }
        private Object CheckOut(string column, string workID)
        {
            sql_connection = NewConnection();
            object newObject = 0;
            try
            {
                sql_connection.Open();
                string commandStr = $"select {column} from kuaimai where worknum='{workID}'";
                sql_command = new SqlCommand(commandStr, sql_connection);
                newObject = sql_command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql_connection.Close();
            }
            return newObject;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string workId = tbworkNumCheck.Text;
                
                tbName.Text = (string)CheckOut("name", workId);
                tbCompany.Text = (string)CheckOut("company", workId);
                tbDepart.Text = (string)CheckOut("department", workId);
                tbPosition.Text = (string)CheckOut("position", workId);
                tbSuperior.Text = (string)CheckOut("superior", workId);
                tbBirthday.Text = (string)CheckOut("birthday", workId);
                dtpworkDate.Value = (DateTime)CheckOut("workdate", workId);
                dtpPositive.Value = (DateTime)CheckOut("positivetime", workId);
                int years = (int)CheckOut("annualvocation", workId);
                tbAnnual.Text = years.ToString();
                tbEmail.Text = (string)CheckOut("email", workId);
                tbworkNum.Text = tbworkNumCheck.Text;
            }
            catch
            {      
                MessageBox.Show("未录入工号数据", "查询提示");
            }
            btInput.Enabled = false;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbworkNum.Clear();
            tbName.Clear();
            tbDepart.Clear();
            tbCompany.Clear();
            tbEmail.Clear();
            tbPosition.Clear();
            tbSuperior.Clear();
            tbAnnual.Clear();
            dtpPositive.Value = DateTime.Now;
            dtpworkDate.Value = DateTime.Now;
            tbBirthday.Clear();
            tbworkNumCheck.Clear();
            btInput.Enabled = true;
        }

        private void btSameBirthCheck_Click(object sender, EventArgs e)
        {
            string birthText = tbSameBirth.Text;
            if (birthText.Length == 5 && birthText.Contains("-"))//这行判断逻辑不严谨，看能不能优化下
            {
                btSameBirthClear.Enabled = true;
                bindingNavigator1.Enabled = true;
                RowValues = 0;
                dataGridView1.DefaultCellStyle.BackColor = DefaultBackColor;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = DefaultBackColor;
                dataGridView1.DefaultCellStyle.ForeColor = Color.PaleVioletRed;
                dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.LightGray;
                SameBirthCheck();
            }
            else
            {
                MessageBox.Show("请输入正确格式或有效的生日日期", "错误提示");
            }
        }
        private void SameBirthCheck()
        {
            sql_connection = NewConnection();
            try
            {
                sql_connection.Open();
                data_set = new DataSet();
                string adapterStr = $"select * from kuaimai where birthday='{tbSameBirth.Text}'";
                sql_adapter = new SqlDataAdapter(adapterStr, sql_connection);
                sql_adapter.Fill(data_set, "kuaimai");
                dataGridView1.DataSource = data_set.Tables[0];
                AllRows = dataGridView1.RowCount;//当btSameBirth_Click发生后，会调用此方法，并获取AllRows(总行数）
                AllPage = (AllRows % PageRows == 0) ? (AllRows / PageRows) : (AllRows / PageRows + 1);
                //若总页数/每页行数=0(刚好整除)，则总页数就是整除后的值，否则就是值+1
                lbAllPages.Text = "/" + AllPage.ToString();
                NewBindingSource();//调用bindingNavigator1和data_set绑定数据源的方法
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

        private void btSameBirthClear_Click(object sender, EventArgs e)
        {
            bindingNavigator1.Enabled = false;
            tbSameBirth.Clear();
            data_set.Tables[0].Clear();
        }
        private DataSet AllCheck()
        {
            sql_connection = NewConnection();
            data_set = new DataSet();
            try
            {
                sql_connection.Open();
                string allAdapterStr = "select * from kuaimai";
                sql_adapter = new SqlDataAdapter(allAdapterStr, sql_connection);
                sql_adapter.Fill(data_set, "kuaimai");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = data_set.Tables[0];
                dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
                AllRows = dataGridView1.RowCount;
                AllPage = (AllRows % PageRows == 0) ? (AllRows / PageRows) : (AllRows / PageRows + 1);
                lbAllPages.Text = "/" + AllPage.ToString();
                NewBindingSource();
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            sql_connection = NewConnection();
            try
            {
                sql_connection.Open();
                string columnStr = dataGridView1.Columns[e.ColumnIndex].HeaderText;
                string valueStr = dataGridView1.CurrentCell.Value.ToString();
                string idStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string commandStr = $"update kuaimai set {columnStr} = '{valueStr}' where id='{idStr}'";
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

        private void btAllInput_Click(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = DefaultForeColor;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = DefaultForeColor;
            dataGridView1.DefaultCellStyle.BackColor = Color.PaleVioletRed;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            btSameBirthClear.Enabled = true;
            bindingNavigator1.Enabled = true;
            RowValues = 0;
            AllCheck();
        }

        private int index;
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[1];
                contextMenuStrip1.Show(Cursor.Position);//发现这行注释后，删除选项还是可以显示在光标位置，可能和
                                                        //在dataGridView1直接在属性里绑定了contextMenuStrip1控件有关系
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow((int)dataGridView1.CurrentRow.Cells[0].Value);//删除行后，直接同步数据库
            dataGridView1.Rows.RemoveAt(index);//删除后，为了不用刷新就可以显示已删除
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "github" && tbPassWord.Text == "github")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                bindingNavigator1.Visible = true;
            }
            else
            {
                MessageBox.Show("用户名或密码输入有误，请重新输入", "登录提示");
                tbUserName.Clear();
                tbPassWord.Clear();
                tbUserName.Focus();
            }
        }

        private void informationInput_Load(object sender, EventArgs e)
        {
            tbUserName.Focus();
            bindingNavigator1.Enabled = false;
            bindingNavigator1.Visible = false;
            btSameBirthClear.Enabled = false;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rec = new Rectangle(e.RowBounds.X, e.RowBounds.Y, dataGridView1.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1 + RowStartIndex).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font,
                rec, dataGridView1.RowHeadersDefaultCellStyle.ForeColor, dataGridView1.RowHeadersDefaultCellStyle.BackColor
                , TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
        }
        private DataTable DeleteRow(int ID)
        {
            sql_connection = NewConnection();
            data_table = new DataTable();
            try
            {
                sql_connection.Open();
                string adapterStr = $"delete kuaimai where id='{ID}'";
                sql_adapter = new SqlDataAdapter(adapterStr, sql_connection);
                sql_adapter.Fill(data_table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql_connection.Close();
            }
            return data_table;
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
      
            if (tbUserName.Text!="github")
            {
                errorProvider1.SetError(tbUserName, "用户名输入有误");             
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbPassWord_TextChanged(object sender, EventArgs e)
        {
            if (tbPassWord.Text != "github")
            {
                errorProvider1.SetError(tbPassWord, "密码输入有误");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            if (e.RowIndex < dataGridView1.RowCount)
            {
                Color oldForeColor = new Color();
                Color oldBackColor = new Color();
                var row = dataGridView1.Rows[e.RowIndex];
                if (row == dataGridView1.CurrentRow)
                {
                    if (row.DefaultCellStyle.ForeColor != Color.White)
                    {
                        oldForeColor = row.DefaultCellStyle.ForeColor;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (row.DefaultCellStyle.BackColor != Color.Blue)
                    {
                        oldBackColor = row.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.BackColor = Color.Blue;
                    }
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = oldForeColor;
                    row.DefaultCellStyle.BackColor = oldBackColor;
                }
            }
        }

        private void NewBindingSource()
        {

            CurrentPage = RowValues / PageRows + 1;
            toolStripTextBox1.Text = CurrentPage.ToString();
            data_set.Tables[0].Clear();
            sql_adapter.Fill(data_set, RowValues, PageRows, "kuaimai");
            bindingSource1.DataSource = data_set.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }

        private void bindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "上一页")
            {
                RowValues -= PageRows;
                RowStartIndex -= PageRows;
                if (RowValues < 0)
                {
                    MessageBox.Show("已经是第一页", "提示");
                    RowValues = 0;
                    RowStartIndex = 0;
                }
                NewBindingSource();
            }
            else if (e.ClickedItem.Text == "下一页")
            {
                RowValues += PageRows;
                RowStartIndex += PageRows;
                if (RowValues >= AllRows)
                {
                    MessageBox.Show("已经是最后一页", "提示");
                    RowValues -= PageRows;
                    RowStartIndex = (AllRows / PageRows) * PageRows;
                }
                NewBindingSource();
            }
        }
    }

}
