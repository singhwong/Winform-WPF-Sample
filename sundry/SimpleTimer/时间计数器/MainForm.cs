using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 时间计数器
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "00:00";
            textBox1.ForeColor = Color.Red;
            textBox1.Font = new Font("System", 11);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int minutes = Convert.ToInt32(textBox1.Text.Substring(0, 2));
            int seconds = Convert.ToInt32(textBox1.Text.Substring(3, 2));
            seconds++;
            if (seconds>60)
            {
                minutes = seconds / 60;
                seconds = seconds - minutes * 60;
            }
            if (minutes<10&&seconds<10)
            {
                textBox1.Text = $"0{minutes}:0{seconds}";
            }
            else if (minutes<10&&seconds>=10)
            {
                textBox1.Text = $"0{minutes}:{seconds}";
            }
            else if (minutes>=10&&seconds<10)
            {
                textBox1.Text = $"{minutes}:0{seconds}";
            }
            else
            {
                textBox1.Text = $"{minutes}:{seconds}";
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                button1.Text = "继续";
                timer1.Enabled = false;
            }
            else
            {
                button1.Text = "暂停";
                timer1.Enabled = true;
            }
            //timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Text = "开始";
            textBox1.Text = "00:00";
        }
    }
}
