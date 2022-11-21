namespace PongGame
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
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.area = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.labelRestart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.area)).BeginInit();
            this.gameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Salmon;
            this.ball.Location = new System.Drawing.Point(772, 12);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(16, 16);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ControlText;
            this.racket.Location = new System.Drawing.Point(350, 479);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(102, 36);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // area
            // 
            this.area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.area.Location = new System.Drawing.Point(0, 0);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(800, 604);
            this.area.TabIndex = 1;
            this.area.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(360, 225);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(71, 81);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gameOverPanel.Controls.Add(this.labelScore2);
            this.gameOverPanel.Controls.Add(this.labelRestart);
            this.gameOverPanel.Controls.Add(this.labelGameOver);
            this.gameOverPanel.Location = new System.Drawing.Point(217, 97);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(359, 304);
            this.gameOverPanel.TabIndex = 3;
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGameOver.ForeColor = System.Drawing.Color.IndianRed;
            this.labelGameOver.Location = new System.Drawing.Point(83, 43);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(179, 38);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "Game Over!";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelScore2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelScore2.Location = new System.Drawing.Point(28, 117);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(93, 32);
            this.labelScore2.TabIndex = 0;
            this.labelScore2.Text = "Score: ";
            // 
            // labelRestart
            // 
            this.labelRestart.AutoSize = true;
            this.labelRestart.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRestart.Location = new System.Drawing.Point(14, 184);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(333, 46);
            this.labelRestart.TabIndex = 0;
            this.labelRestart.Text = "Press F2 to restart!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.gameOverPanel);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.area);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Pong Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.area)).EndInit();
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox area;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.Label labelGameOver;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

