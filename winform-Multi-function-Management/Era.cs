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
    public partial class Era : Form
    {
        public Era()
        {
            InitializeComponent();
        }
        public string tiangan = "甲乙丙丁戊己庚辛壬癸";
        public string dizhi = "子丑寅卯辰巳午未申酉戌亥";
        public string shengxiao = "鼠牛虎兔龙蛇马羊猴鸡狗猪";
        public int Year;
        public int tgIndex;
        public int dzIndex;
        public int sxIndex;
        private void button1_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
            Year = Convert.ToInt32(tbYear.Text);
            tgIndex = (Year - 4) % 10;
            dzIndex = (Year - 4) % 12;
            sxIndex = (Year - 4) % 12;
            tbResult.AppendText($"{tiangan[tgIndex]}{dizhi[dzIndex]} 年\n");
            tbResult.AppendText($"生肖为: {shengxiao[sxIndex]}");
            tbYear.Clear();
        }
    }
}
