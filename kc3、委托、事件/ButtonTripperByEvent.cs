using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kc3_委托_事件
{
    public delegate void TripperClickWithEvent();
    public partial class ButtonTripperByEvent : UserControl
    {
        public event TripperClickWithEvent OnTripper;

        public ButtonTripperByEvent()
        {
            InitializeComponent();
        }

        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if(count<3)
            {
                count++;
            }
            else
            {
                if(OnTripper!=null)
                {
                    OnTripper();
                }
                count = 1;
            }

        }
    }
}
