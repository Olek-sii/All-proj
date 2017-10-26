using System;
using System.Drawing;

namespace WinFormsBubbles
{
    class Ball
    {
        static Random rand = new Random(DateTime.Now.Millisecond);
        private int x;
        private int y;
        private int r;
        private int dx;
        private int dy;
        private Color color;

        public Ball(int x, int y)
        {
			r = 40;
            this.x = x;
            this.y = y;
            dx = rand.Next(-4, 3);
            dy = rand.Next(-4, 3);
            color = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(200));

			if (dx == 0 || dy == 0)
			{
				dx = 4;
				dy = 4;
			}

		}

		public void Move(int width, int height)
        {
			
			if (x <= (r / 2) || x >= width - (r / 2))
				dx = -dx;     

            if (y <= (r / 2) || y >= height - (r / 2))
				dy = -dy;

            x += dx;
            y += dy;
        }

        public void Paint(Graphics rg)
        {
            SolidBrush brush = new SolidBrush(color);
            rg.FillEllipse(brush, x - (r / 2), y - (r / 2), r, r);
        }
    }
}
