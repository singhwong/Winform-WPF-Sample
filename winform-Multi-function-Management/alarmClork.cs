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

namespace 多功能集成
{
    public partial class alarmClork : Form
    {
        public alarmClork()
        {
            InitializeComponent();
        }

        private void alarmClork_Load(object sender, EventArgs e)
        {
            tbDataTime.Text = DateTime.Now.ToString();
            tbDataTime.ForeColor = Color.Blue;
            tbHH.ForeColor = Color.Red;
            tbMM.ForeColor = Color.Red;
            tbMessage.ForeColor = Color.Blue;
            tbHH.Focus();
            tbDataTime.Enabled = false;

        }

        private void btStart_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled)
            {
                btStart.Text = "开始";
                timer1.Enabled = false;
                SoundPlayer sound_player = new SoundPlayer();
                sound_player.Stop();
                tbHH.Clear();
                tbMM.Clear();
                tbMessage.Clear();
                btClear.Enabled = true;
                tbMessage.Enabled = true;
                tbHH.Enabled = true;
                tbMM.Enabled = true;
                textchanged = false;
            }
            else
            {
                btStart.Text = "停止";
                timer1.Enabled = true;
                btClear.Enabled = false;
                tbMessage.Enabled = false;
                tbHH.Enabled = false;
                tbMM.Enabled = false;
                if (textchanged)
                {
                    if (tbMessage.Text.Trim() == "")
                    {
                        timer1.Enabled = false;
                        btStart.Text = "开始";
                        btClear.Enabled = true;
                        tbMessage.Enabled = true;
                        MessageBox.Show("请输入有效内容的提醒内容", "错误提示");
                    }
                }
            }
        }
        private void IfTimeError()
        {

            timer1.Enabled = false;
            btStart.Text = "开始";
            btClear.Enabled = true;
            tbMessage.Enabled = true;
            tbHH.Enabled = true;
            tbMM.Enabled = true;
            MessageBox.Show("请输入有效格式的设定时间", "错误提示");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {



            try
            {
                int hh = Convert.ToInt32(tbHH.Text);
                int mm = Convert.ToInt32(tbMM.Text);
                if (hh >= 0 && hh <= 23 && mm >= 0 && mm <= 59)
                {
                    tbDataTime.Text = DateTime.Now.ToString();
                    SoundPlayer sound_player = new SoundPlayer();
                    sound_player.SoundLocation = @"C: \Users\john\Music\刘增瞳 - 跟我去旅行.wav";
                    if (hh == DateTime.Now.Hour && mm == DateTime.Now.Minute && DateTime.Now.Second == 0)
                    {
                        sound_player.Play();
                        if (textchanged)
                        {
                            MessageBox.Show(tbMessage.Text, "消息提示");
                        }
                    }
                    if (hh == DateTime.Now.Hour && DateTime.Now.Minute == mm + 3)
                    {
                        sound_player.Stop();
                        timer1.Enabled = false;
                        tbHH.Clear();
                        tbMM.Clear();
                        tbMessage.Clear();
                        btStart.Text = "开始";
                        tbHH.Enabled = true;
                        tbMM.Enabled = true;
                        tbMessage.Enabled = true;
                        btClear.Enabled = true;
                    }
                }
                else
                {
                    IfTimeError();
                }
            }
            catch
            {
                IfTimeError();
            }
        }
        public bool textchanged = false;
        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            textchanged = true;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbHH.Clear();
            tbMM.Clear();
            tbMessage.Clear();
            tbHH.Enabled = true;
            tbMM.Enabled = true;
            textchanged = false;
        }
    }
}
