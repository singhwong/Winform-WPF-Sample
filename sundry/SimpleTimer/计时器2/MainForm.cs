using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计时器2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Text = "开始";
            textBox1.Text = "00:00:00";
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = "00:00:00";
            textBox1.ForeColor = Color.Red;
            textBox1.Font = new Font("System", 11);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int minutes = Convert.ToInt32(textBox1.Text.Substring(0, 2));
            int seconds = Convert.ToInt32(textBox1.Text.Substring(3, 2));
            int numbers = Convert.ToInt32(textBox1.Text.Substring(6, 2));
            numbers++;
            if (numbers >= 100)
            {
                seconds++;
                numbers = 0;
            }
            if (seconds >= 60)
            {
                minutes += seconds / 60;
                seconds = 0;
            }
            if (numbers < 10)
            {

                if (minutes < 10 && seconds < 10)
                {
                    textBox1.Text = $"0{minutes}:0{seconds}:0{numbers}";
                }
                else if (minutes < 10 && seconds >= 10)
                {
                    textBox1.Text = $"0{minutes}:{seconds}:0{numbers}";
                }
                else if (minutes >= 10 && seconds < 10)
                {
                    textBox1.Text = $"{minutes}:0{seconds}:0{numbers}";
                }
                else
                {
                    textBox1.Text = $"{minutes}:{seconds}:0{numbers}";
                }
            }
            else
            {
                if (minutes < 10 && seconds < 10)
                {
                    textBox1.Text = $"0{minutes}:0{seconds}:{numbers}";
                }
                else if (minutes < 10 && seconds >= 10)
                {
                    textBox1.Text = $"0{minutes}:{seconds}:{numbers}";
                }
                else if (minutes >= 10 && seconds < 10)
                {
                    textBox1.Text = $"{minutes}:0{seconds}:{numbers}";
                }
                else
                {
                    textBox1.Text = $"{minutes}:{seconds}:{numbers}";
                }
            }
        }
    }
}
