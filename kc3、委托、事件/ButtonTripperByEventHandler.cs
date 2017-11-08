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
    public partial class ButtonTripperByEventHandler : UserControl
    {
        public ButtonTripperByEventHandler()
        {
            InitializeComponent();
        }

        public event EventHandler OnTripper;

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
                    TripperClickEventArgs ee = new TripperClickEventArgs();
                    
                    OnTripper(this, ee);
                }
                MessageBox.Show("点击了3次ByEventHandler");
            }


        }
    }

    public class TripperClickEventArgs:EventArgs
    {
        public string name = "test";
        public int age = 1;
    }

}
