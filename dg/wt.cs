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
    public partial class wt : Form
    {
        public wt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new wt1(showMsg).Show();
            wt1.GetInstance(showMsg).Show();
        }

        void showMsg(string str)
        {
            this.label1.Text = str;
        }

    }
}
