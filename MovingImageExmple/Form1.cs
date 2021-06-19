using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace MovingImageExmple
{
    public partial class frmMoveImage : Form
    {
        bool collision;//to check if images are colapsed
        string[] imageArr;//array of images
        public frmMoveImage()
        {
            InitializeComponent();
            createRandomImageArray();
            //random images
            changeImage(pb1);
            changeImage(pb2);
        }

        //read file names from Resources directory in the project
        //to array and create a random order 
        private void createRandomImageArray()
        {
            imageArr = Directory.GetFiles(@"../../../Resources/");
            shuffle(imageArr);
        }
        // basic Knuth shuffle algorithm :: courtesy of Wikipedia :)
        private void shuffle(string[] arr)
        {
            //basic shuffle algorithm Knuth
            Random rnd = new Random();
            for(int i=0; i<arr.Length;i++)
            {
                int r = rnd.Next(arr.Length);
                string tmp = arr[i];
                arr[i] = arr[r];
                arr[r] = tmp;
            }
        }

        //start timer all the logic in in timer
        private void btnMove_Click(object sender, EventArgs e)
        {
            timerImageMove.Start();
        }

        //choose random image to replace current image
        private void changeImage(PictureBox p)
        {
            Random rnd = new Random();
            int r = rnd.Next(imageArr.Length);
            p.ImageLocation = imageArr[r];
        }
        //all the logic of movement
        private void timerImageMove_Tick(object sender, EventArgs e)
        {
            //move untill picture 2
            if(pb1.Location.X+pb1.Width<=pb2.Location.X && collision==false)
            pb1.Location = new Point(pb1.Location.X+10,pb1.Location.Y);
            //collision
            else if(pb1.Location.X+pb1.Width>pb2.Location.X && collision==false)
            {  
                collision = true;
                //change image
                changeImage(pb2);
            }
            //moving picture 2 untill form width
                 else if(pb2.Location.X+pb2.Width<=this.Width)
                    pb2.Location = new Point(pb2.Location.X + 10, pb2.Location.Y);
        }
        //stop the timer
        private void btnStop_Click(object sender, EventArgs e)
        {
            timerImageMove.Stop();
        }

        //restart all the images to the original location
        //if timer works - then it continues to work? 
        //if want to stop just add timerImageMove.Stop();
        private void btnRestart_Click(object sender, EventArgs e)
        {
            collision = false;
            pb1.Location=new Point(12, 68);
            pb2.Location=new Point(391, 68);
            changeImage(pb1);
            changeImage(pb2);
        }
    }
}
