namespace 信息管理
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClearInput = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbDepart = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CbGender = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btIncrease = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDepart = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancle = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbCheckName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btClearInput);
            this.groupBox1.Controls.Add(this.btClear);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btChange);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.tbDepart);
            this.groupBox1.Controls.Add(this.tbTel);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.CbGender);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.btIncrease);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbDepart);
            this.groupBox1.Controls.Add(this.lbTel);
            this.groupBox1.Controls.Add(this.lbGender);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Location = new System.Drawing.Point(8, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑操作";
            // 
            // btClearInput
            // 
            this.btClearInput.Location = new System.Drawing.Point(258, 191);
            this.btClearInput.Name = "btClearInput";
            this.btClearInput.Size = new System.Drawing.Size(91, 28);
            this.btClearInput.TabIndex = 16;
            this.btClearInput.Text = "清空输入";
            this.btClearInput.UseVisualStyleBackColor = true;
            this.btClearInput.Click += new System.EventHandler(this.btClearInput_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(258, 151);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(91, 28);
            this.btClear.TabIndex = 15;
            this.btClear.Text = "清空记录";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(258, 111);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(91, 28);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "删除选定行";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(258, 71);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(91, 28);
            this.btChange.TabIndex = 13;
            this.btChange.Text = "修改";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(94, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // tbDepart
            // 
            this.tbDepart.Location = new System.Drawing.Point(94, 152);
            this.tbDepart.Name = "tbDepart";
            this.tbDepart.Size = new System.Drawing.Size(120, 25);
            this.tbDepart.TabIndex = 11;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(94, 111);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(120, 25);
            this.tbTel.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 25);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // CbGender
            // 
            this.CbGender.FormattingEnabled = true;
            this.CbGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.CbGender.Location = new System.Drawing.Point(94, 73);
            this.CbGender.Name = "CbGender";
            this.CbGender.Size = new System.Drawing.Size(67, 23);
            this.CbGender.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(94, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(120, 25);
            this.tbName.TabIndex = 7;
            // 
            // btIncrease
            // 
            this.btIncrease.Location = new System.Drawing.Point(258, 31);
            this.btIncrease.Name = "btIncrease";
            this.btIncrease.Size = new System.Drawing.Size(91, 28);
            this.btIncrease.TabIndex = 6;
            this.btIncrease.Text = "新增";
            this.btIncrease.UseVisualStyleBackColor = true;
            this.btIncrease.Click += new System.EventHandler(this.btIncrease_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "信息完整度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "入职时间";
            // 
            // lbDepart
            // 
            this.lbDepart.AutoSize = true;
            this.lbDepart.Location = new System.Drawing.Point(6, 158);
            this.lbDepart.Name = "lbDepart";
            this.lbDepart.Size = new System.Drawing.Size(53, 15);
            this.lbDepart.TabIndex = 3;
            this.lbDepart.Text = "部  门";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(6, 117);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(53, 15);
            this.lbTel.TabIndex = 2;
            this.lbTel.Text = "电  话";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(6, 76);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(53, 15);
            this.lbGender.TabIndex = 1;
            this.lbGender.Text = "性  别";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 15);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "姓  名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btCancle);
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.tbCheckName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 730);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "点击取消前，请先选定该行";
            // 
            // btCancle
            // 
            this.btCancle.Location = new System.Drawing.Point(252, 67);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(91, 28);
            this.btCancle.TabIndex = 17;
            this.btCancle.Text = "取消";
            this.btCancle.UseVisualStyleBackColor = true;
            this.btCancle.Click += new System.EventHandler(this.btCancle_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(252, 17);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(91, 28);
            this.btSearch.TabIndex = 16;
            this.btSearch.Text = "查询";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbCheckName
            // 
            this.tbCheckName.Location = new System.Drawing.Point(94, 46);
            this.tbCheckName.Name = "tbCheckName";
            this.tbCheckName.Size = new System.Drawing.Size(129, 25);
            this.tbCheckName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "姓  名";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Location = new System.Drawing.Point(363, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 407);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日历及提示";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 68);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(67, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(8, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 383);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 49;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "电话";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 137;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "部门";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "入职时间";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 154;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(791, 851);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbDepart;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CbGender;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btIncrease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDepart;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbCheckName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btCancle;
        private System.Windows.Forms.Button btClearInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

