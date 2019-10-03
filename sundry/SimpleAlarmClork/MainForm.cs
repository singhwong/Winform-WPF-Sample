using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAlarmClork
{
    public partial class MainForm : Form
    {      
        public MainForm()
        {
            InitializeComponent();
        }

        public int hh, mm;
        public int newint;
        private void timer1_Tick(object sender, EventArgs e)
        {                  
            try
            {
                hh = Convert.ToInt32(htb.Text);//将用户输入的时间字符串隐式转换为int类型
                mm = Convert.ToInt32(mtb.Text);
            }
            catch
            {
                timer1.Enabled = false;
                MessageBox.Show("输入格式有误");               
            }                 
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\john\Music\刘增瞳 - 跟我去旅行.wav";
            if (DateTime.Now.Hour == hh && DateTime.Now.Minute == mm&&DateTime.Now.Second==0)
            {
                sp.PlayLooping();

                switch (newint)
                {
                    case 1:MessageBox.Show("你该起床啦，太阳都晒屁股了！！！", "提示");break;
                    case 2:MessageBox.Show("你该睡觉啦，已经很晚啦！！！", "提示");break;
                }
                if (tbMessage.Text.Trim()!="")
                {
                    MessageBox.Show(tbMessage.Text, "自定义提醒");
                }            
            }
            if (DateTime.Now.Hour==hh&&DateTime.Now.Minute==mm+3&&DateTime.Now.Second==0)
            {
                sp.Stop();
                timer1.Enabled = false;
                qcbtn.Enabled = true;
                sjbtn.Enabled = true;
                button1.Text = "开始";
                tbMessage.Enabled = true;
                tbMessage.Clear();
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)//当timer1为true时，运行一下代码
            {
                button1.Text = "开始";
                htb.Text = "00";
                mtb.Text = "00";
                SoundPlayer sp = new SoundPlayer();
                sp.Stop();//当点击取消时，停止播放音乐
                //timer1.Stop();
                timer1.Enabled = false;
                //timer2.Enabled = false;
                htb.ForeColor = Color.Black;
                mtb.ForeColor = Color.Black;
                //dttb.ForeColor = Color.Black;
                qcbtn.Enabled = true;
                sjbtn.Enabled = true;
                tbMessage.Enabled = true;
                tbMessage.Clear();               
            }
            else//当timer1为false时，运行以下代码
            {
                button1.Text = "停止";
                //timer1.Start();
                timer1.Enabled = true;
                //timer2.Enabled = true;
                htb.ForeColor = Color.Red;
                mtb.ForeColor = Color.Red;
                //dttb.ForeColor = Color.Blue;
                tbMessage.Enabled = false;                
            }           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //htb.Focus();
            htb.Text = "00";//显示开始时间为00:00
            mtb.Text = "00";
            if (DateTime.Now.Second < 10)
            {
                dttb.Text = DateTime.Now.ToShortTimeString() + ":0" + DateTime.Now.Second;
            }
            else
            {
                dttb.Text = DateTime.Now.ToShortTimeString() + ":" + DateTime.Now.Second;
            }
            tbMessage.ForeColor = Color.Red;
        }

        private void qcbtn_Click(object sender, EventArgs e)
        {
            newint = 1;
            qcbtn.Enabled = false;
            sjbtn.Enabled = false;
            tbMessage.Enabled = false;
        }

        private void sjbtn_Click(object sender, EventArgs e)
        {
            newint = 2;
            sjbtn.Enabled = false;
            qcbtn.Enabled = false;
            tbMessage.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (DateTime.Now.Second<10)
            {
                dttb.Text = DateTime.Now.ToShortTimeString() + ":0"+DateTime.Now.Second;
            }
            else
            {
                dttb.Text = DateTime.Now.ToShortTimeString() + ":" + DateTime.Now.Second;
            }          
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            qcbtn.Enabled = false;
            sjbtn.Enabled = false;
        }


    }
}
