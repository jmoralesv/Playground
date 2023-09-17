namespace PongGame;

public partial class Form1 : Form
{
    int score = 0;
    int ballSpeedY = 10;
    int ballSpeedX = 10;
    int racketSpeed = 10;
    int r, g, b; //random background color
    readonly Random random = new(); // creating an object from random class

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ball.Location = new Point(random.Next(12, 772),
            random.Next(12, 120));

        gameOverPanel.Hide();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        ball.Top += ballSpeedY;
        ball.Left += ballSpeedX;
        labelScore.Text = score.ToString();
        BallMechanics();
        BorderMechanics();
        RacketOutScreen();
        GameOver();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)  //Racket Controls
    {
        timer.Start();
        if (e.KeyCode == Keys.A)
        {
            racket.Left -= racketSpeed;
        }
        if (e.KeyCode == Keys.D)
        {
            racket.Left += racketSpeed;
        }
        if (e.KeyCode == Keys.F2)
        {
            Restart();
        }
    }

    private void RacketOutScreen()  //spawning racket back when racket is out of screen
    {
        if (racket.Left < -80)
        {
            racket.Left = 680;
        }
        if (racket.Left > 680)
        {
            racket.Left = -80;
        }
    }

    private void BallMechanics() // changing ball direction and speed on x axis
    {
        if (ball.Left <= 0 || ball.Left >= area.Right - 13)
        {
            if (ballSpeedX < 0)
            {
                ballSpeedX--;
            }
            else
            {
                ballSpeedX++;
            }
            ballSpeedX = -ballSpeedX;
        }
    }
    private void BorderMechanics() // changing ball direction and speed on y axis
    {
        if (ball.Bounds.IntersectsWith(racket.Bounds))
        {
            if (ballSpeedY < 0)
            {
                ballSpeedY--;
                racketSpeed++;
            }
            else
            {
                ballSpeedY++;
                racketSpeed++;
            }
            r = random.Next(0, 255);
            g = random.Next(0, 255);
            b = random.Next(0, 255);

            area.BackColor = Color.FromArgb(r, g, b);
            labelScore.BackColor = Color.FromArgb(r, g, b);
            ballSpeedY = -ballSpeedY;
            score++;
        }

        if (ball.Top <= 0)
        {
            if (ballSpeedY < 0)
            {
                ballSpeedY--;
                racketSpeed++;
            }
            else
            {
                ballSpeedY++;
                racketSpeed++;
            }
            ballSpeedY = -ballSpeedY;
        }
    }

    private void GameOver() // game over function
    {
        if (ball.Bottom > 550)
        {

            labelScore2.Text = "Score: " + score.ToString();
            r = random.Next(0, 255);
            g = random.Next(0, 255);
            b = random.Next(0, 255);
            gameOverPanel.BackColor = Color.FromArgb(r, g, b);
            gameOverPanel.Show();
            timer.Stop();
        }
    }

    private void Restart()
    {
        gameOverPanel.Hide();
        score = 0;
        ballSpeedY = 10;
        ballSpeedX = 10;
        racketSpeed = 10;
        ball.Location = new Point(random.Next(12, 772),
            random.Next(12, 120));

        racket.Location = new Point(300, 400);
    }

}
