using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadBalls
{
    public partial class PBall : PictureBox
    {
        int dX;
        int dY;

        Color col;

        public PBall(int x, int y)
        {
            InitializeComponent();

            Location = new Point(x, y);
            BackColor = Color.Transparent;
            Size = new Size(40, 40);



            Random rnd = new Random();

            col = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            /*
            Bitmap b = new Bitmap(40, 40);
            SolidBrush br = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));

            using (Graphics g = Graphics.FromImage(b))
            {
                g.FillEllipse(br, 0, 0, 40, 40);
            }
            Image = b;
            */


            dX = rnd.Next(-10, 10);
            dY = rnd.Next(-10, 10);
        }



        public void MoveBall()
        {
            Parent.Invoke((MethodInvoker)delegate ()
            {
                if (Location.X <= 20)
                    dX = -dX;
                if (Location.X >= Parent.Width - 20)
                    dX = -dX;
                if (Location.Y <= 20)
                    dY = -dY;
                if (Location.Y >= Parent.Height - 20)
                    dY = -dY;

                Location = new Point(Location.X + dX, Location.Y + dY);
            });
        }

        private void PBall_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dispose();
            }
        }

        private void PBall_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(col);
            e.Graphics.FillEllipse(br, 0, 0, 40, 40);
        }
    }
}
