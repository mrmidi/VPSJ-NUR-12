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
        private static Game game = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawField();
        }

        public void drawField() //iterate pictureboxes, load images
        {
            int count = 1;
            game.generateField();
            var imgarray = game.getImages();
            foreach (Control p in this.Controls) 
            {
                if (p is PictureBox)
                {
                    int n = Int32.Parse(p.Name.Substring(1));
                    ((PictureBox)p).Image = imgarray[n-1];
                }
            }
        }



        public void rotate()
        {
            var rand = new Random();
            for (int i = 0; i < 9; i++)
            {
                int r = rand.Next(3);
            }
        }

        private void openCustomPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Obrazky (*.jpg;*.png) |*.jpg;*.png";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(f.FileName);
                imageCropForm icf = new imageCropForm(img, game, this);
                icf.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawField();
        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        private void p1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                p1.Image = 
                //drawField();
                //game.
            }
        }
    }
    
}
