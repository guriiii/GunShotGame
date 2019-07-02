using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunShotGame
{
    public partial class Form2russian : Form
    {
        public Form2russian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btspin .Enabled = true;
            pictureBox1 .Image = Image.FromFile(@"C:\Users\My Pc\Desktop\Russian Roullete\media\load.jpg");

           btload .Enabled = false;
        }

        private void btspin_Click(object sender, EventArgs e)
        {
            object_obj.shotway = 2;//sets the value of to 2 

            object_obj.lodspin = object_obj.loadgunrandom();
            btshoot.Enabled = true;
            pictureBox1.Image = Image.FromFile(@"C:\Users\My Pc\Desktop\Russian Roullete\media\spin.gif");

            btspin.Enabled = false;
        }        gameclass  object_obj = new gameclass();


        private void btshoot_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\My Pc\Desktop\Russian Roullete\media\shoot.wav");
            player.Play();
            if (object_obj.remainingshot > 0 && object_obj.lodspin == 1)
            {

                MessageBox.Show("you lost");
                btspin .Enabled = false;
                btmiss.Enabled = false;
                btload .Enabled = false;
                btshoot .Enabled = false;
                pictureBox1.Image = Image.FromFile(@"C:\Users\My Pc\Desktop\Russian Roullete\media\spin.gif");




            }
            else if (object_obj.remainingshot > 0 && object_obj.lodspin != 1)
            {

                object_obj.remainingshot = object_obj.remainingshot - 1;
                if (object_obj.lodspin == 6)
                {
                    object_obj.lodspin = 1;
                }
                else
                {
                    object_obj.lodspin++;//it increse the value of load
                }

                MessageBox.Show("missed fire");

            }
        }

        private void btmiss_Click(object sender, EventArgs e)
        {
            int check = Shootawaymethod();//takes the value from Shootawaymethod
            if (check == 1)
            {

                MessageBox.Show("Win score 100");
                btspin.Enabled = false;
                btmiss.Enabled = false;
                btload.Enabled = false;
                btshoot.Enabled = false;
                pictureBox1 .Image = Image.FromFile(@"C:\Users\My Pc\Desktop\Russian Roullete\media\shot.jpg");

            }
            if (check == 2)

            {
                MessageBox.Show("win score 20");
                btspin.Enabled = false;
                btmiss.Enabled = false;
                btload.Enabled = false;
                btshoot.Enabled = false;
                pictureBox1.Image = Image.FromFile(@"C:\Users\My Pc\Desktop\Russian Roullete\media\shoot.jpg");

            }
            if (check == 0)
            {

                MessageBox.Show("missed shoot");
            }
            if (object_obj.remainingshot == 0)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\My Pc\Desktop\Russian Roullete\media\shoot.jpg");

                MessageBox.Show("you lost");
                btspin.Enabled = false;
                btmiss.Enabled = false;
                btload.Enabled = false;
                btshoot.Enabled = false;



            }
        }
        public int Shootawaymethod()//this method runs the miss button 
        {

            if (object_obj.lodspin == 1 && object_obj.remainingshot > 0 && object_obj.shotway == 2)
            {

                object_obj.points = 1;


            }
            if (object_obj.lodspin == 1 && object_obj.remainingshot > 0 && object_obj.shotway == 1)
            {

                object_obj.points = 2;

            }

            else if (object_obj.remainingshot > 0 && object_obj.lodspin != 1)
            {
                object_obj.points = 0;
                object_obj.remainingshot = object_obj.remainingshot - 1;
                object_obj.shotway = object_obj.shotway - 1;

                if (object_obj.lodspin == 6)
                {
                    object_obj.lodspin = 1;
                }
                else
                {
                    object_obj.lodspin++;
                }



            }
            return object_obj.points;
        }
            private void RETRYbtn_Click(object sender, EventArgs e)
        {
            (new Form2russian()).Show();
            this.Hide();
        }
    }
}
