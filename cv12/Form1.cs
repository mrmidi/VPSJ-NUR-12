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
            //
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
            f.Filter = "Pictures (*.jpg;*.png) |*.jpg;*.png";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(f.FileName);
                imageCropForm icf = new imageCropForm(img, game, this);
                icf.Show();
            }

        }

        private void move(PictureBox pb, int val)
        {
            if (game.isGameOver() == false)
            {
                int n = int.Parse(pb.Name.Substring(1));
                pb.Image = game.updateField(n - 1, val);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (game.enabled == true)
            {
                game.generateField();
                game.resetGame();
                drawField();
            }
            else if (game.enabled == false)
            {
                game.enabled = true;
                game.generateField();
                game.resetGame();
                drawField();
            }
        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        private void p1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                move((sender as PictureBox), -1);

            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                move((sender as PictureBox), 1);
        }


        private void p2_Click(object sender, EventArgs e)
        {

        }

        private void p2_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                move((sender as PictureBox), -1);

            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                move((sender as PictureBox), 1);
        }

        private void p3_Click(object sender, EventArgs e)
        {

        }

        private void p3_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                move((sender as PictureBox), -1);

            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                move((sender as PictureBox), 1);
        }

        private void p4_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                move((sender as PictureBox), -1);

            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                move((sender as PictureBox), 1);
        }

        private void p5_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                move((sender as PictureBox), -1);

            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                move((sender as PictureBox), 1);
        }

        private void p6_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                move((sender as PictureBox), -1);

            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                move((sender as PictureBox), 1);
        }

        private void p7_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                move((sender as PictureBox), -1);

            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                move((sender as PictureBox), 1);
        }

        private void p8_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                move((sender as PictureBox), -1);

            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                move((sender as PictureBox), 1);
        }

        private void p9_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine((sender as PictureBox).Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                move((sender as PictureBox), -1);

            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                move((sender as PictureBox), 1);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
    
}
