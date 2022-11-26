namespace Tic_Tac_Toe_
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
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelTurn = new System.Windows.Forms.Label();
            this.buttonPlayFriend = new System.Windows.Forms.RadioButton();
            this.buttonPlayAI = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(80, 113);
            this.A1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(54, 58);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(80, 176);
            this.B1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(54, 58);
            this.B1.TabIndex = 0;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(80, 240);
            this.C1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(54, 58);
            this.C1.TabIndex = 0;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(138, 113);
            this.A2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(54, 58);
            this.A2.TabIndex = 0;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(138, 176);
            this.B2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(54, 58);
            this.B2.TabIndex = 0;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(138, 240);
            this.C2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(54, 58);
            this.C2.TabIndex = 0;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(196, 113);
            this.A3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(54, 58);
            this.A3.TabIndex = 0;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(196, 176);
            this.B3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(54, 58);
            this.B3.TabIndex = 0;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(196, 240);
            this.C3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(54, 58);
            this.C3.TabIndex = 0;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(230, 327);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(69, 27);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTurn.Location = new System.Drawing.Point(152, 63);
            this.labelTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(28, 30);
            this.labelTurn.TabIndex = 2;
            this.labelTurn.Text = "X";
            // 
            // buttonPlayFriend
            // 
            this.buttonPlayFriend.AutoSize = true;
            this.buttonPlayFriend.Location = new System.Drawing.Point(80, 27);
            this.buttonPlayFriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlayFriend.Name = "buttonPlayFriend";
            this.buttonPlayFriend.Size = new System.Drawing.Size(102, 17);
            this.buttonPlayFriend.TabIndex = 3;
            this.buttonPlayFriend.TabStop = true;
            this.buttonPlayFriend.Text = "Play With Friend";
            this.buttonPlayFriend.UseVisualStyleBackColor = true;
            // 
            // buttonPlayAI
            // 
            this.buttonPlayAI.AutoSize = true;
            this.buttonPlayAI.Location = new System.Drawing.Point(196, 27);
            this.buttonPlayAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlayAI.Name = "buttonPlayAI";
            this.buttonPlayAI.Size = new System.Drawing.Size(83, 17);
            this.buttonPlayAI.TabIndex = 3;
            this.buttonPlayAI.TabStop = true;
            this.buttonPlayAI.Text = "Play With AI";
            this.buttonPlayAI.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 397);
            this.Controls.Add(this.buttonPlayAI);
            this.Controls.Add(this.buttonPlayFriend);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.RadioButton buttonPlayFriend;
        private System.Windows.Forms.RadioButton buttonPlayAI;
    }
}

