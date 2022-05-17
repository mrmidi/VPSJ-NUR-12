using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv12
{
    public partial class imageCropForm : Form
    {
        Image img;
        Game game;
        int w;
        int h;

        int cropX;
        int cropY;
        int cropWidth;
        int cropHeight;
        int oCropX;
        int oCropY;
        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;
        bool isCropSet = false;
        Form1 mainForm;

        public imageCropForm()
        {
            InitializeComponent();
        }

        public imageCropForm(Image img, Game game, Form1 mainForm)
        {
            this.mainForm = mainForm;
            this.img = img;
            this.game = game;
            this.w = img.Width;
            this.h = img.Height;
            if (w == h)
            {
                this.img = ResizeImage(img, 450, 450);
            }
            else
            {
                InitializeComponent();
                //check picture resolution. if it's too big - scale it!
                int screenW = Screen.PrimaryScreen.Bounds.Width;
                int screenH = Screen.PrimaryScreen.Bounds.Height;
                Double percent;
                if (screenW <= w) //resize by width
                {
                    percent = (screenW / 100.0 * 70) * 100 / w;
                    w = screenW - (screenW / 100 * 30); //70% of screen width
                    h = h - (int) (h / 100 * (100 - percent)); //70% of height
                }
                if (screenH <= h)
                {
                    percent = (screenH / 100.0 * 70) * 100 / h;
                    h = screenH - (screenH / 100 * 30); //70% of screen height
                    w = w - (int)(w / 100 * (100 - percent)); //70% of picture width proportioned
                }
                this.img = ResizeImage(img, w, h);
                pb.Width = w;
                pb.Height = h;
                pb.Image = img;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Size = new Size(w, h);
            }
        }

        private void crop()
        {
            if (cropWidth < 1)
            {
                return;
            }
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            //First we define a rectangle with the help of already calculated points  
            Bitmap OriginalImage = new Bitmap(this.img);
            //Original image  
            Bitmap _img = new Bitmap(cropWidth, cropHeight);
            // for cropinf image  
            Graphics g = Graphics.FromImage(_img);
            // create graphics  
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            //set image attributes  
            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            game.updateImage(_img);
        }

        //from https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        public static Bitmap ResizeImage(Image image, int width, int height) 
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void imageCropForm_Load(object sender, EventArgs e)
        {
            Console.Write("loaded picture...");
        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(Color.White, 2);
                cropPen.DashStyle = DashStyle.Dash;
              
            }
            pb.Refresh();
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (pb.Image == null)
                return;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pb.Refresh();
                if (cropPen != null)
                {
                    cropWidth = e.X - cropX;
                    cropHeight = e.Y - cropY;
                    pb.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropWidth);
                    if (cropWidth > 100)
                    {
                        isCropSet = true;
                    }
                }

            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            if (isCropSet == false)
            {
                MessageBox.Show("Please, hold & drag your mouse to select square region for puzzle", "Hint", MessageBoxButtons.OK);
            }

        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            if (isCropSet == true && cropWidth < 450)
                MessageBox.Show("Your square is too small! Must be >= 450 pixels. Try selecting larger area", "Hint", MessageBoxButtons.OK);
            else if (isCropSet == true && cropWidth >= 450)
            {
                crop();
                mainForm.drawField();
                this.Close();
            }
        }
    }
}
