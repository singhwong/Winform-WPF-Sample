namespace 多功能集成
{
    partial class alarmClork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHH = new System.Windows.Forms.TextBox();
            this.tbMM = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDataTime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 297);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "确定";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "系统时间(格式: 00:00)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "--";
            // 
            // tbHH
            // 
            this.tbHH.Location = new System.Drawing.Point(35, 58);
            this.tbHH.Name = "tbHH";
            this.tbHH.Size = new System.Drawing.Size(51, 21);
            this.tbHH.TabIndex = 0;
            this.tbHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMM
            // 
            this.tbMM.Location = new System.Drawing.Point(113, 58);
            this.tbMM.Name = "tbMM";
            this.tbMM.Size = new System.Drawing.Size(51, 21);
            this.tbMM.TabIndex = 1;
            this.tbMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDataTime);
            this.groupBox1.Controls.Add(this.tbMM);
            this.groupBox1.Controls.Add(this.tbHH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设定时间";
            // 
            // tbDataTime
            // 
            this.tbDataTime.Location = new System.Drawing.Point(35, 31);
            this.tbDataTime.Name = "tbDataTime";
            this.tbDataTime.Size = new System.Drawing.Size(130, 21);
            this.tbDataTime.TabIndex = 6;
            this.tbDataTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMessage);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自定义提醒内容";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(6, 29);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(188, 65);
            this.tbMessage.TabIndex = 2;
            this.tbMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // btClear
            // 
            this.btClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClear.Location = new System.Drawing.Point(137, 297);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "清除设定";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alarmClork
            // 
            this.AcceptButton = this.btStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btClear;
            this.ClientSize = new System.Drawing.Size(223, 353);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "alarmClork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alarmClork";
            this.Load += new System.EventHandler(this.alarmClork_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHH;
        private System.Windows.Forms.TextBox tbMM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDataTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Timer timer1;
    }
}