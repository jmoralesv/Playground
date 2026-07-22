namespace Flappy_Bird
{
    partial class Entrance
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrance));
            pictureBox1 = new PictureBox();
            bird = new PictureBox();
            pipeup = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            options = new PictureBox();
            panel_options = new Panel();
            btn_medium = new Button();
            label1 = new Label();
            lbl_hard = new Label();
            lbl_medium = new Label();
            lbl_easy = new Label();
            btn_hard = new Button();
            btn_easy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)options).BeginInit();
            panel_options.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 83);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // bird
            // 
            bird.Image = (Image)resources.GetObject("bird.Image");
            bird.Location = new Point(153, 43);
            bird.Margin = new Padding(2);
            bird.Name = "bird";
            bird.Size = new Size(96, 89);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 7;
            bird.TabStop = false;
            // 
            // pipeup
            // 
            pipeup.Image = (Image)resources.GetObject("pipeup.Image");
            pipeup.Location = new Point(10, 423);
            pipeup.Margin = new Padding(2);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(62, 277);
            pipeup.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeup.TabIndex = 8;
            pipeup.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(317, 423);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 277);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(78, 423);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 277);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(250, 423);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 277);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox2_Click;
            // 
            // options
            // 
            options.Image = (Image)resources.GetObject("options.Image");
            options.Location = new Point(108, 223);
            options.Margin = new Padding(2);
            options.Name = "options";
            options.Size = new Size(204, 105);
            options.SizeMode = PictureBoxSizeMode.StretchImage;
            options.TabIndex = 9;
            options.TabStop = false;
            options.Click += pictureBox5_Click;
            // 
            // panel_options
            // 
            panel_options.BackColor = Color.IndianRed;
            panel_options.Controls.Add(btn_medium);
            panel_options.Controls.Add(label1);
            panel_options.Controls.Add(lbl_hard);
            panel_options.Controls.Add(lbl_medium);
            panel_options.Controls.Add(lbl_easy);
            panel_options.Controls.Add(btn_hard);
            panel_options.Controls.Add(btn_easy);
            panel_options.Location = new Point(10, 53);
            panel_options.Margin = new Padding(2);
            panel_options.Name = "panel_options";
            panel_options.Size = new Size(368, 398);
            panel_options.TabIndex = 10;
            // 
            // btn_medium
            // 
            btn_medium.Location = new Point(104, 133);
            btn_medium.Margin = new Padding(2);
            btn_medium.Name = "btn_medium";
            btn_medium.Size = new Size(134, 77);
            btn_medium.TabIndex = 11;
            btn_medium.Text = "Medium";
            btn_medium.UseVisualStyleBackColor = true;
            btn_medium.Click += btn_medium_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(13, 256);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 10;
            // 
            // lbl_hard
            // 
            lbl_hard.AutoSize = true;
            lbl_hard.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_hard.ForeColor = SystemColors.MenuText;
            lbl_hard.Location = new Point(86, 318);
            lbl_hard.Margin = new Padding(2, 0, 2, 0);
            lbl_hard.Name = "lbl_hard";
            lbl_hard.Size = new Size(304, 20);
            lbl_hard.TabIndex = 10;
            lbl_hard.Text = "Pipe speed will increase each time you score!";
            // 
            // lbl_medium
            // 
            lbl_medium.AutoSize = true;
            lbl_medium.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_medium.ForeColor = SystemColors.MenuText;
            lbl_medium.Location = new Point(89, 213);
            lbl_medium.Margin = new Padding(2, 0, 2, 0);
            lbl_medium.Name = "lbl_medium";
            lbl_medium.Size = new Size(152, 20);
            lbl_medium.TabIndex = 10;
            lbl_medium.Text = "Pipes will move faster";
            // 
            // lbl_easy
            // 
            lbl_easy.AutoSize = true;
            lbl_easy.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_easy.ForeColor = SystemColors.MenuText;
            lbl_easy.Location = new Point(86, 97);
            lbl_easy.Margin = new Padding(2, 0, 2, 0);
            lbl_easy.Name = "lbl_easy";
            lbl_easy.Size = new Size(153, 20);
            lbl_easy.TabIndex = 10;
            lbl_easy.Text = "Pipes will move slowly";
            // 
            // btn_hard
            // 
            btn_hard.Location = new Point(104, 240);
            btn_hard.Margin = new Padding(2);
            btn_hard.Name = "btn_hard";
            btn_hard.Size = new Size(134, 76);
            btn_hard.TabIndex = 0;
            btn_hard.Text = "Hard";
            btn_hard.UseVisualStyleBackColor = true;
            btn_hard.Click += btn_hard_Click;
            // 
            // btn_easy
            // 
            btn_easy.Location = new Point(104, 17);
            btn_easy.Margin = new Padding(2);
            btn_easy.Name = "btn_easy";
            btn_easy.Size = new Size(134, 76);
            btn_easy.TabIndex = 0;
            btn_easy.Text = "Easy";
            btn_easy.UseVisualStyleBackColor = true;
            btn_easy.Click += btn_easy_Click;
            // 
            // Entrance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(388, 568);
            Controls.Add(panel_options);
            Controls.Add(options);
            Controls.Add(bird);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pipeup);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Entrance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrance";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)options).EndInit();
            panel_options.ResumeLayout(false);
            panel_options.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox options;
        private System.Windows.Forms.Panel panel_options;
        private System.Windows.Forms.Button btn_hard;
        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hard;
        private System.Windows.Forms.Label lbl_easy;
        private System.Windows.Forms.Label lbl_medium;
        private System.Windows.Forms.Button btn_medium;
    }
}