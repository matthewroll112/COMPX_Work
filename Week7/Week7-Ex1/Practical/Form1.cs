//Matthew Rolleston ID:1569761
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public partial class Form1 : Form
    {
        //size of a lotto ball
        const int BALL_SIZE = 40;
        //size of the gap between lotto balls
        const int GAP_SIZE = 10;
        // the coordinates of the top, left corner of the display of the phone
        const int DISPLAY_LEFT = 40;
        const int DISPLAY_TOP = 140;
        //the width and height of the display area of the phone
        const int DISPLAY_WIDTH = 320;
        const int DISPLAY_HEIGHT = 460;

        //NOTE: If the display looks wrong in your screen resolution, 
        //please check that the picture box is 400 x 730 pixels in size
        //and adjust the form to be slightly larger than that.
        //Stupid Visual Studio changes the form size based on your screen resolution - gah!

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Draws an image of a phone in the picturebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawPhone_Click(object sender, EventArgs e)
        {
            //set the background image of the picture box to display the phone
            pictureBoxDisplay.BackgroundImage = Properties.Resources.iPhone;

            
        }

        private void buttonBalls_Click(object sender, EventArgs e)
        {
            //User input amount of balls in row
            int balls = int.Parse(textBoxBalls.Text);

            //Creating graphics

            try
            {
                //Checking if ball amount can fit in phone
                if((BALL_SIZE + GAP_SIZE) * balls < DISPLAY_WIDTH)
                {
                    int rows = DISPLAY_HEIGHT / (BALL_SIZE + GAP_SIZE);
                    while (rows >= 0)
                    {
                        
                        rows--;
                    }
                }
                //Error message for amount of balls being to large
                else
                {
                    MessageBox.Show("Balls amount is too large", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
