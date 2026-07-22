namespace Tic_Tac_Toe_;

public partial class Form1 : Form
{
    bool turn = true; //true == X turn // false == O turn
    bool isThereAWinner; //checks if theres a winner
    bool disableAI = true; // i forgot why i put this lmao but i guess it was necessary o-o
    readonly List<Button> buttonList = [];
    readonly Random random = new();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) //adding buttons to the list and automatically choosing play-friend mode unless you change
    {
        buttonList.Add(A1); buttonList.Add(A2); buttonList.Add(A3);
        buttonList.Add(B1); buttonList.Add(B2); buttonList.Add(B3);
        buttonList.Add(C1); buttonList.Add(C2); buttonList.Add(C3);

        buttonPlayFriend.Checked = true;
    }

    private void ButtonClicked(object sender, EventArgs e) //controls what happens if any of the main 9 buttons are clicked
    {
        disableAI = true;
        Button btn = (Button)sender; // i still need to practice with "sender", still couldn't figure out what it actually does
        if (!isThereAWinner)
        {
            if (turn)
            {
                btn.Text = "X";
                btn.BackColor = Color.LimeGreen;
                turn = !turn;
                btn.Enabled = false;
            }
            else if (!turn && buttonPlayFriend.Checked)
            {
                btn.Text = "O";
                btn.BackColor = Color.Orange;
                turn = !turn;
                btn.Enabled = false;
            }

        }
        ChangeLabel();
        WinGame();
        Draw();
        AITurn();
    }

    private void AITurn() // controls what ai does. only activates when you choose PlayAI
    {
        if (!turn && buttonPlayAI.Checked && disableAI)
        {
            while (true)
            {
                int i = random.Next(0, 8);
                if (buttonList[i].Enabled == true)
                {
                    buttonList[i].Text = "O";
                    buttonList[i].BackColor = Color.Orange;
                    turn = !turn;
                    buttonList[i].Enabled = false;
                    WinGame();
                    break;
                }
            }
        }
    }

    private void Restart() // restart game function
    {
        labelTurn.Text = "X";
        turn = true;
        isThereAWinner = false;
        foreach (var button in buttonList)
        {
            button.Text = "";
            button.Enabled = true;
            button.BackColor = DefaultBackColor;
        }
    }

    private void WinGame()
    {
        isThereAWinner = HasWinner();
        if (isThereAWinner)
        {
            disableAI = false;
            ShowWinnerMessage();
            Restart();
        }
    }

    private bool HasWinner()
    {
        return IsWinningLine(A1, A2, A3)
            || IsWinningLine(B1, B2, B3)
            || IsWinningLine(C1, C2, C3)
            || IsWinningLine(A1, B2, C3)
            || IsWinningLine(A3, B2, C1)
            || IsWinningLine(A1, B1, C1)
            || IsWinningLine(A2, B2, C2)
            || IsWinningLine(A3, B3, C3);
    }

    private static bool IsWinningLine(Button first, Button second, Button third)
    {
        return first.Text == second.Text && second.Text == third.Text && first.Text != "";
    }

    private void ShowWinnerMessage()
    {
        string message = (buttonPlayFriend.Checked, turn) switch
        {
            (true, false) => "X won the game!",
            (true, true) => "O won the game!",
            (false, false) => "You won the game!",
            (false, true) => "AI won the game!",
        };
        MessageBox.Show(message, "Win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void Draw() //draw situation
    {
        int DisabledButtonCount = 0;
        foreach (var button in buttonList)
        {
            if (button.Enabled == false)
            {
                DisabledButtonCount++;
            }
            if (DisabledButtonCount == 9 && !isThereAWinner)
            {
                disableAI = false;
                MessageBox.Show("Draw!", "Draw!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restart();
            }
        }
    }

    private void buttonRestart_Click(object sender, EventArgs e) //restart button click method
    {
        Restart();
    }

    private void ChangeLabel() //changes label to show whose turn it is. it's disabled when you're playing against ai
    {
        if (turn && !buttonPlayAI.Checked)
        {
            labelTurn.Show();
            labelTurn.Text = "X";
        }
        else if (!turn && !buttonPlayAI.Checked)
        {
            labelTurn.Show();
            labelTurn.Text = "O";
        }
        else if (buttonPlayAI.Checked)
        {
            labelTurn.Hide();
        }
    }
}
