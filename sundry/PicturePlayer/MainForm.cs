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

namespace PictureBox3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public int time;
        public int index=1;
        public string[] str = Directory.GetFiles(@"C:\Users\singhwong\source\repos\图片素材");
        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\singhwong\source\repos\图片素材\003.jpg");
            
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            index++;
            if (index > str.Length - 1)
            {
                index = 0;
            }
            pictureBox1.Image = Image.FromFile(str[index]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
  
            index--;
            if (index < 0)
            {
                index = str.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(str[index]);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            index++;
            if (index > str.Length - 1)
            {
                index = 0;
            }
            pictureBox1.Image = Image.FromFile(str[index]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            time = Convert.ToInt32(numericUpDown1.Value)*1000;
            timer1.Interval = time;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
