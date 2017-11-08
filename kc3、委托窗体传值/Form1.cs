using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kc3_委托窗体传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Form2(ShowMsg).Show();
            Form2.GetSingle(ShowMsg).Show();
        }

        void ShowMsg(string msg)
        {
            label1.Text = msg;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.FrmSingle = null;
        }
    }
}
