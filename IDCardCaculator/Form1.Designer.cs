namespace IDCardCaculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_IDNumber = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_IDNumber
            // 
            this.textBox_IDNumber.Font = new System.Drawing.Font("宋体", 24F);
            this.textBox_IDNumber.Location = new System.Drawing.Point(12, 12);
            this.textBox_IDNumber.Name = "textBox_IDNumber";
            this.textBox_IDNumber.Size = new System.Drawing.Size(590, 44);
            this.textBox_IDNumber.TabIndex = 0;
            this.textBox_IDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_IDNumber.TextChanged += new System.EventHandler(this.textBox_IDNumber_TextChanged);
            this.textBox_IDNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IDNumber_KeyPress);
            // 
            // button
            // 
            this.button.Enabled = false;
            this.button.Location = new System.Drawing.Point(608, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(84, 44);
            this.button.TabIndex = 1;
            this.button.Text = "计算";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("宋体", 12F);
            this.tip.ForeColor = System.Drawing.Color.DarkRed;
            this.tip.Location = new System.Drawing.Point(12, 68);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(176, 16);
            this.tip.TabIndex = 2;
            this.tip.Text = "*请输入身份证号前17位";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 111);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox_IDNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDCardLastNumberCaculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_IDNumber;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label tip;
    }
}

