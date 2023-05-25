using System;

namespace Run_Button_Task
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
           random = new Random();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveButtonToRandomLocation();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            MoveButtonToRandomLocation();
        }

        private void MoveButtonToRandomLocation()
        {
            int maxX = ClientSize.Width - button2.Width;
            int maxY = ClientSize.Height - button2.Height;

            int newX = random.Next(0, maxX + 1);
            int newY = random.Next(0, maxY + 1);

            button2.Location = new Point(newX, newY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAHAHA I KNOW","STUPID",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}