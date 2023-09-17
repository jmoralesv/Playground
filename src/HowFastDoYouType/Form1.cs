namespace HowFastDoYouType;

public partial class Form1 : Form
{
    private double correctWords = 0;
    private double wrongWords = 0;
    private int seconds = 60;
    private int whichWord = 0;
    private List<string> Words = new();
    private readonly int secondsCalculate = 60;
    private readonly List<Label> labelList = new();
    private readonly Random randomNumber = new();
    private readonly string filePath = "200Words.txt";
    private bool check = true;
    //adding all the labels to labelList
    public void SetList()
    {
        var childrenControls = labelPanel.Controls
            .Cast<Control>()
            .Select(x => new { Control = x, Index = int.Parse(x.Name.Replace("label", string.Empty)) })
            .OrderBy(x => x.Index)
            .Select(x => x.Control)
            .ToList();

        foreach (Control control in childrenControls)
        {
            if (control is Label label)
            {
                labelList.Add(label);
            }
        }
    }

    //changing all the label texts to a random word in the txt file
    public void GetRandomWords()
    {
        foreach (var item in labelList)
        {
            item.Text = Words[randomNumber.Next(0, 200)];
        }
    }

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Words = File.ReadAllLines(filePath).ToList();
        SetList();
        GetRandomWords();

    }

    public void changeColor(int i)
    {

        if (userTextBox.Text == labelList[i].Text || userTextBox.Text == " " + labelList[i].Text)
        {
            labelList[i].ForeColor = Color.Green;
            labelList[i].BackColor = Color.Transparent;
            if (i < 17)
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
            if (i < 17)
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
                item.ForeColor = Color.Black;
            }
        }

    }

    public void StartCountDown()
    {

        if (check)
        {
            countDownTimer.Start();
        }

    }
    private void textBoxKeyPress(object sender, KeyPressEventArgs e)
    {
        StartCountDown();
        if (e.KeyChar == Convert.ToChar(Keys.Space))
        {

            changeColor(whichWord);
        }

    }

    private void label1_Click(object sender, EventArgs e)
    {

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
    public void GameOver()
    {
        correctWords = 0;
        wrongWords = 0;
        check = false;
        lblResult.Text = WPMCalculator().ToString() + " WPM";
        lblCorrectWordsCount.Text = correctWords.ToString();
        lblWrongWordsCount.Text = wrongWords.ToString();
        lblAccuracyAmount.Text = "%" + AccuracyCalculator().ToString();
        labelPanel.Hide();
    }

    public void Restart()
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
            item.ForeColor = Color.Black;
        }
        labelList[whichWord].BackColor = Color.Transparent;
        whichWord = 0;

        userTextBox.Text = String.Empty;
    }

    public int WPMCalculator()
    {
        int result;
        result = Convert.ToInt32((correctWords / (secondsCalculate / 60)));
        return result;
    }
    public double AccuracyCalculator()
    {
        double result;
        result = (correctWords / (correctWords + wrongWords)) * 100;
        return Math.Round(result, 2);
    }

    private void column_Click(object sender, EventArgs e)
    {

    }

    private void lblCorrectWords_Click(object sender, EventArgs e)
    {

    }

    private void btnRestart_Click(object sender, EventArgs e)
    {
        Restart();
    }
}
