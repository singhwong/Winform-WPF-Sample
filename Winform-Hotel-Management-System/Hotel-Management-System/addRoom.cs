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
    public partial class addRoom : Form
    {
        public addRoom()
        {
            InitializeComponent();
        }
        private MainForm main_form = new MainForm();
        private void btEnter_Click(object sender, EventArgs e)
        {
            try
            {
                main_form.AddRooms(Convert.ToInt32(tbNum.Text), cbType.Text, cbLevel.Text,
               Convert.ToDecimal(tbPrice.Text), cbStatus.Text, tbRemark.Text);
            }
            catch
            {
                MessageBox.Show("房间号或实收输入格式有误，请重新输入", "错误提示");
            }
            tbNum.Clear();
            tbNum.Focus();
            cbType.SelectedIndex = 0;
            cbLevel.SelectedIndex=0;
            tbPrice.Clear();
            cbStatus.SelectedIndex = 0;
            tbRemark.Clear();
        }

        private void tbCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
