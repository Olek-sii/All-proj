using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadBalls
{
    public partial class PDraw : UserControl
    {

        public PDraw()
        {
            InitializeComponent();
        }
        public void StartMulti()
        {
            while (pictureBox1.Controls.Count!=0)
            {
                foreach (PBall b in pictureBox1.Controls)
                {
                    Thread th = new Thread(b.MoveBall);
                    th.Start();
                }
                Thread.Sleep(50);
            }
    }
        bool start = false;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Controls.Add(new PBall(e.X, e.Y));
            if (!start)
            {
                Thread th = new Thread(StartMulti);
                th.Start();
                start = true;
            }
        }
    }
}
