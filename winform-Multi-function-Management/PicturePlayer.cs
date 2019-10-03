using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多功能集成
{
    public partial class picturePlayer : Form
    {
        public picturePlayer()
        {
            InitializeComponent();
        }
        private int num;
        private string[] pictures = Directory.GetFiles(@"D:\wang\13.2 PictureBox控件（2）\logo图片集");
        private void PicturePlayer_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\john\Documents\美图图库\示例图片_02.jpg");
            btStop.Enabled = false;
        }

        private void btAuto_Click(object sender, EventArgs e)
        {
            btStop.Enabled = true;
            timer1.Interval = (int)numericUpDown1.Value;
            if (timer1.Enabled)
            {
                btAuto.Text = "自动播放";
                timer1.Enabled = false;             
            }
            else
            {
                btAuto.Text = "暂停";
                timer1.Enabled = true;            
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                using (pictureBox1.Image)
                {
                    for (int i = 0; i < pictures.Length; i++)
                    {
                        pictureBox1.Image = Image.FromFile(pictures[i]);
                        if (i == pictures.Length - 1)
                        {
                            i = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
                MessageBox.Show(ex.Message);
                btAuto.Text = "自动播放";
            }
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            try
            {
                num--;
                if (num < 0)
                {
                    num = pictures.Length - 1;
                }
                pictureBox1.Image = Image.FromFile(pictures[num]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                num++;
                if (num > pictures.Length - 1)
                {
                    num = 0;
                }
                pictureBox1.Image = Image.FromFile(pictures[num]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            numericUpDown1.Value = numericUpDown1.Minimum;
            btAuto.Text = "自动播放";
        }
    }
}
