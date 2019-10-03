namespace 多功能集成
{
    partial class Era
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
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbYear
            // 
            this.tbYear.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tbYear.Location = new System.Drawing.Point(12, 13);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(77, 21);
            this.tbYear.TabIndex = 0;
            this.tbYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResult
            // 
            this.tbResult.ForeColor = System.Drawing.Color.Maroon;
            this.tbResult.Location = new System.Drawing.Point(106, 12);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(106, 57);
            this.tbResult.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Era
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(224, 81);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Era";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天干地支生肖";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button button1;
    }
}