namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ground = new PictureBox();
            bird = new PictureBox();
            pipeup = new PictureBox();
            pipedown = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lbl_score = new Label();
            lbl_scoreAmount = new Label();
            panel_gameEnd = new Panel();
            pictureBox3 = new PictureBox();
            playAgainButton = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_gameEndBest = new Label();
            lbl_gameEndScore = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            panel_gameEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playAgainButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ground
            // 
            ground.Dock = DockStyle.Bottom;
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(0, 484);
            ground.Margin = new Padding(2);
            ground.Name = "ground";
            ground.Size = new Size(388, 84);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // bird
            // 
            bird.Image = (Image)resources.GetObject("bird.Image");
            bird.Location = new Point(72, 168);
            bird.Margin = new Padding(2);
            bird.Name = "bird";
            bird.Size = new Size(54, 51);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 6;
            bird.TabStop = false;
            // 
            // pipeup
            // 
            pipeup.Image = (Image)resources.GetObject("pipeup.Image");
            pipeup.Location = new Point(293, 276);
            pipeup.Margin = new Padding(2);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(62, 277);
            pipeup.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeup.TabIndex = 7;
            pipeup.TabStop = false;
            // 
            // pipedown
            // 
            pipedown.Image = (Image)resources.GetObject("pipedown.Image");
            pipedown.Location = new Point(293, -156);
            pipedown.Margin = new Padding(2);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(62, 269);
            pipedown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipedown.TabIndex = 8;
            pipedown.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.Font = new Font("Yu Gothic UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_score.Location = new Point(10, 8);
            lbl_score.Margin = new Padding(2, 0, 2, 0);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(51, 21);
            lbl_score.TabIndex = 9;
            lbl_score.Text = "Score:";
            // 
            // lbl_scoreAmount
            // 
            lbl_scoreAmount.AutoSize = true;
            lbl_scoreAmount.Font = new Font("Yu Gothic UI Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_scoreAmount.Location = new Point(68, 8);
            lbl_scoreAmount.Margin = new Padding(2, 0, 2, 0);
            lbl_scoreAmount.Name = "lbl_scoreAmount";
            lbl_scoreAmount.Size = new Size(18, 21);
            lbl_scoreAmount.TabIndex = 9;
            lbl_scoreAmount.Text = "0";
            // 
            // panel_gameEnd
            // 
            panel_gameEnd.BackColor = Color.IndianRed;
            panel_gameEnd.Controls.Add(pictureBox3);
            panel_gameEnd.Controls.Add(playAgainButton);
            panel_gameEnd.Controls.Add(pictureBox1);
            panel_gameEnd.Controls.Add(lbl_gameEndBest);
            panel_gameEnd.Controls.Add(lbl_gameEndScore);
            panel_gameEnd.Controls.Add(pictureBox2);
            panel_gameEnd.Location = new Point(37, 8);
            panel_gameEnd.Margin = new Padding(2);
            panel_gameEnd.Name = "panel_gameEnd";
            panel_gameEnd.Size = new Size(294, 405);
            panel_gameEnd.TabIndex = 10;
            panel_gameEnd.Paint += panel_gameEnd_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 263);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(145, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // playAgainButton
            // 
            playAgainButton.Image = (Image)resources.GetObject("playAgainButton.Image");
            playAgainButton.Location = new Point(74, 181);
            playAgainButton.Margin = new Padding(2);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(135, 76);
            playAgainButton.SizeMode = PictureBoxSizeMode.StretchImage;
            playAgainButton.TabIndex = 10;
            playAgainButton.TabStop = false;
            playAgainButton.Click += playAgainButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_3;
            // 
            // lbl_gameEndBest
            // 
            lbl_gameEndBest.AutoSize = true;
            lbl_gameEndBest.Font = new Font("Impact", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl_gameEndBest.Location = new Point(29, 135);
            lbl_gameEndBest.Margin = new Padding(2, 0, 2, 0);
            lbl_gameEndBest.Name = "lbl_gameEndBest";
            lbl_gameEndBest.Size = new Size(60, 27);
            lbl_gameEndBest.TabIndex = 9;
            lbl_gameEndBest.Text = "Best: ";
            // 
            // lbl_gameEndScore
            // 
            lbl_gameEndScore.AutoSize = true;
            lbl_gameEndScore.Font = new Font("Impact", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl_gameEndScore.Location = new Point(29, 103);
            lbl_gameEndScore.Margin = new Padding(2, 0, 2, 0);
            lbl_gameEndScore.Name = "lbl_gameEndScore";
            lbl_gameEndScore.Size = new Size(68, 27);
            lbl_gameEndScore.TabIndex = 9;
            lbl_gameEndScore.Text = "Score:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(100, 227);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(388, 568);
            Controls.Add(panel_gameEnd);
            Controls.Add(bird);
            Controls.Add(ground);
            Controls.Add(pipeup);
            Controls.Add(pipedown);
            Controls.Add(lbl_score);
            Controls.Add(lbl_scoreAmount);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            panel_gameEnd.ResumeLayout(false);
            panel_gameEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playAgainButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_scoreAmount;
        private System.Windows.Forms.Panel panel_gameEnd;
        private System.Windows.Forms.PictureBox playAgainButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_gameEndBest;
        private System.Windows.Forms.Label lbl_gameEndScore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

