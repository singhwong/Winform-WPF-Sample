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
    public partial class clear : Form
    {
        public clear()
        {
            InitializeComponent();
        }
        MainForm mainform = new MainForm();
        leave thisleave = new leave();
        private void btClearEnter_Click(object sender, EventArgs e)
        {
            try
            {
                mainform.UpdateStatus(cbClearStatus.Text, tbClearNum.Text);
            }
            catch
            {

                MessageBox.Show("房间号输入格式有误，请重新输入","错误提示");
            }            
            tbClearNum.Clear();
            cbClearStatus.SelectedIndex = 0;
            tbClearNum.Clear();
            tbClearNum.Focus();
            cbClearStatus.SelectedIndex = 0;
        }

        private void btClearCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
