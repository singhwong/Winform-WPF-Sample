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
    public partial class randomPassword : Form
    {
        public randomPassword()
        {
            InitializeComponent();
        }
        private string LETTER = "ABCDEFGHIJKLMNOPQRSTUVWSYZ";
        private string letter = "abcdefghijklmnopqrstuvwsyz";
        private string number = "0123456789";
        private string chars = @"~!@#$%^&*_?";
        private bool LETTER_bool = false;
        private bool letter_bool = false;
        private bool number_bool = false;
        private bool chars_bool = false;
        private Random ran_dom = new Random();
        private int pwdindex;
        private int count;
        private void btStart_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LETTER_bool = false;
            letter_bool = false;
            number_bool = false;
            chars_bool = false;
            pwdindex = Convert.ToInt32(numericUpDown1.Value);
            OutBool();
            if (LETTER_bool == false && letter_bool == false && number_bool == false && chars_bool == true)
            {
                MessageBox.Show("密码不能全为符号，请重新选择", "错误提示");
                checkedListBox1.SetItemChecked(3, false);
            }
            else
            {
                count = checkedListBox1.CheckedItems.Count;
                switch (count)
                {
                    case 1: OneCheckInput(); break;
                    case 2: TwoCheckInput(); break;
                    case 3: ThreeCheckInput(); break;
                    case 4: FourCheckInput(); break;
                }
            }
        }

        private void OutBool()
        {
            if (checkedListBox1.CheckedItems.Contains("字母大写"))
            {
                LETTER_bool = true;
            }
            if (checkedListBox1.CheckedItems.Contains("字母小写"))
            {
                letter_bool = true;
            }
            if (checkedListBox1.CheckedItems.Contains("数字"))
            {
                number_bool = true;
            }
            if (checkedListBox1.CheckedItems.Contains("特殊字符"))
            {
                chars_bool = true;
            }
        }

        private void OneCheckInput()
        {
            for (int i = 0; i < pwdindex; i++)
            {
                if (LETTER_bool == true && letter_bool == false && number_bool == false && chars_bool == false)
                {
                    textBox1.Text += LETTER[ran_dom.Next(0, 26)];
                }
                else if (LETTER_bool == false && letter_bool == true && number_bool == false && chars_bool == false)
                {
                    textBox1.Text += letter[ran_dom.Next(0, 26)];
                }
                else if (LETTER_bool == false && letter_bool == false && number_bool == true && chars_bool == false)
                {
                    textBox1.Text += number[ran_dom.Next(0, 10)];
                }

            }
        }
        private void TwoCheckInput()
        {
            for (int i = 0; i < pwdindex; i++)
            {
                if (LETTER_bool == true && letter_bool == true && number_bool == false && chars_bool == false)
                {
                    switch (ran_dom.Next(0, 2))
                    {
                        case 0: textBox1.Text += LETTER[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += letter[ran_dom.Next(0, 26)]; break;
                    }
                }
                else if (LETTER_bool == true && letter_bool == false && number_bool == true && chars_bool == false)
                {
                    switch (ran_dom.Next(0, 2))
                    {
                        case 0: textBox1.Text += LETTER[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += number[ran_dom.Next(0, 10)]; break;
                    }
                }
                else if (LETTER_bool == true && letter_bool == false && number_bool == false && chars_bool == true)
                {
                    switch (ran_dom.Next(0, 2))
                    {
                        case 0: textBox1.Text += LETTER[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += chars[ran_dom.Next(0, chars.Length)]; break;
                    }
                }
                else if (LETTER_bool == false && letter_bool == true && number_bool == true && chars_bool == false)
                {
                    switch (ran_dom.Next(0, 2))
                    {
                        case 0: textBox1.Text += letter[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += number[ran_dom.Next(0, 10)]; break;
                    }
                }
                else if (LETTER_bool == false && letter_bool == true && number_bool == false && chars_bool == true)
                {
                    switch (ran_dom.Next(0, 2))
                    {
                        case 0: textBox1.Text += letter[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += chars[ran_dom.Next(0, chars.Length)]; break;
                    }
                }
                else if (LETTER_bool == false && letter_bool == false && number_bool == true && chars_bool == true)
                {
                    switch (ran_dom.Next(0, 2))
                    {
                        case 0: textBox1.Text += number[ran_dom.Next(0, 10)]; break;
                        case 1: textBox1.Text += chars[ran_dom.Next(0, chars.Length)]; break;
                    }
                }
            }
        }
        private void ThreeCheckInput()
        {
            for (int i = 0; i < pwdindex; i++)
            {
                if (LETTER_bool == true && letter_bool == true && number_bool == true && chars_bool == false)
                {
                    switch (ran_dom.Next(0, 3))
                    {
                        case 0: textBox1.Text += LETTER[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += letter[ran_dom.Next(0, 26)]; break;
                        case 2: textBox1.Text += number[ran_dom.Next(0, 10)]; break;
                    }
                }
                else if (LETTER_bool == true && letter_bool == true && number_bool == false && chars_bool == true)
                {
                    switch (ran_dom.Next(0, 3))
                    {
                        case 0: textBox1.Text += LETTER[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += letter[ran_dom.Next(0, 26)]; break;
                        case 2: textBox1.Text += chars[ran_dom.Next(0, chars.Length)]; break;
                    }
                }
                else if (LETTER_bool == true && letter_bool == false && number_bool == true && chars_bool == true)
                {
                    switch (ran_dom.Next(0, 3))
                    {
                        case 0: textBox1.Text += LETTER[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += number[ran_dom.Next(0, 10)]; break;
                        case 2: textBox1.Text += chars[ran_dom.Next(0, chars.Length)]; break;
                    }
                }
                else if (LETTER_bool == false && letter_bool == true && number_bool == true && chars_bool == true)
                {
                    switch (ran_dom.Next(0, 3))
                    {
                        case 0: textBox1.Text += number[ran_dom.Next(0, 10)]; break;
                        case 1: textBox1.Text += letter[ran_dom.Next(0, 26)]; break;
                        case 2: textBox1.Text += chars[ran_dom.Next(0, chars.Length)]; break;
                    }
                }
                else if (LETTER_bool == true && letter_bool == false && number_bool == true && chars_bool == true)
                {
                    switch (ran_dom.Next(0, 3))
                    {
                        case 0: textBox1.Text += LETTER[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += number[ran_dom.Next(0, 10)]; break;
                        case 2: textBox1.Text += chars[ran_dom.Next(0, chars.Length)]; break;
                    }
                }
            }
        }
        private void FourCheckInput()
        {
            for (int i = 0; i < pwdindex; i++)
            {
                if (LETTER_bool == true && letter_bool == true && number_bool == true && chars_bool == true)
                {
                    switch (ran_dom.Next(0, 4))
                    {
                        case 0: textBox1.Text += LETTER[ran_dom.Next(0, 26)]; break;
                        case 1: textBox1.Text += number[ran_dom.Next(0, 10)]; break;
                        case 2: textBox1.Text += chars[ran_dom.Next(0, chars.Length)]; break;
                        case 3: textBox1.Text += letter[ran_dom.Next(0, 26)]; break;
                    }
                }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = numericUpDown1.Minimum;
            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
            checkedListBox1.SetItemChecked(3, false);
        }
    }
}
