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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            string gender="";
            string web="";
            foreach (RadioButton item in panel1.Controls)
            {
                //if (item is RadioButton)
                //{
                    //RadioButton newrad = new RadioButton();
                    if (item.Checked)
                    {
                        gender = item.Text;
                    }
                //}              
            }
            foreach (RadioButton item in panel2.Controls)
            {
                if (item.Checked)
                {
                    web = item.Text;
                }             
            }
            MessageBox.Show($"您登记的信息为：\n姓名：{textBox1.Text}\n单位：{textBox2.Text}" +
                $"\n性别：{comboBox1.Text}\n年龄：{numericUpDown1.Value.ToString()}\n种族：" +
                $"{gender}\n最常访问网站：{web}","登记信息");
        }
    }
}
