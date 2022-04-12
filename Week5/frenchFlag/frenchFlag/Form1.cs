namespace frenchFlag
{ //Matthew Rolleston - ID:1569761
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Flag constant for amount of bars
        const int FLAG_BARS = 3;

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            //Declaring variables
            Graphics canvas = pictureBox1.CreateGraphics();
            Brush brush;

            int flagWidth = pictureBox1.Width/FLAG_BARS;
            int flagHeight = pictureBox1.Height;

            //Creating rectangle for all x y positions
            Rectangle first = new Rectangle(0, 0, flagWidth, flagHeight);
            Rectangle second = new Rectangle(flagWidth, 0, 2*flagWidth, flagHeight);
            Rectangle third = new Rectangle(2 * flagWidth, 0, 3*flagWidth, flagHeight);

            //Drawing bars at all x y position
            brush = Brushes.Blue;
            canvas.FillRectangle(brush, first);
            brush = Brushes.White;
            canvas.FillRectangle(brush, second);
            brush = Brushes.Red;
            canvas.FillRectangle(brush, third);
        }
    }
}