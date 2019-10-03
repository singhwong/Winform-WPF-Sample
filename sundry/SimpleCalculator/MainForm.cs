using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSimpleCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public bool clickhappen = false;
        public double firstnum;
        double result;
        public string symbol;
        public bool equalsign=false;
        private void MainForm_Load(object sender, EventArgs e)
        {
            //textBox2.Text = "0";
        }

        private void zerobtn_Click(object sender, EventArgs e)
        {
            if (clickhappen == false)
            {
                if (equalsign==true)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    equalsign = false;
                }
                if (textBox2.Text == "0")//若第一个数字为0，紧接着再次输入0时，会只显示一个0
                {
                    textBox2.Text = "0";
                    //textBox1.Text += textBox2.Text ;
                }
                else
                {
                    textBox1.Text += "0";
                    textBox2.Text += "0";
                }
            }

            else//clickhappen为true表示已经输入了运算符号
            {
                if (symbol == "÷")//输入÷后，再输入0提示错误，并清空显示
                {
                    textBox2.Clear();
                    textBox1.Clear();
                    MessageBox.Show("输入有误", "错误提示");
                }

                textBox2.Clear();
                clickhappen = false;
            }
         
            
            
        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//clickhappen为true表示已经输入了运算符号
            {
                textBox2.Clear();
                clickhappen = false;
            }
            if (textBox2.Text=="0")//当显示框里只有0，输入数字后，会清空0，接下来只显示输入的数字
            {
                textBox2.Clear();
                textBox1.Clear();
            }
            if (equalsign)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
            {
                textBox1.Clear();
                textBox2.Clear();
                equalsign = false;
            }
            textBox1.Text += "1";
            textBox2.Text += "1";
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//clickhappen为true表示已经输入了运算符号
            {
                textBox2.Clear();
                clickhappen = false;
            }
            if (textBox2.Text == "0")//当显示框里只有0，输入数字后，会清空0，接下来只显示输入的数字
            {
                textBox2.Clear();
                textBox1.Clear();
            }
            if (equalsign)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
            {
                textBox1.Clear();
                textBox2.Clear();
                equalsign = false;
            }
            textBox1.Text += "2";
            textBox2.Text += "2";           
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//clickhappen为true表示已经输入了运算符号
            {
                textBox2.Clear();
                clickhappen = false;
            }
            if (textBox2.Text == "0")//当显示框里只有0，输入数字后，会清空0，接下来只显示输入的数字
            {
                textBox2.Clear();
                textBox1.Clear();
            }
            if (equalsign)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
            {
                textBox1.Clear();
                textBox2.Clear();
                equalsign = false;
            }
            textBox1.Text += "3";
            textBox2.Text += "3";            
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//clickhappen为true表示已经输入了运算符号
            {
                textBox2.Clear();
                clickhappen = false;
            }
            if (textBox2.Text == "0")//当显示框里只有0，输入数字后，会清空0，接下来只显示输入的数字
            {
                textBox2.Clear();
                textBox1.Clear();
            }
            if (equalsign)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
            {
                textBox1.Clear();
                textBox2.Clear();
                equalsign = false;
            }
            textBox1.Text += "4";
            textBox2.Text += "4";           
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//clickhappen为true表示已经输入了运算符号
            {
                textBox2.Clear();
                clickhappen = false;
            }
            if (textBox2.Text == "0")//当显示框里只有0，输入数字后，会清空0，接下来只显示输入的数字
            {
                textBox2.Clear();
                textBox1.Clear();
            }
            if (equalsign)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
            {
                textBox1.Clear();
                textBox2.Clear();
                equalsign = false;
            }
            textBox1.Text += "5";
            textBox2.Text += "5";          
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//clickhappen为true表示已经输入了运算符号
            {
                textBox2.Clear();
                clickhappen = false;
            }
            if (textBox2.Text == "0")//当显示框里只有0，输入数字后，会清空0，接下来只显示输入的数字
            {
                textBox2.Clear();
                textBox1.Clear();
            }
            if (equalsign)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
            {
                textBox1.Clear();
                textBox2.Clear();
                equalsign = false;
            }
            textBox1.Text += "6";
            textBox2.Text += "6";          
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//clickhappen为true表示已经输入了运算符号
            {
                textBox2.Clear();
                clickhappen = false;
            }
            if (textBox2.Text == "0")//当显示框里只有0，输入数字后，会清空0，接下来只显示输入的数字
            {
                textBox2.Clear();
                textBox1.Clear();
            }
            if (equalsign)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
            {
                textBox1.Clear();
                textBox2.Clear();
                equalsign = false;
            }
            textBox1.Text += "7";
            textBox2.Text += "7";          
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//clickhappen为true表示已经输入了运算符号
            {
                textBox2.Clear();
                clickhappen = false;
            }
            if (textBox2.Text == "0")//当显示框里只有0，输入数字后，会清空0，接下来只显示输入的数字
            {
                textBox2.Clear();
                textBox1.Clear();
            }
            if (equalsign)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
            {
                textBox1.Clear();
                textBox2.Clear();
                equalsign = false;
            }
            textBox1.Text += "8";
            textBox2.Text += "8";
            
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//clickhappen为true表示已经输入了运算符号
            {
                textBox2.Clear();
                clickhappen = false;
            }
            if (textBox2.Text == "0")//当显示框里只有0，输入数字后，会清空0，接下来只显示输入的数字
            {
                textBox2.Clear();
                textBox1.Clear();
            }
            if (equalsign)//算出结果后，没有点击清除键直接重新输入数字的话，会自动清空并重新开始
            {
                textBox1.Clear();
                textBox2.Clear();
                equalsign = false;
            }
            textBox1.Text += "9";
            textBox2.Text += "9";            
        }

        private void dotbtn_Click(object sender, EventArgs e)
        {
            if (clickhappen)//输入运算符后，当只输入"."事，会自动显示为"0."
            {
                textBox2.Clear();
                textBox2.Text = "0.";
                textBox1.Text = textBox1.Text + "0.";
                clickhappen = false;
            }
            else
            {
                if (textBox2.Text=="")//第一个字符就输入"."时，会自动显示为"0."
                {
                    textBox2.Text = "0.";
                    textBox1.Text = "0.";
                }
                else
                {
                    textBox2.Text = textBox2.Text + ".";
                    textBox1.Text = textBox1.Text + ".";
                }
                
            }
           
        }

        private void percentbt_Click(object sender, EventArgs e)
        {
            try
            {
                symbol = "%";
                clickhappen = true;
                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text += "%";
            }
            catch 
            {
                MessageBox.Show("输入有误", "错误提示");
            }        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                symbol = "+";
                clickhappen = true;
                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text += "+";
            }
            catch 
            {
                MessageBox.Show("输入有误", "错误提示");
            }          
        }

        private void subtractbtn_Click(object sender, EventArgs e)
        {
            try
            {
                symbol = "-";
                clickhappen = true;
                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text += "-";
            }
            catch
            {
                MessageBox.Show("输入有误", "错误提示");
            }            
        }

        private void multiplybtn_Click(object sender, EventArgs e)
        {
            try
            {
                symbol = "×";
                clickhappen = true;
                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text += "×";
            }
            catch
            {
                MessageBox.Show("输入有误", "错误提示");
            }           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                symbol = "÷";
                clickhappen = true;
                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text += "÷";
            }
            catch
            {
                MessageBox.Show("输入有误", "错误提示");
            }         
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            try
            {
                symbol = "1/x";
                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text = "1/" + textBox1.Text;
            }
            catch
            {
                MessageBox.Show("输入有误", "错误提示");
            }           
        }

        private void squarebtn_Click(object sender, EventArgs e)
        {
            try
            {
                symbol = "x^2";
                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text += "^2";
            }
            catch
            {
                MessageBox.Show("输入有误", "错误提示");
            }           
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            equalsign = true;
            try
            {
                switch (symbol)
                {
                    case "+":
                        result = firstnum + Convert.ToDouble(textBox2.Text);
                        break;
                    case "-":
                        result = firstnum - Convert.ToDouble(textBox2.Text);
                        break;
                    case "×":
                        result = firstnum * Convert.ToDouble(textBox2.Text);
                        break;
                    case "÷":
                        result = firstnum / Convert.ToDouble(textBox2.Text);
                        break;
                    case "%":
                        result = firstnum % Convert.ToDouble(textBox2.Text);
                        break;
                    case "x^2":
                        result = Math.Pow(firstnum, 2);
                        ; break;
                    case "1/x":
                        result = 1 / firstnum;
                        break;
                }
                textBox1.Text = textBox1.Text + "=" + result.ToString();
                textBox2.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("输入有误", "错误提示");
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
