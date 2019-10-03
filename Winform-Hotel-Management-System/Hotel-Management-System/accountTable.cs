using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class accountTable : Form
    {
        public accountTable()
        {
            InitializeComponent();
        }
        MainForm mainform = new MainForm();
        private void accountTable_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mainform.CheckAccount().Tables[0];
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

        }
        private int index;
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(Cursor.Position);
            }
            index = e.RowIndex;

        }

        private void 删除选定行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leave newleave = new leave();
            newleave.DeleteLivein("account","id",Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            dataGridView1.Rows.RemoveAt(index);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnStr = dataGridView1.Columns[e.ColumnIndex].HeaderText + "=" +
               "'"+ dataGridView1.CurrentCell.Value.ToString()+"'";
            int num = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            mainform.UpdateValue("account",columnStr,num);
        }
    }
}
