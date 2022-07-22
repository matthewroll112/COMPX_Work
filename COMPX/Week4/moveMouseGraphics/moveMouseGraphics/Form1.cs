namespace moveMouseGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(colorDialog1.Color, 2);

            paper.DrawLine(pen1, 401, 225, e.X, e.Y);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            //shows colorDialog
            colorDialog1.ShowDialog();

        }
    }
}