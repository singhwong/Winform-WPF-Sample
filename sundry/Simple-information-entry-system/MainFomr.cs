using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简易信息录入系统
{
    public partial class MainFomr : Form
    {
        public MainFomr()
        {
            InitializeComponent();
        }

        public int index = 0, index2 = 0;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            index++;
            form1 newform = new form1();
            newform.BringToFront();
            newform.MdiParent = this;
            newform.Text = $"登录窗口 {index}";
            newform.Show();
        }

        private void MainFomr_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
            menuStrip1.Visible = false;
            toolStripStatusLabel2.Text = "网站：www.microsoft.com";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            toolStripMenuItem8.Enabled = false;
            toolStripMenuItem9.Enabled = true;


        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            toolStripMenuItem8.Enabled = true;
            toolStripMenuItem9.Enabled = false;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form activeform = this.ActiveMdiChild;
            activeform.Close();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本软件纯属练习\n出品人：wang", "关于我们");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("退出前请记得保存\n请确认是否退出", "退出提示",MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            index++;
            form1 newform = new form1();
            newform.BringToFront();
            newform.MdiParent = this;
            newform.Text = $"登录窗口 {index}";
            newform.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form activeform = this.ActiveMdiChild;
            activeform.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("退出前请记得保存\n请确认是否退出", "退出提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "github" && textBox2.Text == "github")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
                toolStripStatusLabel1.Text = "欢迎使用，祝您工作顺利";
                MessageBox.Show("欢迎进入系统");
            }
            else
            {
                MessageBox.Show("您输入的用户名或密码有误，请重新输入");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 查询FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index2++;
            form2 newform2 = new form2();
            newform2.MdiParent = this;
            newform2.Text = $"信息查询 {index2}";
            newform2.Show();
        }
    }
}
