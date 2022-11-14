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
            this.playAgainButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_gameEndBest = new System.Windows.Forms.Label();
            this.lbl_gameEndScore = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            this.panel_gameEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playAgainButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 516);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(444, 90);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(82, 180);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(61, 54);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 6;
            this.bird.TabStop = false;
            // 
            // pipeup
            // 
            this.pipeup.Image = ((System.Drawing.Image)(resources.GetObject("pipeup.Image")));
            this.pipeup.Location = new System.Drawing.Point(335, 294);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(71, 295);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup.TabIndex = 7;
            this.pipeup.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = ((System.Drawing.Image)(resources.GetObject("pipedown.Image")));
            this.pipedown.Location = new System.Drawing.Point(335, -166);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(71, 287);
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
            this.lbl_score.Location = new System.Drawing.Point(12, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(63, 28);
            this.lbl_score.TabIndex = 9;
            this.lbl_score.Text = "Score:";
            // 
            // lbl_scoreAmount
            // 
            this.lbl_scoreAmount.AutoSize = true;
            this.lbl_scoreAmount.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreAmount.Location = new System.Drawing.Point(77, 9);
            this.lbl_scoreAmount.Name = "lbl_scoreAmount";
            this.lbl_scoreAmount.Size = new System.Drawing.Size(22, 28);
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
            this.panel_gameEnd.Location = new System.Drawing.Point(43, 9);
            this.panel_gameEnd.Name = "panel_gameEnd";
            this.panel_gameEnd.Size = new System.Drawing.Size(336, 432);
            this.panel_gameEnd.TabIndex = 10;
            this.panel_gameEnd.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_gameEnd_Paint);
            // 
            // playAgainButton
            // 
            this.playAgainButton.Image = ((System.Drawing.Image)(resources.GetObject("playAgainButton.Image")));
            this.playAgainButton.Location = new System.Drawing.Point(84, 193);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(155, 81);
            this.playAgainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playAgainButton.TabIndex = 10;
            this.playAgainButton.TabStop = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_3);
            // 
            // lbl_gameEndBest
            // 
            this.lbl_gameEndBest.AutoSize = true;
            this.lbl_gameEndBest.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gameEndBest.Location = new System.Drawing.Point(33, 144);
            this.lbl_gameEndBest.Name = "lbl_gameEndBest";
            this.lbl_gameEndBest.Size = new System.Drawing.Size(77, 35);
            this.lbl_gameEndBest.TabIndex = 9;
            this.lbl_gameEndBest.Text = "Best: ";
            // 
            // lbl_gameEndScore
            // 
            this.lbl_gameEndScore.AutoSize = true;
            this.lbl_gameEndScore.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gameEndScore.Location = new System.Drawing.Point(33, 109);
            this.lbl_gameEndScore.Name = "lbl_gameEndScore";
            this.lbl_gameEndScore.Size = new System.Drawing.Size(87, 35);
            this.lbl_gameEndScore.TabIndex = 9;
            this.lbl_gameEndScore.Text = "Score:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(114, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 280);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 606);
            this.Controls.Add(this.panel_gameEnd);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeup);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_scoreAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            this.panel_gameEnd.ResumeLayout(false);
            this.panel_gameEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playAgainButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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

