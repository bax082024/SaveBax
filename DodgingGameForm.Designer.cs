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
            labelLevel = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelTitel = new Label();
            labelScore = new Label();
            buttonStart = new Button();
            gamePanel = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(labelLevel);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
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
            // labelLevel
            // 
            labelLevel.Anchor = AnchorStyles.None;
            labelLevel.AutoSize = true;
            labelLevel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLevel.ForeColor = Color.White;
            labelLevel.Location = new Point(335, 74);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(93, 30);
            labelLevel.TabIndex = 11;
            labelLevel.Text = "Level : 1";
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackgroundImage = Properties.Resources.puddle;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(507, 597);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(83, 77);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackgroundImage = Properties.Resources.boot;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(12, 597);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(83, 77);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImage = Properties.Resources.rain1;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(507, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(83, 77);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImage = Properties.Resources.rain1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 77);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
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
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Properties.Resources.yellowumbrella;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(7, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 77);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.greenumbrella;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(507, 271);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 77);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelTitel
            // 
            labelTitel.Anchor = AnchorStyles.None;
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
            labelScore.Anchor = AnchorStyles.None;
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.ForeColor = Color.White;
            labelScore.Location = new Point(129, 74);
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 677);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(602, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(74, 17);
            toolStripStatusLabel1.Text = "Bax Creation";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label labelLevel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
