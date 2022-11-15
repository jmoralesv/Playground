using System;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        Entrance entrance = new Entrance();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public int gravity;
        public int pipeSpeed = Entrance.entrancePipeSpeed;
        public int score = 0;
        public int pipeSpeedRate = Entrance.entrancePipeRate;

        public void startGame()
        {
            panel_gameEnd.Hide();
            score = 0;
            bird.Left = 62;
            bird.Top = 146;
            pipedown.Top = -135;
            pipeup.Top = 239;
            pipedown.Left = 251;
            pipeup.Left = 251;
            pipeSpeed = 3;
            bird.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top = gravity + bird.Top;
            pipedown.Left = pipedown.Left - pipeSpeed;
            pipeup.Left = pipeup.Left - pipeSpeed;
            if (pipedown.Left < 0)
            {
                pipedown.Left = 500;
                pipedown.Top = random.Next(-150, -100);
                score++;

            }
            if (pipeup.Left < 0)
            {
                pipeup.Left = random.Next(450, 500);
                pipeup.Top = random.Next(220, 350);

                score++;
                pipeSpeed = pipeSpeed + pipeSpeedRate;
            }
            lbl_scoreAmount.Text = score.ToString();
            gameOver();
        }

        private void gameOver()
        {
            if (bird.Bounds.IntersectsWith(pipedown.Bounds) || bird.Bounds.IntersectsWith(pipeup.Bounds)
                || bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < -40)
            {
                timer1.Enabled = false;
                bird.Hide();
                lbl_gameEndScore.Text = "Score: " + score;
                panel_gameEnd.Show();


            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = true;
                gravity = -5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_gameEnd.Hide();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            gravity = +5;
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel_gameEnd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            entrance.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            entrance.Show();
        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Can");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
