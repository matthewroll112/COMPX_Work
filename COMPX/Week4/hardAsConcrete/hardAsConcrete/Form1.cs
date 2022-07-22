namespace hardAsConcrete
{
    //Matthew Rolleston ID:1569761
    public partial class Form1 : Form
    {
        //declaring constant variables for all classes
        const double driveDepth = 0.5;
        const double concretePerKG = 1.5;
        const double bagWeight = 2.0;
        const decimal bagCost = 15.5m;
        public Form1()
        {
            InitializeComponent();
        }

        //Calculate button
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Getting length and width using parse method to convert
            double length = double.Parse(textBoxLength.Text);
            double width = double.Parse(textBoxWidth.Text);

            //Calculating volume and displaying
            double volume = (length * width * driveDepth);
            textBoxVolume.Text = "Volume of concrete required: " + Decimal.Round((decimal)volume, 3) + "m^3";
            //Calculating kg of concrete and displaying
            double kg = volume / concretePerKG;
            textBoxKG.Text = "KG of cement required: " + Decimal.Round((decimal)kg, 3) + "kg";
            //Calculating number of bags and displaying
            double bags = Math.Ceiling(kg / bagWeight);
            textBoxBags.Text = "Bags of concrete required: " + bags;
            //Calculating cost and displaying
            textBoxCost.Text = "Total cost: " + "$" + Decimal.Round((decimal)bags * bagCost, 2);
        }

        //Clear button
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clearing textboxes to default
            textBoxVolume.Clear();
            textBoxKG.Clear();
            textBoxBags.Clear();
            textBoxCost.Clear();
            textBoxLength.Text = "Input Length Here (m):";
            textBoxWidth.Text = "Input Width Here (m):";
        }

        //Exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        //Length text box
        private void textBoxLength_Click(object sender, EventArgs e)
        {
            textBoxLength.Clear();
        }
        //Width text box
        private void textBoxWidth_Click(object sender, EventArgs e)
        {
            textBoxWidth.Clear();
        }
    }
}