using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using PaintWF.Api;

namespace PaintWF
{
    public partial class PSaving : UserControl
    {
        public PSaving()
        {
            InitializeComponent();           
        }

        public XData data = null;

        private void bSave_Click(object sender, EventArgs e)
        {
            string[] ext = {"PNG (*.png)|*.png","JPEG(*.jpeg) | *.jpeg","GIF (*.gif)|*.gif","BMP (*.bmp)|*.bmp","RAW (*.raw)|*.raw",
                "TIFF (*.tiff)|*.tiff","WMF (*.wmf)|*.wmf","PSD (*.psd)|*.psd","ICON (*.icon)|*.icon","EMF (*.emf)|*.emf" };

            dlgSave.Filter = String.Join("|", ext);
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                PictureImpl.GetInstance(dlgSave.FileName).Save(PDraw.SelfRef.getPictureBox());
            }
        }
    }
}
