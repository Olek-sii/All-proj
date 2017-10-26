using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintWF
{
    public partial class POpening : UserControl
    {
        public POpening()
        {
            InitializeComponent();
        }

        public XData data = null;
        public Action OnPictureLoad;

        private void bOpen_Click(object sender, EventArgs e)
        {
            string[] ext = {"PNG (*.png)|*.png","JPEG(*.jpeg) | *.jpeg","GIF (*.gif)|*.gif","BMP (*.bmp)|*.bmp","RAW (*.raw)|*.raw",
                "TIFF (*.tiff)|*.tiff","WMF (*.wmf)|*.wmf","PSD (*.psd)|*.psd","ICON (*.icon)|*.icon","EMF (*.emf)|*.emf" };

            dlgOpen.Filter = String.Join("|", ext);
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                PDraw.SelfRef.getPictureBox().Image = PictureImpl.GetInstance(dlgOpen.FileName).Load();
            }
        }
    }
}
