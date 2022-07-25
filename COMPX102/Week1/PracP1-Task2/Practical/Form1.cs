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
        //An array that stores rain fall values in mm
        int[] rainfallArray = new int[] { 10, 5, 30, 50, 0, 2, 0, 0, 8, 25, 15, 6, 0, 0, 22 };
        //The width of a bar in the graph
        const int BAR_WIDTH = 40;
        //The maximum amount of rainfall
        const int MAX_RAINFALL = 100;
        //The gap between the bars on the graph
        const int GAP = 5;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the barheight for a rainfall value.
        /// </summary>
        /// <param name="value">The rainfall value to calculate the bar height for</param>
        /// <returns>The height of a bar in the graph for the rainfall value</returns>
        private int CalcBarHeight(int value)
        {
            int height = pictureBoxDisplay.Height * value / MAX_RAINFALL;
            return height;
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Clears the picturebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }
        /// <summary>
        /// Calculates the number of days that had zero rainfall and displays in msgbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(int i in rainfallArray)
            {
                if(i == 0)
                {
                    count += 1;
                }
            }
            MessageBox.Show("Number of days with 0 Rainfall: " + count.ToString(), "Calculate", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Draws bar graph in picturebox using rainfallArray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawGraph_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y;

            //Create graphics
            Graphics pb = pictureBoxDisplay.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.LightBlue);

            //Loop for each rainfallArray item and displaying bars
            foreach(int i in rainfallArray)
            {
                int height = CalcBarHeight(i);

                //Changing y value
                y = pictureBoxDisplay.Height - height;

                //Drawing bars
                pb.DrawRectangle(Pens.LightBlue, x, y, BAR_WIDTH, height);
                pb.FillRectangle(brush, x, y, BAR_WIDTH, height);

                //Changing x value
                x += BAR_WIDTH + GAP;
            }
        }
    }
}
