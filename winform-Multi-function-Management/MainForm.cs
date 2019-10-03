using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多功能集成
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
           
        private void 平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }
        private int clorkclarmNum;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void 垂直ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 折叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private int timerNum;
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private int eraNum;
        private void 新建ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private int pwdNum;
        private void 新建ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void 关闭软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否关闭","关闭提示",MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }           
        }
        private int informationNum;
        private void 新建ToolStripMenuItem3_Click(object sender, EventArgs e)
        {          
           
        }

        private void 新建ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
          
        }
        private int calculatorNum;
        private void 新建ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
           
        }

        private void 闹钟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("运行前，需要将音乐路径更改为本地路径，格式: .avi", "启动提示");
            clorkclarmNum++;
            alarmClork alarm_Clork = new alarmClork();
            alarm_Clork.Text = $"alarmClork {clorkclarmNum}";
            alarm_Clork.Show();
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculatorNum++;
            calcuLator calcu_lator = new calcuLator();
            calcu_lator.Text = $"calculator {calculatorNum}";
            calcu_lator.Show();
        }

        private void 计时器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerNum++;
            timer newtimer = new timer();
            newtimer.Text = $"timer {timerNum}";
            newtimer.Show();
        }

        private void 天干地支生肖ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eraNum++;
            Era newEra = new Era();
            newEra.Text = $"Era {eraNum}";
            newEra.Show();
        }

        private void 图片播放器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("启用前，请将图片路径更改为本地路径，目前有内存溢出问题，无法正常使用", "启用提示");
            picturePlayer picture_player = new picturePlayer();
            picture_player.Show();
        }

        private void 信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用该模块前，需要将数据库改为自己数据库", "启动提示");
            informationNum++;
            informationInput information_input = new informationInput();
            information_input.Text = $"informationInput {informationNum}";
            information_input.Show();
        }

        private void 随机密码生成器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pwdNum++;
            randomPassword random_pwd = new randomPassword();
            random_pwd.Text = $"randomPassword {pwdNum}";
            random_pwd.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("多功能小模块集成","关于软件");
        }
    }
}
