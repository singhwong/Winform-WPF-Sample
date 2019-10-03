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
    public partial class calcuLator : Form
    {
        public calcuLator()
        {
            InitializeComponent();
        }
        private bool IsOperator = false;//判断是否按过运算符，按后为true，按"="后为false
        string operatorStr;//运算符字符串
        string firstNum;//运算符左边的数值字符串
        private double result;//运算结果字符串
        private bool ClearBool = false;//判定有无按下"="，若按下了，为true,
        private int dotclickNum = 0;//只有为0时，才会显示".",实现运算符前后，都只能显示一次
        private int negativeClick = 0;//和dotclickNum原理类似，为0时，才会显示"-"负号
        private void calcuLator_Load(object sender, EventArgs e)
        {
            //暂时完成编写，后续优化代码
            tbHistory.Enabled = false;
            tbValue.Enabled = false;
            tbValue.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ClearBool)
            {
                tbValue.Clear();
                ClearBool = false;
            }
            if (tbValue.Text == "0"|| tbValue.Text == "")
            {
                tbValue.Text = "0";
            }
            else
            {
                tbValue.Text += "0";
                tbHistory.Text += "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SameOperatorCode("%");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tbValue.Text != "0" && tbValue.Text != "除数不能为零")
            {
                ReduceCode("√");
                tbHistory.Text = "√" + firstNum;
                result = Math.Sqrt(Convert.ToDouble(firstNum));
                tbValue.Text = result.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (tbValue.Text != "0" && tbValue.Text != "除数不能为零")
            {
                ReduceCode("x");
                tbHistory.Text = firstNum + "²";
                result = Convert.ToDouble(firstNum) * Convert.ToDouble(firstNum);
                tbValue.Text = result.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (tbValue.Text != "0" && tbValue.Text != "除数不能为零")
            {
                ReduceCode("¹/x");
                tbHistory.Text = "1/" + firstNum;
                result = Convert.ToDouble("1") / Convert.ToDouble(firstNum);
                tbValue.Text = result.ToString();
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            SameOperatorCode("÷");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SameOperatorCode("×");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SameOperatorCode("-");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SameOperatorCode("+");

        }
        private void SameOperatorCode(string operatorStr)
        {
            if (ClearBool == false)
            {
                if (tbValue.Text != "")
                {
                    tbHistory.Text += operatorStr;
                }
            }
            else//为true时，即按下"="后，紧接着又按下运算符，会进行正常运算
            {
                tbHistory.Text = tbValue.Text + operatorStr;
                ClearBool = false;
            }
            IsOperator = true;
            firstNum = tbValue.Text;
            tbValue.Clear();
            this.operatorStr = operatorStr;
            dotclickNum = 0;
            negativeClick = 0;
        }
        private void SameNumberCode(int num)
        {
            if (tbValue.Text == "0" || tbValue.Text == "除数不能为零")
            {
                tbValue.Clear();
            }
            if (ClearBool)
            {
                tbValue.Clear();
                ClearBool = false;
            }

            if (IsOperator == false)
            {
                if (tbValue.Text == ".")
                {
                    tbValue.Text = "0." + num.ToString();
                    tbHistory.Text = "0." + num.ToString();
                }
                else
                {
                    tbValue.Text += num.ToString();
                    tbHistory.Text += num.ToString();
                }
            }
            else
            {
                if (tbValue.Text == ".")
                {
                    tbValue.Text = "0." + num.ToString();
                }
                else
                {
                    tbValue.Text += num.ToString();
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SameNumberCode(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SameNumberCode(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SameNumberCode(3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SameNumberCode(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SameNumberCode(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SameNumberCode(6);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SameNumberCode(7);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SameNumberCode(8);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SameNumberCode(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (ClearBool)
            {
                tbValue.Text = "0";
                tbHistory.Clear();
                ClearBool = false;
            }
            if (dotclickNum == 0)
            {

                if (tbValue.Text == "0")
                {
                    if (IsOperator)
                    {
                        tbValue.Text = "0.";
                    }
                    else
                    {
                        tbValue.Text = "0.";
                        tbHistory.Text = "0.";
                    }
                }
                else
                {
                    if (IsOperator)
                    {
                        tbValue.Text += ".";
                    }
                    else
                    {
                        tbValue.Text += ".";
                        tbHistory.Text += ".";
                    }
                }
                dotclickNum++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operatorStr == "÷" && tbValue.Text == "0")
            {
                tbValue.Text = "除数不能为零";
            }
            else
            {
                switch (operatorStr)
                {
                    case "+": result = Convert.ToDouble(firstNum) + Convert.ToDouble(tbValue.Text); break;
                    case "-": result = Convert.ToDouble(firstNum) - Convert.ToDouble(tbValue.Text); break;
                    case "×": result = Convert.ToDouble(firstNum) * Convert.ToDouble(tbValue.Text); break;
                    case "÷": result = Convert.ToDouble(firstNum) / Convert.ToDouble(tbValue.Text); break;
                    case "%": result = Math.IEEERemainder(Convert.ToDouble(firstNum), Convert.ToDouble(tbValue.Text)); break;
                    case "√": result = Math.Sqrt(Convert.ToDouble(firstNum)); break;
                    case "x²": result = Convert.ToDouble(firstNum) * Convert.ToDouble(firstNum); break;
                    case "¹/x": result = Convert.ToDouble("1") / Convert.ToDouble(firstNum); break;
                    case "log": result = Math.Log(Convert.ToDouble(firstNum)); break;
                }
                tbValue.Text = result.ToString();
            }
            tbHistory.Clear();
            ClearBool = true;
            dotclickNum = 0;
            IsOperator = false;
            operatorStr = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tbValue.Text = "0";
            tbHistory.Clear();
            negativeClick = 0;
            dotclickNum = 0;
            ClearBool = false;
            IsOperator = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (tbValue.Text != "0" && tbValue.Text != "除数不能为零")
            {
                ReduceCode("log");
                tbHistory.Text = "log" + firstNum;
                result = Math.Log(Convert.ToDouble(firstNum));
                tbValue.Text = result.ToString();
            }

        }
        private void ReduceCode(string str)
        {
            firstNum = tbValue.Text;
            operatorStr = str;
            ClearBool = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (tbValue.Text == "0" || tbValue.Text == "除数不能为零")
            {
                tbValue.Text = "0";
            }
            if (ClearBool)
            {
                tbValue.Text = "0";
                ClearBool = false;
            }

            if (negativeClick == 0)
            {
                if (tbValue.Text != "0")
                {
                    if (IsOperator)
                    {
                        tbValue.Text = "-" + tbValue.Text;
                    }
                    else
                    {
                        tbValue.Text = "-" + tbValue.Text;
                        tbHistory.Text = "-" + tbHistory.Text;
                    }
                    negativeClick++;
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (ClearBool == false)
            {
                if (IsOperator)
                {
                    if (tbValue.Text != "")
                    {
                        tbValue.Text = tbValue.Text.Substring(0, tbValue.Text.Length - 1);
                    }
                }
                else
                {
                    if (tbHistory.Text != "")
                    {
                        tbValue.Text = tbValue.Text.Substring(0, tbValue.Text.Length - 1);
                        tbHistory.Text = tbHistory.Text.Substring(0, tbHistory.Text.Length - 1);
                    }

                }
            }

        }
    }
}
