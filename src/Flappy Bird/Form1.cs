namespace Flappy_Bird;

public partial class Form1 : Form
{
    private readonly Entrance _entrance = new();
    private readonly Random _random = new();

    public Form1()
    {
        InitializeComponent();
    }

    private int _gravity;
    private int _pipeSpeed = Entrance.EntrancePipeSpeed;
    private int _score;
    private int _pipeSpeedRate = Entrance.EntrancePipeRate;

    public void startGame()
    {
        panel_gameEnd.Hide();
        _score = 0;
        bird.Left = 62;
        bird.Top = 146;
        pipedown.Top = -135;
        pipeup.Top = 239;
        pipedown.Left = 251;
        pipeup.Left = 251;
        _pipeSpeed = 3;
        bird.Show();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        bird.Top = _gravity + bird.Top;
        pipedown.Left = pipedown.Left - _pipeSpeed;
        pipeup.Left = pipeup.Left - _pipeSpeed;
        if (pipedown.Left < 0)
        {
            pipedown.Left = 500;
            pipedown.Top = _random.Next(-150, -100);
            _score++;

        }
        if (pipeup.Left < 0)
        {
            pipeup.Left = _random.Next(450, 500);
            pipeup.Top = _random.Next(220, 350);

            _score++;
            _pipeSpeed = _pipeSpeed + _pipeSpeedRate;
        }
        lbl_scoreAmount.Text = _score.ToString();
        gameOver();
    }

    private void gameOver()
    {
        if (bird.Bounds.IntersectsWith(pipedown.Bounds) || bird.Bounds.IntersectsWith(pipeup.Bounds)
            || bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < -40)
        {
            timer1.Enabled = false;
            bird.Hide();
            lbl_gameEndScore.Text = "Score: " + _score;
            panel_gameEnd.Show();
        }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Space)
        {
            timer1.Enabled = true;
            _gravity = -5;
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        panel_gameEnd.Hide();
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
        _gravity = +5;
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
        _entrance.Close();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        this.Hide();
        _entrance.Show();
    }

    private void pictureBox1_Click_3(object sender, EventArgs e)
    {
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
