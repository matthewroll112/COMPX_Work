namespace moveMouseGraphics
{ //Matthew Rolleston - ID:1567961
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            //int size = rand.Next(1, 50); -> Commented out because unnecessary during step c
            int r = rand.Next(0, 255);
            int g = rand.Next(0, 255);
            int b = rand.Next(0, 255);

            //Graphics and pens/brushes
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 2);
            SolidBrush br = new SolidBrush(colorDialog1.Color);
            br.Color = Color.FromArgb(r,g,b); //Using FromArgb for new color

            //Only draws if mouse is pressed
            if (e.Button == MouseButtons.Left)
            {
                int i = rand.Next(5, 10); //Number of circles to be drawn
                int counter = 5; //Counter variable
                while(counter <= i)
                {
                    int size = rand.Next(2,10);
                    int xPos = e.X + rand.Next(-10, 10);
                    int yPos = e.Y + rand.Next(-10, 10);
                    paper.DrawEllipse(pen1, xPos, yPos, size,size);
                    paper.FillEllipse(br, xPos, yPos, size, size);
                    counter++;
                }
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            //shows colorDialog
            colorDialog1.ShowDialog();
        }
    }
}