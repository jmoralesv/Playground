using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_
{
    public partial class Form1 : Form
    {
        bool turn = true; //true == X turn // false == O turn
        bool isThereAWinner = false; //checks if theres a winner
        bool disableAI = true; // i forgot why i put this lmao but i guess it was necessary o-o
        readonly List<Button> buttonList = new List<Button>();
        readonly Random random = new Random();

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
            Button btn = (Button)sender; // i still need to practice with "sender", still couldnt figure out what it actually does
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
            //horizontal winner check
            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "")
            {
                disableAI = false;
                isThereAWinner = true;
            }
            if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
            {
                disableAI = false;
                isThereAWinner = true;
            }
            if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
            {
                disableAI = false;
                isThereAWinner = true;
            }

            //diagonal winner check

            if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
            {
                disableAI = false;
                isThereAWinner = true;
            }
            if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "")
            {
                disableAI = false;
                isThereAWinner = true;
            }
            //vertical winner check
            if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "")
            {
                disableAI = false;
                isThereAWinner = true;
            }
            if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "")
            {
                disableAI = false;
                isThereAWinner = true;
            }
            if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "")
            {
                disableAI = false;
                isThereAWinner = true;
            }

            if (isThereAWinner)
            {
                if (!turn && buttonPlayFriend.Checked)
                {
                    MessageBox.Show("X won the game!");
                }
                else if (isThereAWinner && turn && buttonPlayFriend.Checked)
                {
                    MessageBox.Show("O won the game!");
                }
                else if (isThereAWinner && !turn && buttonPlayAI.Checked)
                {
                    MessageBox.Show("You won the game!");
                }
                else if (isThereAWinner && turn && buttonPlayAI.Checked)
                {
                    MessageBox.Show("AI won the game!");
                }
                Restart();
            }
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
                    MessageBox.Show("Draw!");
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
}
