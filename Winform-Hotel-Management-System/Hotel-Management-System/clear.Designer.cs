namespace Hotel_Management_System
{
    partial class clear
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
            this.btClearCancle = new System.Windows.Forms.Button();
            this.btClearEnter = new System.Windows.Forms.Button();
            this.cbClearStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClearNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btClearCancle
            // 
            this.btClearCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClearCancle.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearCancle.Location = new System.Drawing.Point(193, 154);
            this.btClearCancle.Name = "btClearCancle";
            this.btClearCancle.Size = new System.Drawing.Size(75, 46);
            this.btClearCancle.TabIndex = 4;
            this.btClearCancle.Text = "取  消";
            this.btClearCancle.UseVisualStyleBackColor = true;
            this.btClearCancle.Click += new System.EventHandler(this.btClearCancle_Click);
            // 
            // btClearEnter
            // 
            this.btClearEnter.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearEnter.Location = new System.Drawing.Point(12, 154);
            this.btClearEnter.Name = "btClearEnter";
            this.btClearEnter.Size = new System.Drawing.Size(75, 46);
            this.btClearEnter.TabIndex = 3;
            this.btClearEnter.Text = "确  定";
            this.btClearEnter.UseVisualStyleBackColor = true;
            this.btClearEnter.Click += new System.EventHandler(this.btClearEnter_Click);
            // 
            // cbClearStatus
            // 
            this.cbClearStatus.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbClearStatus.FormattingEnabled = true;
            this.cbClearStatus.Items.AddRange(new object[] {
            "可入住",
            "已入住",
            "修缮中",
            "清洁中",
            "其他"});
            this.cbClearStatus.Location = new System.Drawing.Point(103, 82);
            this.cbClearStatus.Name = "cbClearStatus";
            this.cbClearStatus.Size = new System.Drawing.Size(165, 28);
            this.cbClearStatus.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "房间状态";
            // 
            // tbClearNum
            // 
            this.tbClearNum.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbClearNum.Location = new System.Drawing.Point(103, 7);
            this.tbClearNum.Name = "tbClearNum";
            this.tbClearNum.Size = new System.Drawing.Size(165, 29);
            this.tbClearNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "房  间  号";
            // 
            // clear
            // 
            this.AcceptButton = this.btClearEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btClearCancle;
            this.ClientSize = new System.Drawing.Size(272, 212);
            this.Controls.Add(this.btClearCancle);
            this.Controls.Add(this.btClearEnter);
            this.Controls.Add(this.cbClearStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClearNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "clear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "清扫登记";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClearCancle;
        private System.Windows.Forms.Button btClearEnter;
        private System.Windows.Forms.ComboBox cbClearStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClearNum;
        private System.Windows.Forms.Label label1;
    }
}