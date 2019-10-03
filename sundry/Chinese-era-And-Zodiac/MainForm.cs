using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimePicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public string tiangan = "甲乙丙丁戊己庚辛壬癸";
        public string dizhi = "子丑寅卯辰巳午未申酉戌亥";
        public string shengxiao = "鼠牛虎兔龙蛇马羊猴鸡狗猪";
        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "您选择的是： ";
            label1.ForeColor = Color.Red;
            textBox1.ForeColor = Color.Blue;
        }
        private void GetDate()
        {
            try
            {
                int year = Convert.ToInt32(textBox1.Text);
                int tgindex = ((year - 3) % 10) - 1;
                int dzindex = ((year - 3) % 12) - 1;
                int sxindex = ((year - 3) % 12) - 1;
                if (tgindex == -1)
                {
                    tgindex = 9;
                }
                if (dzindex == -1)
                {
                    dzindex = 11;
                }
                if (sxindex == -1)
                {
                    sxindex = 11;
                }
                label1.Text = $"您选择的是： {tiangan[tgindex]}{dizhi[dzindex]} 年 " + $"生肖为： {shengxiao[sxindex]}";
            }
            catch
            {
                MessageBox.Show("输入格式错误", "错误提示");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDate();
        }     
    }
}
