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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_scoreAmount = new System.Windows.Forms.Label();
            this.panel_gameEnd = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.playAgainButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_gameEndBest = new System.Windows.Forms.Label();
            this.lbl_gameEndScore = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            this.panel_gameEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgainButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 419);
            this.ground.Margin = new System.Windows.Forms.Padding(2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(333, 73);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(62, 146);
            this.bird.Margin = new System.Windows.Forms.Padding(2);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(46, 44);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 6;
            this.bird.TabStop = false;
            // 
            // pipeup
            // 
            this.pipeup.Image = ((System.Drawing.Image)(resources.GetObject("pipeup.Image")));
            this.pipeup.Location = new System.Drawing.Point(251, 239);
            this.pipeup.Margin = new System.Windows.Forms.Padding(2);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(53, 240);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup.TabIndex = 7;
            this.pipeup.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = ((System.Drawing.Image)(resources.GetObject("pipedown.Image")));
            this.pipedown.Location = new System.Drawing.Point(251, -135);
            this.pipedown.Margin = new System.Windows.Forms.Padding(2);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(53, 233);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 8;
            this.pipedown.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(9, 7);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(51, 21);
            this.lbl_score.TabIndex = 9;
            this.lbl_score.Text = "Score:";
            // 
            // lbl_scoreAmount
            // 
            this.lbl_scoreAmount.AutoSize = true;
            this.lbl_scoreAmount.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreAmount.Location = new System.Drawing.Point(58, 7);
            this.lbl_scoreAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_scoreAmount.Name = "lbl_scoreAmount";
            this.lbl_scoreAmount.Size = new System.Drawing.Size(18, 21);
            this.lbl_scoreAmount.TabIndex = 9;
            this.lbl_scoreAmount.Text = "0";
            // 
            // panel_gameEnd
            // 
            this.panel_gameEnd.BackColor = System.Drawing.Color.IndianRed;
            this.panel_gameEnd.Controls.Add(this.pictureBox3);
            this.panel_gameEnd.Controls.Add(this.playAgainButton);
            this.panel_gameEnd.Controls.Add(this.pictureBox1);
            this.panel_gameEnd.Controls.Add(this.lbl_gameEndBest);
            this.panel_gameEnd.Controls.Add(this.lbl_gameEndScore);
            this.panel_gameEnd.Controls.Add(this.pictureBox2);
            this.panel_gameEnd.Location = new System.Drawing.Point(32, 7);
            this.panel_gameEnd.Margin = new System.Windows.Forms.Padding(2);
            this.panel_gameEnd.Name = "panel_gameEnd";
            this.panel_gameEnd.Size = new System.Drawing.Size(252, 351);
            this.panel_gameEnd.TabIndex = 10;
            this.panel_gameEnd.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_gameEnd_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 228);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.Image = ((System.Drawing.Image)(resources.GetObject("playAgainButton.Image")));
            this.playAgainButton.Location = new System.Drawing.Point(63, 157);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(2);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(116, 66);
            this.playAgainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playAgainButton.TabIndex = 10;
            this.playAgainButton.TabStop = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_3);
            // 
            // lbl_gameEndBest
            // 
            this.lbl_gameEndBest.AutoSize = true;
            this.lbl_gameEndBest.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gameEndBest.Location = new System.Drawing.Point(25, 117);
            this.lbl_gameEndBest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gameEndBest.Name = "lbl_gameEndBest";
            this.lbl_gameEndBest.Size = new System.Drawing.Size(60, 27);
            this.lbl_gameEndBest.TabIndex = 9;
            this.lbl_gameEndBest.Text = "Best: ";
            // 
            // lbl_gameEndScore
            // 
            this.lbl_gameEndScore.AutoSize = true;
            this.lbl_gameEndScore.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gameEndScore.Location = new System.Drawing.Point(25, 89);
            this.lbl_gameEndScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gameEndScore.Name = "lbl_gameEndScore";
            this.lbl_gameEndScore.Size = new System.Drawing.Size(68, 27);
            this.lbl_gameEndScore.TabIndex = 9;
            this.lbl_gameEndScore.Text = "Score:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 197);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 492);
            this.Controls.Add(this.panel_gameEnd);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeup);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_scoreAmount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            this.panel_gameEnd.ResumeLayout(false);
            this.panel_gameEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playAgainButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

