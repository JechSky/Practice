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
    public delegate void TripperClick();

    public partial class ButtonTripper : UserControl
    {
        public TripperClick TripperClickFun;
        public ButtonTripper()
        {
            InitializeComponent();
        }

        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                count++;
            }
            else
            {
                //MessageBox.Show("点击三次");
                if (this.TripperClickFun != null)
                {
                    TripperClickFun();
                }
                count = 1;
            }


        }
    }
}
