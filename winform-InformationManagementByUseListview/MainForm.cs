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

namespace 信息管理
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string[] pictures = Directory.GetFiles(@"C:\Users\singhwong\Desktop\C#素材\C#素材\13第十三章\13.17-13.21 本章小结及任务实施\banner");
        private void MainForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now.Date;
            progressBar1.Maximum = 5;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;

            pictureBox1.Image = Image.FromFile(@"C:\Users\singhwong\Desktop\C#素材\C#素材\13第十三章\13.17-13.21 本章小结及任务实施\banner\数据无价.PNG");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btIncrease_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.Items.Add((listView1.Items.Count+1).ToString());
            lvi.SubItems.Add(tbName.Text);
            lvi.SubItems.Add(CbGender.Text);
            lvi.SubItems.Add(tbTel.Text);
            lvi.SubItems.Add(tbDepart.Text);
            lvi.SubItems.Add(dateTimePicker1.Value.ToString());
            tbName.Clear();
            CbGender.Text = "";
            tbTel.Clear();
            tbDepart.Clear();
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                listView1.SelectedItems[0].SubItems[1].Text = tbName.Text;
                listView1.SelectedItems[0].SubItems[2].Text = CbGender.Text;
                listView1.SelectedItems[0].SubItems[3].Text = tbTel.Text;
                listView1.SelectedItems[0].SubItems[4].Text = tbDepart.Text;
                listView1.SelectedItems[0].SubItems[5].Text = dateTimePicker1.Value.ToString();
            }
            else
            {
                MessageBox.Show("修改前请先选中需要修改行","错误提示");
            }         
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                listView1.SelectedItems[0].Remove();
            }           
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = 0;
            if (tbName.Text.Trim()!="")
            {
                num++;
            }
            if (CbGender.Text!="")
            {
                num++;
            }
            if (tbTel.Text.Trim()!="")
            {
                num++;
            }
            if (tbDepart.Text.Trim()!="")
            {
                num++;
            }
            if (dateTimePicker1.Value!=dateTimePicker1.MaxDate)
            {
                num++;
            }
            progressBar1.Value = num;
            Random rd = new Random();
            pictureBox1.Image = Image.FromFile(pictures[rd.Next(0,pictures.Length)]);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            ListViewItem lviCheck= listView1.FindItemWithText(tbCheckName.Text);
            //this.listView1.TopItem = liv;
            if (lviCheck!=null)
            {
                lviCheck.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("查询为空，请确认输入是否有误");
                tbCheckName.Clear();
            }
        }

        private void btCancle_Click(object sender, EventArgs e)
        {         
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.ForeColor = Color.Black;
                    item.Selected = false;
                }        
        }

        private void btClearInput_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            CbGender.Text = "";
            tbTel.Clear();
            tbDepart.Clear();
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
        }
    }
}
