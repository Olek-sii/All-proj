using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace WinFormsBubbles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ball> balls = new List<Ball>();

        private void PaintClick(object sender, EventArgs e)
        {
            Point p = pictureBox1.PointToClient(Cursor.Position);
            Ball ball = new Ball(p.X, p.Y);
            balls.Add(ball);
        }

        private void paint(object sender, PaintEventArgs e)
        {
            MyTimer();
            foreach (Ball ball in balls)
            {
                Graphics rg = e.Graphics;
                ball.Paint(rg);
            }
        }
        private void MyTimer()
        {
            pictureBox1.Invalidate();
            Thread.Sleep(10);
            foreach (Ball ball in balls)
            {
                ball.Move(pictureBox1.Width, pictureBox1.Height);
            }
        }
    }

}
