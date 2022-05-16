using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace cv12
{
    public partial class Form1 : Form
    {
        public Bitmap pzl;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            //Stream myStream = myAssembly.GetManifestResourceStream()
            //Stream myStream = myAssembly.GetManifestResourceStream("cv12.Images.pzl.jpg");
            //Bitmap pzl = new Bitmap(myStream);
            string[] names = myAssembly.GetManifestResourceNames();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Bitmap pzl = new Bitmap(Properties.Resources.tripadvisortimessquare_taggeryanceyiv_5912__1_, new Size(450, 450));

            var imgarray = new Image[9];
            var img = pzl;

            for (int i = 0; i < 3; i++)
            { 

                
                
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var index = i * 3 + j;
                        imgarray[index] = new Bitmap(150, 150);
                        var graphics = Graphics.FromImage(imgarray[index]);
                        graphics.DrawImage(img, new Rectangle(0, 0, 150, 150), new Rectangle(i * 150, j * 150, 150, 150), GraphicsUnit.Pixel);
                        graphics.Dispose();
                    }
                }
            }

            p1.Image = imgarray[0];
            p2.Image = imgarray[3];
            p3.Image = imgarray[6];
            p4.Image = imgarray[1];
            p5.Image = imgarray[4];
            p6.Image = imgarray[7];
            p7.Image = imgarray[2];
            p8.Image = imgarray[5];
            p9.Image = imgarray[8];

            //pzl = (Bitmap)Image.FromFile(@"../../ Images/pzl.jpg");
        }
        private Image crop(Bitmap src, int x, int y)
        {
            Rectangle cropRect = new Rectangle();
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                                 cropRect,
                                 GraphicsUnit.Pixel);
            }
            return target;
        }
    }
    
}
