namespace Hotel_Management_System
{
    partial class leave
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLeaveNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLeaveStatus = new System.Windows.Forms.ComboBox();
            this.btLeaveEnter = new System.Windows.Forms.Button();
            this.btLeaveCancle = new System.Windows.Forms.Button();
            this.tbLeaveTrad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "房  间  号";
            // 
            // tbLeaveNum
            // 
            this.tbLeaveNum.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLeaveNum.Location = new System.Drawing.Point(99, 8);
            this.tbLeaveNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeaveNum.Name = "tbLeaveNum";
            this.tbLeaveNum.Size = new System.Drawing.Size(165, 29);
            this.tbLeaveNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "房间状态";
            // 
            // cbLeaveStatus
            // 
            this.cbLeaveStatus.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbLeaveStatus.FormattingEnabled = true;
            this.cbLeaveStatus.Items.AddRange(new object[] {
            "可入住",
            "已入住",
            "修缮中",
            "清洁中",
            "其他"});
            this.cbLeaveStatus.Location = new System.Drawing.Point(99, 114);
            this.cbLeaveStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLeaveStatus.Name = "cbLeaveStatus";
            this.cbLeaveStatus.Size = new System.Drawing.Size(165, 28);
            this.cbLeaveStatus.TabIndex = 3;
            // 
            // btLeaveEnter
            // 
            this.btLeaveEnter.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLeaveEnter.Location = new System.Drawing.Point(7, 167);
            this.btLeaveEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLeaveEnter.Name = "btLeaveEnter";
            this.btLeaveEnter.Size = new System.Drawing.Size(75, 46);
            this.btLeaveEnter.TabIndex = 4;
            this.btLeaveEnter.Text = "确  定";
            this.btLeaveEnter.UseVisualStyleBackColor = true;
            this.btLeaveEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLeaveCancle
            // 
            this.btLeaveCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btLeaveCancle.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLeaveCancle.Location = new System.Drawing.Point(189, 167);
            this.btLeaveCancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLeaveCancle.Name = "btLeaveCancle";
            this.btLeaveCancle.Size = new System.Drawing.Size(75, 46);
            this.btLeaveCancle.TabIndex = 5;
            this.btLeaveCancle.Text = "取  消";
            this.btLeaveCancle.UseVisualStyleBackColor = true;
            this.btLeaveCancle.Click += new System.EventHandler(this.btLeaveCancle_Click);
            // 
            // tbLeaveTrad
            // 
            this.tbLeaveTrad.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLeaveTrad.Location = new System.Drawing.Point(99, 61);
            this.tbLeaveTrad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeaveTrad.Name = "tbLeaveTrad";
            this.tbLeaveTrad.Size = new System.Drawing.Size(165, 29);
            this.tbLeaveTrad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "交  易  码";
            // 
            // leave
            // 
            this.AcceptButton = this.btLeaveEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btLeaveCancle;
            this.ClientSize = new System.Drawing.Size(272, 224);
            this.Controls.Add(this.tbLeaveTrad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btLeaveCancle);
            this.Controls.Add(this.btLeaveEnter);
            this.Controls.Add(this.cbLeaveStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLeaveNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "leave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退房登记";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLeaveNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLeaveStatus;
        private System.Windows.Forms.Button btLeaveEnter;
        private System.Windows.Forms.Button btLeaveCancle;
        private System.Windows.Forms.TextBox tbLeaveTrad;
        private System.Windows.Forms.Label label3;
    }
}