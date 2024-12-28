namespace DodgingGame.UI
{
    partial class HighScoreForm
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            listBoxHighScores = new ListBox();
            label1 = new Label();
            textBoxInput = new TextBox();
            btnAddName = new Button();
            btnCancel = new Button();
            label2 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 531);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(319, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(74, 17);
            toolStripStatusLabel1.Text = "Bax Creation";
            // 
            // listBoxHighScores
            // 
            listBoxHighScores.Anchor = AnchorStyles.None;
            listBoxHighScores.BackColor = SystemColors.Info;
            listBoxHighScores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxHighScores.ForeColor = Color.DarkSlateGray;
            listBoxHighScores.FormattingEnabled = true;
            listBoxHighScores.ItemHeight = 21;
            listBoxHighScores.Location = new Point(46, 59);
            listBoxHighScores.Name = "listBoxHighScores";
            listBoxHighScores.Size = new Size(229, 298);
            listBoxHighScores.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 26);
            label1.TabIndex = 2;
            label1.Text = "HighScore";
            // 
            // textBoxInput
            // 
            textBoxInput.Anchor = AnchorStyles.None;
            textBoxInput.Location = new Point(67, 407);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(176, 23);
            textBoxInput.TabIndex = 3;
            // 
            // btnAddName
            // 
            btnAddName.Anchor = AnchorStyles.None;
            btnAddName.BackColor = Color.CadetBlue;
            btnAddName.FlatStyle = FlatStyle.Popup;
            btnAddName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddName.Location = new Point(101, 446);
            btnAddName.Name = "btnAddName";
            btnAddName.Size = new Size(102, 27);
            btnAddName.TabIndex = 4;
            btnAddName.Text = "Add Name";
            btnAddName.UseVisualStyleBackColor = false;
            btnAddName.Click += btnAddName_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.SlateBlue;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(101, 479);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(87, 389);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 6;
            label2.Text = "Add Your Name :";
            // 
            // HighScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(319, 553);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnAddName);
            Controls.Add(textBoxInput);
            Controls.Add(label1);
            Controls.Add(listBoxHighScores);
            Controls.Add(statusStrip1);
            Name = "HighScoreForm";
            Text = "HighScore";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ListBox listBoxHighScores;
        private Label label1;
        private TextBox textBoxInput;
        private Button btnAddName;
        private Button btnCancel;
        private Label label2;
    }
}