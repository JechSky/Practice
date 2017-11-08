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
    public delegate void DelTest(string str);
    public partial class wt1 : Form
    {
        static wt1 wtfrm = null;
        static readonly object lockObj = new object();
        public DelTest deltest;
        wt1(DelTest delt)
        {
            this.deltest = delt;
            InitializeComponent();
        }

        public static wt1 GetInstance(DelTest deltest)
        {
            if (wtfrm == null)
            {
                lock (lockObj)
                {
                    if (wtfrm == null)
                    {
                        wtfrm = new wt1(deltest);
                    }
                }
            }
            return wtfrm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(deltest!=null)
            {
                deltest(this.textBox1.Text);
            }
        }
    }
}
