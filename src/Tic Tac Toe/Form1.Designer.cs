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
            this.A1.Location = new System.Drawing.Point(106, 139);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(72, 72);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(106, 217);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(72, 72);
            this.B1.TabIndex = 0;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(106, 295);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(72, 72);
            this.C1.TabIndex = 0;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(184, 139);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(72, 72);
            this.A2.TabIndex = 0;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(184, 217);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(72, 72);
            this.B2.TabIndex = 0;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(184, 295);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(72, 72);
            this.C2.TabIndex = 0;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(262, 139);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(72, 72);
            this.A3.TabIndex = 0;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(262, 217);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(72, 72);
            this.B3.TabIndex = 0;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(262, 295);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(72, 72);
            this.C3.TabIndex = 0;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(307, 403);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(92, 33);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTurn.Location = new System.Drawing.Point(203, 77);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(37, 38);
            this.labelTurn.TabIndex = 2;
            this.labelTurn.Text = "X";
            // 
            // buttonPlayFriend
            // 
            this.buttonPlayFriend.AutoSize = true;
            this.buttonPlayFriend.Location = new System.Drawing.Point(106, 33);
            this.buttonPlayFriend.Name = "buttonPlayFriend";
            this.buttonPlayFriend.Size = new System.Drawing.Size(125, 20);
            this.buttonPlayFriend.TabIndex = 3;
            this.buttonPlayFriend.TabStop = true;
            this.buttonPlayFriend.Text = "Play With Friend";
            this.buttonPlayFriend.UseVisualStyleBackColor = true;
            // 
            // buttonPlayAI
            // 
            this.buttonPlayAI.AutoSize = true;
            this.buttonPlayAI.Location = new System.Drawing.Point(262, 33);
            this.buttonPlayAI.Name = "buttonPlayAI";
            this.buttonPlayAI.Size = new System.Drawing.Size(99, 20);
            this.buttonPlayAI.TabIndex = 3;
            this.buttonPlayAI.TabStop = true;
            this.buttonPlayAI.Text = "Play With AI";
            this.buttonPlayAI.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 489);
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
            this.Name = "Form1";
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

