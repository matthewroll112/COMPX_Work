namespace Ex1
{
    //Matthew Rolleston ID:1569761
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random numbers init
            Random random = new Random();
            //Random numbers for x and y values of DrawLine function
            int xNum1 = random.Next(0, 419);
            int xNum2 = random.Next(0, 419);
            int yNum1 = random.Next(0, 200);
            int yNum2 = random.Next(0, 200);

            //PictureBox init for graphics
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            //Pen class init
            Pen pen1 = new Pen(Color.Blue, 5);
            Pen pen2 = new Pen(Color.Red, 2);
            //DrawLine function
            paper.DrawLine(pen1, xNum1, yNum1, xNum2, yNum2);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();

            Pen pen1 = new Pen(Color.Red, 2);
            Pen pen2 = new Pen(Color.Orange, 2);
            Pen pen3 = new Pen(Color.Blue, 2);
            Pen pen4 = new Pen(Color.Green, 2);

            paper.DrawLine(pen1, 100, 50, 150, 50);
            paper.DrawLine(pen2, 100, 50, 100, 100);
            paper.DrawLine(pen3, 100, 100, 150, 100);
            paper.DrawLine(pen4, 150, 50, 150, 100);
        }
    }
}