using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coinGame
{
    public partial class Form1 : Form
    {
        //class scope variable
        double balance = 1000.00;
        public Form1()
        {
            InitializeComponent();
        }
        //Exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Form method
        private void Form1_Shown(object sender, EventArgs e)
        {
            //showing balance (hard coded)
            textBoxBalance.Text = Convert.ToString(balance);
            //hiding pictureboxes
            pictureBoxL1.Hide();
            pictureBoxL2.Hide();
            pictureBoxR1.Hide();
            pictureBoxR2.Hide();
        }
        //Flip coins button
        private void buttonFlip_Click(object sender, EventArgs e)
        {
            //rng
            Random random = new Random();
            try
            {
                //Get players bet
                double bet = double.Parse(textBoxBet.Text);
                //Get players choices
                bool heads = radioButtonHeads.Checked;
                bool tails = radioButtonTails.Checked;
                if (bet <= balance)
                {
                    //Generating coins
                    int coin1 = random.Next(3);
                    int coin2 = random.Next(3);
                    
                    //Showing pictureboxes for coins values
                    if (coin1 == 1)
                    {
                        pictureBoxL1.Show();
                    }
                    else
                    {
                        pictureBoxL2.Show();
                    }
                    if(coin2 == 1)
                    {
                        pictureBoxR1.Show();
                    }
                    else
                    {
                        pictureBoxR2.Show();
                    }
                    //If player selected heads and coins are heads
                    if (heads == true && coin1 == 1)
                    {
                        if(coin2 == 1)
                        {
                            balance = balance + bet;
                            textBoxBalance.Text = Convert.ToString(balance);
                            MessageBox.Show("You are a winner!");
                        }
                        else
                        {
                            balance = balance - bet;
                            textBoxBalance.Text = Convert.ToString(balance);
                            MessageBox.Show("You have lost");
                        }
                    }
                    //If player selected tails and coins are tails
                    else if (tails == true && coin1 == 2)
                    {
                        if(coin2 == 2)
                        {
                            balance = balance + bet;
                            textBoxBalance.Text = Convert.ToString(balance);
                            MessageBox.Show("You are a winner!");
                        }
                        else
                        {
                            balance = balance - bet;
                            textBoxBalance.Text = Convert.ToString(balance);
                            MessageBox.Show("You have lost");
                        }
                    }
                    //Else player loses and displays message and updates balance
                    else
                    {
                        balance = balance - bet;
                        textBoxBalance.Text = Convert.ToString(balance);
                        MessageBox.Show("You have lost");
                    }
                }
                //If bet is not less than or equal to balance
                else
                {
                    MessageBox.Show("You do not have enough money to bet " + bet + ". Bets must be under or equal to " + balance);
                    textBoxBet.Clear();
                    textBoxBet.Focus();
                }
                textBoxBet.Clear();
                textBoxBet.Focus();
                pictureBoxL1.Hide();
                pictureBoxL2.Hide();
                pictureBoxR1.Hide();
                pictureBoxR2.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
