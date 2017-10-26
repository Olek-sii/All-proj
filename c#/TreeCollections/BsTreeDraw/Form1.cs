using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BsTreeDraw
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void drawBtn_Click(object sender, EventArgs e)
		{
			BsTreeDraw tree = new BsTreeDraw();
			tree.Init(new int[] { 5, 4, 3, 6, 7, 1 });
			tree.Draw(pictureBox1);
		}
	}
}
