namespace DodgingGame
{
    partial class DodgingGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelTitel = new Label();
            labelScore = new Label();
            buttonStart = new Button();
            gamePanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelTitel);
            panel1.Controls.Add(labelScore);
            panel1.Controls.Add(buttonStart);
            panel1.Controls.Add(gamePanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 699);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(199, 52);
            label1.Name = "label1";
            label1.Size = new Size(191, 22);
            label1.TabIndex = 6;
            label1.Text = "From The Rain !!!";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.yellowumbrella;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(23, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 77);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.greenumbrella;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(496, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 77);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelTitel
            // 
            labelTitel.AutoSize = true;
            labelTitel.BackColor = Color.Transparent;
            labelTitel.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitel.ForeColor = Color.Brown;
            labelTitel.Location = new Point(148, 0);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(295, 63);
            labelTitel.TabIndex = 3;
            labelTitel.Text = "Save Bax";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.ForeColor = Color.White;
            labelScore.Location = new Point(208, 74);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(97, 30);
            labelScore.TabIndex = 2;
            labelScore.Text = "Score : 0";
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.None;
            buttonStart.BackColor = Color.CadetBlue;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.Location = new Point(235, 627);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(108, 37);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // gamePanel
            // 
            gamePanel.Anchor = AnchorStyles.None;
            gamePanel.BackColor = Color.Black;
            gamePanel.BorderStyle = BorderStyle.FixedSingle;
            gamePanel.Location = new Point(96, 107);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(400, 500);
            gamePanel.TabIndex = 0;
            // 
            // DodgingGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(602, 699);
            Controls.Add(panel1);
            Name = "DodgingGameForm";
            Text = "Dodging Game";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel gamePanel;
        private Button buttonStart;
        private Label labelScore;
        private Label labelTitel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
