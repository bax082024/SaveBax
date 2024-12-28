namespace DodgingGame
{
    partial class DadgingGameForm
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
            gamePanel = new Panel();
            buttonStart = new Button();
            labelScore = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelScore);
            panel1.Controls.Add(buttonStart);
            panel1.Controls.Add(gamePanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 699);
            panel1.TabIndex = 0;
            // 
            // gamePanel
            // 
            gamePanel.Anchor = AnchorStyles.None;
            gamePanel.BackColor = Color.Transparent;
            gamePanel.Location = new Point(96, 107);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(400, 500);
            gamePanel.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.None;
            buttonStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.Location = new Point(235, 627);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(108, 37);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.Location = new Point(192, 63);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(79, 30);
            labelScore.TabIndex = 2;
            labelScore.Text = "Score :";
            // 
            // DadgingGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(602, 699);
            Controls.Add(panel1);
            Name = "DadgingGameForm";
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
    }
}
