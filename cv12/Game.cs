using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv12
{
    public class Game
    {
        private Bitmap img;
        private int moveCount;
        private int timeSpent; 
        private Image[] imgarray = new Image[9];
        private Dictionary<int, int> field = new Dictionary<int, int>();
        public bool enabled = false;

        public Game() //empty constructor
        {
            this.img = new Bitmap(Properties.Resources.tripadvisortimessquare_taggeryanceyiv_5912__1_, new Size(450, 450));
            this.moveCount = 0;
            this.timeSpent = 0;
            this.crop();
            initField();
        }

        public void updateTimeSpient()
        {
            this.timeSpent++;
        }

        public Image updateField(int cell, int value)
        {
            //
            if (this.enabled == true) 
            { 
                field[cell] += value;
                if (field[cell] == 4)
                    field[cell] = 0;
                if (field[cell] == -1)
                    field[cell] = 3;
                if (value == 1)
                {
                   this.imgarray[cell].RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                if (value == -1)
                {
                    this.imgarray[cell].RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                Console.WriteLine("Updated cell " + cell + ". New value: " + field[cell]);
            }
            return this.imgarray[cell];
        }


        public Image getImage(int i)
        {
            return imgarray[i];
        }

        public void resetGame()
        {
            this.moveCount = 0;
            this.timeSpent = 0;
        }

        public String getScore()
        {
            return "";
        }

        public String getTime()
        {
            return this.timeSpent.ToString();
        }


        public bool isGameOver()
        {
            for (int i = 0; i < 9; i++)
            {
                if (field[i] != 0)
                    return false;
            }
            return true;
        }

        public void updateImage(Bitmap img)
        {
            this.img = img;
            this.crop();
        }
        
        private void initField()
        {
            for (int i = 0; i < 9; i++)
            {
                field.Add(i, 0);
            }
        }

        private void crop()
        {

            for (int i = 0; i < 3; i++)
            {
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var index = i * 3 + j;
                        this.imgarray[index] = new Bitmap(150, 150);
                        var graphics = Graphics.FromImage(imgarray[index]);
                        graphics.DrawImage(this.img, new Rectangle(0, 0, 150, 150), new Rectangle(j * 150, i * 150, 150, 150), GraphicsUnit.Pixel);
                        //graphics.DrawImage(img)
                        graphics.Dispose();
                    }
                }
            }
        }

        public void generateField()
        {
            var rand = new Random();
            for (int i = 0; i < 9; i++)
            {
                int r = rand.Next(3);
                field[i] = r;
                switch (r)
                {
                    case 1:
                        imgarray[i].RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 2:
                        imgarray[i].RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 3:
                        imgarray[i].RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                    default:
                        break;
                }                    
            }
        }

        public Image[] getImages()
        {
            Console.WriteLine(imgarray);
            return this.imgarray;
        }

    }
}
