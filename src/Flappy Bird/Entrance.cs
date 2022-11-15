using System;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Entrance : Form
    {
        bool anyButtonClicked = false;
        public static int entrancePipeSpeed;
        public static int entrancePipeRate;
        bool showOptions = false;
        public void Options()
        {

            if (showOptions == true)
            {
                panel_options.Show();
            }
            else
            {
                panel_options.Hide();
            }
        }
        public Entrance()
        {
            InitializeComponent();
            lbl_hard.Text = "Pipe speed will increase\n each time you score!";
            Options();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            showOptions = true;
            Options();

        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            anyButtonClicked = true;
            entrancePipeSpeed = 3;
            entrancePipeRate = 0;
            panel_options.Hide();
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            anyButtonClicked = true;
            entrancePipeSpeed = 3;
            entrancePipeRate = 1;
            panel_options.Hide();
        }

        private void btn_medium_Click(object sender, EventArgs e)
        {
            anyButtonClicked = true;
            entrancePipeSpeed = 5;
            entrancePipeRate = 0;
            panel_options.Hide();
        }
        public void noButtonClicked()
        {
            if (anyButtonClicked == false)
            {
                entrancePipeSpeed = 3;
                entrancePipeRate = 0;
            }
        }


    }
}
