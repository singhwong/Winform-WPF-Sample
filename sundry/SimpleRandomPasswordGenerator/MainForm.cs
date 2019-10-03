using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 随机密码生成器
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public bool letterCheckedBool = false;
        public bool LETTERCheckedBool = false;
        public bool numberCheckedBool = false;            
        public string letterStr = "abcdefghijklmnopqrstuvwsyz";
        public string LETTERStr = "ABCDEFGHIJKLMNOPQRSTUVWSYZ";
        public string numberStr = "0123456789";

        private void GetCheckedResult(bool numberbool,bool letterbool,bool LETTERbool)
        {
            int index = Convert.ToInt32(numericUpDown1.Value);
            string[] password = new string[index];
            Random letterRad = new Random();
            Random LETTERRad = new Random();
            Random numberRad = new Random();
            Random twoCheckedRad = new Random();
            Random threeCheckedRad = new Random();
            for (int num = 0; num < index; num++)
            {
                if (numberbool == true && letterbool == false && LETTERbool == false)
                {

                    password[num] = (numberStr[numberRad.Next(0, 10)].ToString());

                }
                else if (numberbool == false && letterbool == true && LETTERbool == false)
                {
                    password[num] = (letterStr[letterRad.Next(0, 26)]).ToString();
                }
                else if (numberbool == false && letterbool == false && LETTERbool == true)
                {
                    password[num] = (LETTERStr[LETTERRad.Next(0, 26)].ToString());
                }
                else if (numberbool == true && letterbool == true && LETTERbool == false)
                {
                    switch (twoCheckedRad.Next(0, 2))
                    {
                        case 0: password[num] = (letterStr[letterRad.Next(0, 26)]).ToString(); break;
                        case 1: password[num] = (numberStr[numberRad.Next(0, 10)].ToString()); break;
                    }
                }
                else if (numberbool == false && letterbool == true && LETTERbool == true)
                {
                    switch (twoCheckedRad.Next(0, 2))
                    {
                        case 0: password[num] = (letterStr[letterRad.Next(0, 26)]).ToString(); break;
                        case 1: password[num] = (LETTERStr[LETTERRad.Next(0, 26)].ToString()); break;
                    }
                }
                else if (numberbool == true && letterbool == false && LETTERbool == true)
                {
                    switch (twoCheckedRad.Next(0, 2))
                    {
                        case 0: password[num] = (numberStr[numberRad.Next(0, 10)].ToString()); break;
                        case 1: password[num] = (LETTERStr[LETTERRad.Next(0, 26)].ToString()); break;
                    }
                }
                else if(numberbool == true && letterbool == true && LETTERbool == true)
                {
                    switch (threeCheckedRad.Next(0, 3))
                    {
                        case 0: password[num] = (letterStr[letterRad.Next(0, 26)]).ToString(); break;
                        case 1: password[num] = (LETTERStr[LETTERRad.Next(0, 26)].ToString()); break;
                        case 2: password[num] = (numberStr[numberRad.Next(0, 10)].ToString()); break;
                    }
                }
                   
            }
            foreach (string item in password)
            {
                textBox1.Text += item;
            }
        }

        private void btMake_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numberCheckedBool = false;
            letterCheckedBool = false;
            LETTERCheckedBool = false;
           
          
                foreach (string item in checkedListBox1.CheckedItems)
                {
                    if (item.Contains("字母小写"))
                    {
                        letterCheckedBool = true;
                    }
                    if (item.Contains("字母大写"))
                    {
                        LETTERCheckedBool = true;
                    }
                    if (item.Contains("数字"))
                    {
                        numberCheckedBool = true;
                    }
                }
            if (numberCheckedBool == false && letterCheckedBool == false && LETTERCheckedBool == false)
            {
                MessageBox.Show("请先勾选密码种类", "错误提示");
            }
            GetCheckedResult(numberCheckedBool, letterCheckedBool, LETTERCheckedBool);                 
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = numericUpDown1.Minimum;           
            checkedListBox1.SetItemCheckState(0, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(1, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(2, CheckState.Unchecked);
        }
    }
}
