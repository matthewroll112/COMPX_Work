//Matthew Rolleston ID:1567961
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termDepositCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            //Variables
            double initDeposit = double.Parse(textBoxDeposit.Text);
            double interest = (double.Parse(textBoxInterest.Text) / 100);
            int years = int.Parse(textBoxYears.Text);

            //Checking if variables meet criteria
            if (initDeposit > 0 && interest > 0 && years >= 1){
                //Setting new variables for output
                double finalDepo = initDeposit * interest;
                double total = initDeposit;
                //for loop to display output
                for(int i = 1; i <= years; i++)
                {
                    total = total + finalDepo;
                    Console.WriteLine(String.Format($"Year {i}: interest = {finalDepo:C2} and deposit = {total:C2}"));
                    finalDepo = finalDepo * (interest + 1);
                }
            }
            //Error if not
            else
            {
                Console.WriteLine("One or more values enetered cannot be used. Try again.");
                textBoxDeposit.Clear();
                textBoxInterest.Clear();
                textBoxYears.Clear();
                textBoxDeposit.Focus();

            }
        }
    }
}
