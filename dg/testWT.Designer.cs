namespace dg
{
    partial class testWT
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTripper1 = new dg.ButtonTripper();
            this.userControl11 = new dg.UserControl1();
            this.btnTripperEventHandler1 = new dg.BtnTripperEventHandler();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "注册方法";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTripper1
            // 
            this.buttonTripper1.Location = new System.Drawing.Point(175, 53);
            this.buttonTripper1.Name = "buttonTripper1";
            this.buttonTripper1.Size = new System.Drawing.Size(145, 55);
            this.buttonTripper1.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(37, 133);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(155, 66);
            this.userControl11.TabIndex = 2;
            // 
            // btnTripperEventHandler1
            // 
            this.btnTripperEventHandler1.Location = new System.Drawing.Point(217, 152);
            this.btnTripperEventHandler1.Name = "btnTripperEventHandler1";
            this.btnTripperEventHandler1.Size = new System.Drawing.Size(172, 72);
            this.btnTripperEventHandler1.TabIndex = 3;
            // 
            // testWT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 289);
            this.Controls.Add(this.btnTripperEventHandler1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonTripper1);
            this.Controls.Add(this.button1);
            this.Name = "testWT";
            this.Text = "testWT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ButtonTripper buttonTripper1;
        private UserControl1 userControl11;
        private BtnTripperEventHandler btnTripperEventHandler1;
    }
}