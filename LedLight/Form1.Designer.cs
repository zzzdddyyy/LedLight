namespace LedLight
{
    partial class Form1
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
            this.led1 = new LED.LED();
            this.SuspendLayout();
            // 
            // led1
            // 
            this.led1.BorderColor = System.Drawing.Color.LightGray;
            this.led1.BorderWidth = 2;
            this.led1.CenterColor = System.Drawing.Color.White;
            this.led1.Distance = 4;
            this.led1.GridentColor = System.Drawing.Color.LightGreen;
            this.led1.Location = new System.Drawing.Point(12, 12);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(222, 213);
            this.led1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 256);
            this.Controls.Add(this.led1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Led Test Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LED.LED led1;
    }
}

