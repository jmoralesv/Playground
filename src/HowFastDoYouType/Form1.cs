namespace HowFastDoYouType;

public partial class Form1 : Form
{
    private const int SecondsCalculate = 60;
    private const string FilePath = "200Words.txt";
    private readonly List<Label> labelList = [];
    private readonly Random randomNumber = new();
    private double correctWords = 0;
    private double wrongWords = 0;
    private int seconds = 60;
    private int whichWord = 0;
    private bool check = true;
    private string[] Words = [];

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Text = "How Fast Do You Type?";
        Words = File.ReadAllLines(FilePath);
        SetList();
        GetRandomWords();
    }

    private void textBoxKeyPress(object sender, KeyPressEventArgs e)
    {
        StartCountDown();
        if (e.KeyChar == Convert.ToChar(Keys.Space))
        {
            ChangeColor(whichWord);
        }
    }

    private void countDownTimer_Tick(object sender, EventArgs e)
    {
        seconds--;
        textTimer.Text = seconds.ToString();
        if (seconds == 0)
        {
            GameOver();
            countDownTimer.Stop();
        }
    }

    private void btnRestart_Click(object sender, EventArgs e)
    {
        Restart();
    }

    private void SetList()
    {
        var childrenControls = labelPanel.Controls
            .Cast<Control>()
            .Select(x => new { Control = x, Index = int.Parse(x.Name.Replace("label", string.Empty)) })
            .OrderBy(x => x.Index)
            .Select(x => x.Control)
            .ToList();

        foreach (var control in childrenControls)
        {
            if (control is Label label)
            {
                labelList.Add(label);
            }
        }
    }

    private void GetRandomWords()
    {
        foreach (var item in labelList)
        {
            item.Text = Words[randomNumber.Next(Words.Length)];
        }
    }

    private void ChangeColor(int i)
    {
        if (userTextBox.Text is string text &&
            (text == labelList[i].Text || text == " " + labelList[i].Text))
        {
            labelList[i].ForeColor = Color.Green;
            labelList[i].BackColor = Color.Transparent;
            if (i < labelList.Count - 1)
            {
                labelList[i + 1].BackColor = Color.Gray;
            }
            i++;
            whichWord = i;
            userTextBox.Text = string.Empty;
            correctWords++;
        }
        else
        {
            labelList[i].ForeColor = Color.Red;
            labelList[i].BackColor = Color.Transparent;
            if (i < labelList.Count - 1)
            {
                labelList[i + 1].BackColor = Color.Gray;
            }
            i++;
            whichWord = i;
            userTextBox.Text = string.Empty;
            wrongWords++;
        }

        if (whichWord % 18 == 0 && whichWord != 0)
        {
            GetRandomWords();
            whichWord = 0;
            foreach (var item in labelList)
            {
                item.ForeColor = SystemColors.ControlText;
            }
        }
    }

    private void StartCountDown()
    {
        if (check)
        {
            countDownTimer.Start();
        }
    }

    private void GameOver()
    {
        check = false;
        lblResult.Text = $"{WPMCalculator()} WPM";
        lblCorrectWordsCount.Text = correctWords.ToString();
        lblWrongWordsCount.Text = wrongWords.ToString();
        lblAccuracyAmount.Text = $"%{AccuracyCalculator()}";
        labelPanel.Hide();

        // Reset counts after displaying results
        correctWords = 0;
        wrongWords = 0;
    }

    private void Restart()
    {
        check = true;
        countDownTimer.Stop();
        labelPanel.Show();
        lblCorrectWordsCount.Text = "0";
        lblWrongWordsCount.Text = "0";
        lblAccuracyAmount.Text = "0";
        lblResult.Text = "0";
        GetRandomWords();
        textTimer.Text = "60";
        seconds = 60;
        foreach (var item in labelList)
        {
            item.ForeColor = SystemColors.ControlText;
        }
        labelList[whichWord].BackColor = Color.Transparent;
        whichWord = 0;
        userTextBox.Text = string.Empty;
    }

    private int WPMCalculator()
    {
        // Calculate WPM: (words / minutes) where minutes = seconds / 60
        double minutes = SecondsCalculate / 60.0;
        return Convert.ToInt32(correctWords / minutes);
    }

    private double AccuracyCalculator()
    {
        double totalWords = correctWords + wrongWords;
        if (totalWords == 0)
        {
            return 0;
        }

        return Math.Round((correctWords / totalWords) * 100, 2);
    }
}
