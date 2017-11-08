using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dg
{
    public partial class testWT : Form
    {
        public testWT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.buttonTripper1.tripper += tripperFun;
            this.userControl11.testdelObj += tripperFun;
            this.btnTripperEventHandler1.eventHandlerObj += BtnTripperEventHandler1_eventHandlerObj;  
        }

        private void BtnTripperEventHandler1_eventHandlerObj(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("e={0}", (e as MyArgs).aa));
        }

        private void UserControl11_testdelObj(object sender, EventArgs e)
        {
            Console.WriteLine("e={0}",( e as MyArgs).aa);
        }

        void tripperFun()
        {
            MessageBox.Show("点了三次");
        }

    }
}
