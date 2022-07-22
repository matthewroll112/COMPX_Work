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
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 2);
            SolidBrush br = new SolidBrush(colorDialog1.Color);
            //Only draws if mouse is pressed
            if (e.Button == MouseButtons.Left)
            {
                //paper.DrawLine(pen1, pictureBoxDisplay.Size.Width/2, pictureBoxDisplay.Size.Height / 2, e.X, e.Y);
                //paper.DrawLine(pen1, rand.Next(pictureBoxDisplay.Width + 1), rand.Next(pictureBoxDisplay.Height + 1), e.X, e.Y);
                paper.FillEllipse(br, e.X, e.Y, 50, 50);
                paper.DrawEllipse(pen1, e.X, e.Y, 50, 50); 
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            //shows colorDialog
            colorDialog1.ShowDialog();

        }
    }
}