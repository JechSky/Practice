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
    public delegate void TripperClick();

    public partial class ButtonTripper : UserControl
    {
        public TripperClick tripper;
        public ButtonTripper()
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
                if(tripper!=null)
                {
                    tripper();
                }
                count =1;
            }

        }
    }
}
