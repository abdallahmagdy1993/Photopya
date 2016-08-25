using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
namespace Photopya.Item
{
    class ImageItem : Item
    {
        private string URL;
        private Bitmap photo;
        private Bitmap origional;
        private Size size;
        public ImageItem(int l):base(l){
            photo=null;
            origional = null;
            size.Height =0;
            size.Width = 0;
            URL = "";
            name = "layer " + l.ToString();

        }
        public ImageItem(ImageItem img,int l):base(img,l){
            photo = new Bitmap(img.photo);
            origional = new Bitmap(img.origional);
            size = img.size;
            URL = img.URL;
            name = "layer " + l.ToString();

            
        }
        public void set_URL(string u)
        {
            URL = u;
            photo = new Bitmap(Image.FromFile(u));
            origional = new Bitmap(Image.FromFile(u));
            size = photo.Size;
        }
        public Bitmap get_photo()
        {
            return photo;
        }
 
        public void set_size(Size s)
        {
                size.Width=s.Width;
                size.Height = s.Height;
        }
        
        public Size get_size()
        {
            return size;
        }
        public override void set_opacity(int o)
        {
            opacity =o/100.0f;
        }
        public override int get_opacity()
        {
            return (int)(opacity*100.0f);
        }
        private void change_opacity() 
        {
            photo = new Bitmap(Resize(origional, size, 3));
            size.Width = photo.Width;
            size.Height = photo.Height;
            Bitmap bmp = new Bitmap(size.Width, size.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            
            colormatrix.Matrix33 = (opacity);
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(photo, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, size.Width, size.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();
            photo = bmp;

        
        
        
        }
        public override void draw_item(Bitmap BG)
        {
            Graphics G = Graphics.FromImage(BG);
            change_opacity();

            
            G.DrawImage(photo, position);
            if (selected == true)
                G.DrawRectangle(Pens.White, position.X, position.Y, size.Width, size.Height);

        }

        public static Image Resize(Image image, Size targetResolution, int resizeMode)
        {
            int sourceWidth = image.Width;
            int sourceHeight = image.Height;

            int targetWidth = targetResolution.Width;
            int targetHeight = targetResolution.Height;

            // Supplied image is landscape, while the target resolution is portait OR
            // supplied image is in portait, while the target resolution is in landscape.
            // switch target resolution to match the image.
            if ((sourceWidth > sourceHeight && targetWidth < targetHeight) || (sourceWidth < sourceHeight && targetWidth > targetHeight))
            {
                targetWidth = targetResolution.Height;
                targetHeight = targetResolution.Width;
            }

            float ratio = 0;
            float ratioWidth = ((float)targetWidth / (float)sourceWidth);
            float ratioHeight = ((float)targetHeight / (float)sourceHeight);

            if (ratioHeight < ratioWidth)
                ratio = ratioHeight;
            else
                ratio = ratioWidth;

            Bitmap newImage = null;

            switch (resizeMode)
            {
                case 1:
                
                    {
                        int destWidth = (int)(sourceWidth * ratio);
                        int destHeight = (int)(sourceHeight * ratio);

                        newImage = new Bitmap(destWidth, destHeight);
                        using (Graphics graphics = Graphics.FromImage((System.Drawing.Image)newImage))
                        {
                            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(image, 0, 0, destWidth, destHeight);
                        }

                        break;
                    }
                case 2:
                    {
                        if (ratioHeight > ratioWidth)
                            ratio = ratioHeight;
                        else
                            ratio = ratioWidth;

                        int destWidth = (int)(sourceWidth * ratio);
                        int destHeight = (int)(sourceHeight * ratio);

                        newImage = new Bitmap(targetWidth, targetHeight);

                        int startX = 0;
                        int startY = 0;

                        if (destWidth > targetWidth)
                            startX = 0 - ((destWidth - targetWidth) / 2);

                        if (destHeight > targetHeight)
                            startY = 0 - ((destHeight - targetHeight) / 2);

                        using (Graphics graphics = Graphics.FromImage((System.Drawing.Image)newImage))
                        {
                            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(image, startX, startY, destWidth, destHeight);
                        }

                        break;
                    }
                case 3:
                    {
                        newImage = new Bitmap(targetWidth, targetHeight);
                        using (Graphics graphics = Graphics.FromImage((System.Drawing.Image)newImage))
                        {
                            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(image, 0, 0, targetWidth, targetHeight);
                        }
                        break;
                    }
                case 4:
                    {
                        newImage = new Bitmap(targetWidth, targetHeight);

                        int destWidth = (int)(sourceWidth * ratio);
                        int destHeight = (int)(sourceHeight * ratio);

                        int startX = 0;
                        int startY = 0;

                        if (destWidth < targetWidth)
                            startX = 0 + ((targetWidth - destWidth) / 2);

                        if (destHeight < targetHeight)
                            startY = 0 + ((targetHeight - destHeight) / 2);

                        newImage = new Bitmap(targetWidth, targetHeight);
                        using (Graphics graphics = Graphics.FromImage((System.Drawing.Image)newImage))
                        {
                            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(image, startX, startY, destWidth, destHeight);
                        }

                        break;
                    }
                default:
                    break;
            }

            return (Image) newImage;
        }
        
    }

}
