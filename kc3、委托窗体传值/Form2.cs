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
    public delegate void DelTest(string str);
    public partial class Form2 : Form
    {
        public static Form2 FrmSingle = null;
        public DelTest deltest;
        public Form2(DelTest delt)
        {
            this.deltest = delt;
            InitializeComponent();
        }

        public static Form2 GetSingle(DelTest delt)
        {
            if(FrmSingle==null)
            {
                FrmSingle = new Form2(delt);
            }
            return FrmSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(deltest!=null)
            {
                deltest(this.textBox1.Text);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.FrmSingle = null;
        }
    }
}
