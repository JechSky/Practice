using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dg
{
    public partial class BtnTripperEventHandler : UserControl
    {
        public event EventHandler eventHandlerObj;
        public BtnTripperEventHandler()
        {
            InitializeComponent();
        }

        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 3)
                count++;
            else
            {
                if(eventHandlerObj!=null)
                {
                    MyArgs arg = new dg.MyArgs() { aa = "012" };
                    eventHandlerObj(this, arg);
                }
                count = 1;
                MessageBox.Show("点了三次");
            }
        }
    }
}
