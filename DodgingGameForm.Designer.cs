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
            labelTitel = new Label();
            labelScore = new Label();
            buttonStart = new Button();
            gamePanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            buttonStart.BackColor = Color.SlateGray;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel gamePanel;
        private Button buttonStart;
        private Label labelScore;
        private Label labelTitel;
    }
}
