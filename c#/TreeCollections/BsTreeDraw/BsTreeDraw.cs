using System.Drawing;
using System.Windows.Forms;
using TreeCollections;

namespace BsTreeDraw
{
	class BsTreeDraw : AvlBsTree
	{
		public void Draw(PictureBox pb)
		{
			int dy = pb.Height / (Height() + 1);
			Graphics g = pb.CreateGraphics();
			DrawNode(root, g, 0, pb.Width, dy, 0, pb.Width / 2, dy - 10);
		}

		private void DrawNode(Node p, Graphics g, int left, int right, int dy, int lvl, int xp, int yp)
		{
			if (p == null)
				return;

			int x = (left + right) / 2;
			int y = ++lvl * dy;

			DrawNode(p.left, g, left, x, dy, lvl, x, y + 10);

			g.DrawLine(new Pen(Color.Black), x, y - 10, xp, yp);
			g.DrawEllipse(new Pen(Color.Black), x - 10, y - 10, 20, 20);
			g.DrawString("" + p.val, new Font("Arial", 10), Brushes.Black, x - 7, y - 7);

			DrawNode(p.right, g, x, right, dy, lvl, x, y + 10);
		}
	}
}
