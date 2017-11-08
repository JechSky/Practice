using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            Point point = this.Location;
            for (int i = 0; i < 30; i++)
            {
                this.Location = new Point(point.X + ran.Next(0, 8), point.Y + ran.Next(0, 8));
                Thread.Sleep(10);
                this.Location = point;
                Thread.Sleep(10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadImg();
        }

        PictureBox pic = new PictureBox();
        void LoadImg()
        {
            pic.BackgroundImage = Image.FromFile("images/1.png");
            pic.Width = 100;
            pic.Height = 100;
            pic.Left = 0;
            pic.Top = 0;
            pic.Click += Pic_Click;
            pic.MouseDown += Pic_MouseDown;
            pic.MouseMove += Pic_MouseMove;
            pic.MouseUp += Pic_MouseUp;

            this.Controls.Add(pic);

        }
        Point pointOld = new Point();
        bool isDown = false;

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDown)
            {
                pic.Location = new Point(pic.Left + (e.X - pointOld.X), pic.Top + (e.Y-pointOld.Y));
            }
        }

        
        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            pointOld = e.Location;
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            pic.Left += 5;
            this.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            pic.Left += 1;
        }
    }
}
