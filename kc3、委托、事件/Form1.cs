using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kc3_委托_事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buttonTripper1.TripperClickFun += MyTripperClick;

            this.buttonTripperByEvent1.OnTripper += ButtonTripperByEvent1_OnTripper;

            this.buttonTripperByEventHandler1.OnTripper += ButtonTripperByEventHandler1_OnTripper;

        }

        private void ButtonTripperByEventHandler1_OnTripper(object sender, EventArgs e)
        {
            MessageBox.Show(sender + ": e= " + (e as TripperClickEventArgs).age);
        }

        private void ButtonTripperByEvent1_OnTripper()
        {
            MessageBox.Show("注册事件到方法上");
        }

        void MyTripperClick()
        {
            MessageBox.Show("第一次点击三击按钮");
        }
    }
}
