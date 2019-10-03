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
    public partial class timer : Form
    {
        public timer()
        {
            InitializeComponent();
        }

        private void timer_Load(object sender, EventArgs e)
        {
            textBox1.Text = "00:00";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled )
            {
                timer1.Enabled = false;
                btStart.Text = "开始计时";
            }
            else
            {
                timer1.Enabled = true;
                btStart.Text = "停止计时";
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int minutes = Convert.ToInt32(textBox1.Text.Substring(0,2));
            int seconds = Convert.ToInt32(textBox1.Text.Substring(3,2));
            seconds++;
            if (seconds>59)
            {
                minutes += 1;
                seconds = 0;
            }
            if (minutes<10&&seconds<10)
            {
                textBox1.Text = $"0{minutes.ToString()}:0{seconds.ToString()}";
            }
            else if (minutes>9&&seconds>9)
            {
                textBox1.Text = $"{minutes.ToString()}:{seconds.ToString()}";
            }
            else if (minutes>9&&seconds<10)
            {
                textBox1.Text = $"{minutes.ToString()}:0{seconds.ToString()}";
            }
            else
            {
                textBox1.Text = $"0{minutes.ToString()}:{seconds.ToString()}";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00:00";
            timer1.Enabled = false;
            btStart.Text = "开始计时";
        }
    }
}
