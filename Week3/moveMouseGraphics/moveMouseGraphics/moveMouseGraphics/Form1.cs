namespace moveMouseGraphics
{
    //Matthew Rolleston ID:1569761
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Red, 2);

            paper.DrawLine(pen1, 401, 225, e.X, e.Y);
        }
    }
}