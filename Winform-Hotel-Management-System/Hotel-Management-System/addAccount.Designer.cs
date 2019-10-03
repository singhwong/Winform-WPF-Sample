namespace Hotel_Management_System
{
    partial class addAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAccountPower = new System.Windows.Forms.ComboBox();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.tbAccountPwd = new System.Windows.Forms.TextBox();
            this.btAccountEnter = new System.Windows.Forms.Button();
            this.btAccountCancle = new System.Windows.Forms.Button();
            this.tbAccountText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密   码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "权   限";
            // 
            // cbAccountPower
            // 
            this.cbAccountPower.FormattingEnabled = true;
            this.cbAccountPower.Items.AddRange(new object[] {
            "管理员",
            "普通用户",
            "其他"});
            this.cbAccountPower.Location = new System.Drawing.Point(120, 111);
            this.cbAccountPower.Margin = new System.Windows.Forms.Padding(4);
            this.cbAccountPower.Name = "cbAccountPower";
            this.cbAccountPower.Size = new System.Drawing.Size(219, 23);
            this.cbAccountPower.TabIndex = 2;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(120, 31);
            this.tbAccountName.Margin = new System.Windows.Forms.Padding(5);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(219, 25);
            this.tbAccountName.TabIndex = 0;
            // 
            // tbAccountPwd
            // 
            this.tbAccountPwd.Location = new System.Drawing.Point(120, 71);
            this.tbAccountPwd.Margin = new System.Windows.Forms.Padding(5);
            this.tbAccountPwd.Name = "tbAccountPwd";
            this.tbAccountPwd.Size = new System.Drawing.Size(219, 25);
            this.tbAccountPwd.TabIndex = 1;
            // 
            // btAccountEnter
            // 
            this.btAccountEnter.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAccountEnter.Location = new System.Drawing.Point(68, 224);
            this.btAccountEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btAccountEnter.Name = "btAccountEnter";
            this.btAccountEnter.Size = new System.Drawing.Size(100, 32);
            this.btAccountEnter.TabIndex = 4;
            this.btAccountEnter.Text = "确    定";
            this.btAccountEnter.UseVisualStyleBackColor = true;
            this.btAccountEnter.Click += new System.EventHandler(this.btAccountEnter_Click);
            // 
            // btAccountCancle
            // 
            this.btAccountCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAccountCancle.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAccountCancle.Location = new System.Drawing.Point(240, 224);
            this.btAccountCancle.Margin = new System.Windows.Forms.Padding(4);
            this.btAccountCancle.Name = "btAccountCancle";
            this.btAccountCancle.Size = new System.Drawing.Size(100, 32);
            this.btAccountCancle.TabIndex = 5;
            this.btAccountCancle.Text = "取    消";
            this.btAccountCancle.UseVisualStyleBackColor = true;
            this.btAccountCancle.Click += new System.EventHandler(this.btAccountCancle_Click);
            // 
            // tbAccountText
            // 
            this.tbAccountText.Location = new System.Drawing.Point(120, 150);
            this.tbAccountText.Margin = new System.Windows.Forms.Padding(5);
            this.tbAccountText.Multiline = true;
            this.tbAccountText.Name = "tbAccountText";
            this.tbAccountText.Size = new System.Drawing.Size(219, 63);
            this.tbAccountText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "账户名";
            // 
            // addAccount
            // 
            this.AcceptButton = this.btAccountEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btAccountCancle;
            this.ClientSize = new System.Drawing.Size(405, 271);
            this.Controls.Add(this.tbAccountText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAccountCancle);
            this.Controls.Add(this.btAccountEnter);
            this.Controls.Add(this.tbAccountPwd);
            this.Controls.Add(this.tbAccountName);
            this.Controls.Add(this.cbAccountPower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加账号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAccountPower;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.TextBox tbAccountPwd;
        private System.Windows.Forms.Button btAccountEnter;
        private System.Windows.Forms.Button btAccountCancle;
        private System.Windows.Forms.TextBox tbAccountText;
        private System.Windows.Forms.Label label4;
    }
}