namespace kc3_委托_事件
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTripperByEvent1 = new kc3_委托_事件.ButtonTripperByEvent();
            this.buttonTripper1 = new kc3_委托_事件.ButtonTripper();
            this.buttonTripperByEventHandler1 = new kc3_委托_事件.ButtonTripperByEventHandler();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "注册事件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTripperByEvent1
            // 
            this.buttonTripperByEvent1.Location = new System.Drawing.Point(33, 105);
            this.buttonTripperByEvent1.Name = "buttonTripperByEvent1";
            this.buttonTripperByEvent1.Size = new System.Drawing.Size(146, 53);
            this.buttonTripperByEvent1.TabIndex = 2;
            // 
            // buttonTripper1
            // 
            this.buttonTripper1.Location = new System.Drawing.Point(199, 33);
            this.buttonTripper1.Name = "buttonTripper1";
            this.buttonTripper1.Size = new System.Drawing.Size(116, 47);
            this.buttonTripper1.TabIndex = 1;
            // 
            // buttonTripperByEventHandler1
            // 
            this.buttonTripperByEventHandler1.Location = new System.Drawing.Point(199, 105);
            this.buttonTripperByEventHandler1.Name = "buttonTripperByEventHandler1";
            this.buttonTripperByEventHandler1.Size = new System.Drawing.Size(207, 53);
            this.buttonTripperByEventHandler1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 361);
            this.Controls.Add(this.buttonTripperByEventHandler1);
            this.Controls.Add(this.buttonTripperByEvent1);
            this.Controls.Add(this.buttonTripper1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ButtonTripper buttonTripper1;
        private ButtonTripperByEvent buttonTripperByEvent1;
        private ButtonTripperByEventHandler buttonTripperByEventHandler1;
    }
}

