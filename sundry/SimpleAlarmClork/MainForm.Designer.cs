﻿namespace SimpleAlarmClork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.htb = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qcbtn = new System.Windows.Forms.Button();
            this.sjbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dttb = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // htb
            // 
            this.htb.Location = new System.Drawing.Point(67, 52);
            this.htb.Margin = new System.Windows.Forms.Padding(2);
            this.htb.Name = "htb";
            this.htb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.htb.Size = new System.Drawing.Size(49, 21);
            this.htb.TabIndex = 2;
            this.htb.TabStop = false;
            this.htb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mtb
            // 
            this.mtb.Location = new System.Drawing.Point(135, 52);
            this.mtb.Margin = new System.Windows.Forms.Padding(2);
            this.mtb.Name = "mtb";
            this.mtb.Size = new System.Drawing.Size(49, 21);
            this.mtb.TabIndex = 4;
            this.mtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // qcbtn
            // 
            this.qcbtn.Location = new System.Drawing.Point(11, 26);
            this.qcbtn.Margin = new System.Windows.Forms.Padding(2);
            this.qcbtn.Name = "qcbtn";
            this.qcbtn.Size = new System.Drawing.Size(52, 21);
            this.qcbtn.TabIndex = 6;
            this.qcbtn.Text = "起床";
            this.qcbtn.UseVisualStyleBackColor = true;
            this.qcbtn.Click += new System.EventHandler(this.qcbtn_Click);
            // 
            // sjbtn
            // 
            this.sjbtn.Location = new System.Drawing.Point(11, 51);
            this.sjbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sjbtn.Name = "sjbtn";
            this.sjbtn.Size = new System.Drawing.Size(52, 21);
            this.sjbtn.TabIndex = 7;
            this.sjbtn.Text = "睡觉";
            this.sjbtn.UseVisualStyleBackColor = true;
            this.sjbtn.Click += new System.EventHandler(this.sjbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "格式：00(小时):00(分钟）";
            // 
            // dttb
            // 
            this.dttb.BackColor = System.Drawing.SystemColors.InfoText;
            this.dttb.ForeColor = System.Drawing.SystemColors.Window;
            this.dttb.Location = new System.Drawing.Point(67, 26);
            this.dttb.Margin = new System.Windows.Forms.Padding(2);
            this.dttb.Name = "dttb";
            this.dttb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dttb.Size = new System.Drawing.Size(117, 21);
            this.dttb.TabIndex = 8;
            this.dttb.TabStop = false;
            this.dttb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMessage);
            this.groupBox1.Location = new System.Drawing.Point(11, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 37);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自定义消息提醒内容";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(6, 16);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(214, 21);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(248, 120);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dttb);
            this.Controls.Add(this.sjbtn);
            this.Controls.Add(this.qcbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb);
            this.Controls.Add(this.htb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "闹钟";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox htb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox mtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button qcbtn;
        private System.Windows.Forms.Button sjbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dttb;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMessage;
    }
}

