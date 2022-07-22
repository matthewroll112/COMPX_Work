namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBox1.CreateGraphics();
            //Declaring points
            Point p1 = new Point(513 / 2, 270 / 2 - 100);
            Point p2 = new Point(513 / 2 - 100, 270 / 2);
            Point p3 = new Point(513 / 2 + 100, 270 / 2);

            //Declaring pen and drawing lines
            Pen pen = new Pen(Color.Blue, 3);
            paper.DrawLine(pen, p1, p2);
            paper.DrawLine(pen, p1, p3);
            paper.DrawLine(pen, p2, p3);
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            //Declaring variables
            int x = 50;
            int y = 80;
            int size = 60;
            //creating graphics and pen
            Graphics paper = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 3);

            paper.DrawRectangle(pen, x, y, size, size);
        }
    }
}