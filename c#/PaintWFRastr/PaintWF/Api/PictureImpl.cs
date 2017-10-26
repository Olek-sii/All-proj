using PaintWF.Api;

namespace PaintWF
{
    class PictureImpl
    {
        public static IPictureFormat GetInstance(string type)
        {
            IPictureFormat pf = null;
            string[] str = type.Split('.');
            switch (str[str.Length-1])
            {
                case "bmp":
                    pf = new PictureBmp(type);
                    break;
                case "jpg":
                    pf = new PictureJpeg(type);
                    break;
                case "gif":
                    pf = new PictureGif(type);
                    break;
                case "tiff":
                    pf = new PictureTiff(type);
                    break;
                case "png":
                    pf = new PicturePng(type);
                    break;
                case "emf":
                    pf = new PictureEmf(type);
                    break;
                case "raw":
                    pf = new PictureRaw(type);
                    break;
                case "psd":
                    pf = new PicturePsd(type);
                    break;
                case "icon":
                    pf = new PictureIcon(type);
                    break;
                case "wmf":
                    pf = new PictureWmf(type);
                    break;
            }
            return pf;
        }
    }
}