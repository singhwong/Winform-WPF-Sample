namespace 多功能集成
{
    partial class picturePlayer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAuto = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 446);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btAuto
            // 
            this.btAuto.Location = new System.Drawing.Point(344, 60);
            this.btAuto.Name = "btAuto";
            this.btAuto.Size = new System.Drawing.Size(75, 23);
            this.btAuto.TabIndex = 1;
            this.btAuto.Text = "自动播放";
            this.btAuto.UseVisualStyleBackColor = true;
            this.btAuto.Click += new System.EventHandler(this.btAuto_Click);
            // 
            // btLast
            // 
            this.btLast.Location = new System.Drawing.Point(344, 110);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(75, 23);
            this.btLast.TabIndex = 2;
            this.btLast.Text = "上一张";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(344, 160);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 3;
            this.btNext.Text = "下一张";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(344, 210);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "停止";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(345, 12);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 21);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picturePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 470);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btAuto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "picturePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PicturePlayer";
            this.Load += new System.EventHandler(this.PicturePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAuto;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
    }
}