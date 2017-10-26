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
        public void StartSingle()
        {
            bool continious = true;
            while (continious==true)
            {
                try
                {
                    pictureBox1.Invoke((MethodInvoker)delegate ()
                    {
                        foreach (PBall b in pictureBox1.Controls)
                        {
                            b.MoveBall();
                        }
                    });
                    Thread.Sleep(10);
                }
              catch(Exception)
                {
                    continious = false;
                }
            }
        }
        bool start = false;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!start)
            {
                Thread th = new Thread(StartSingle);
                th.Start();
                start = true;
            }

            pictureBox1.Controls.Add(new PBall(e.X, e.Y));
        }
    }
}
