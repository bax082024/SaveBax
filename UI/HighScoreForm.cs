using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DodgingGame;

namespace DodgingGame.UI
{
    public partial class HighScoreForm : Form
    {
        public HighScoreForm()
        {
            InitializeComponent();
            LoadHighScores();
        }

        private void LoadHighScores()
        {
            var highScores = JsonHelper.LoadHighScores();
            listBoxHighScores.Items.Clear();
            foreach (var highScore in highScores)
            {
                listBoxHighScores.Items.Add($"{highScore.PlayerName}: {highScore.Score} - {highScore.Date.ToShortDateString()}");
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string playerName = textBoxInput.Text.Trim();

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int score = GameSession.CurrentScore;

            var highScores = JsonHelper.LoadHighScores();
            highScores.Add(new HighScore { PlayerName = playerName, Score = score });
            highScores.Sort((x, y) => y.Score.CompareTo(x.Score));
            JsonHelper.SaveHighScores(highScores);

            LoadHighScores();

            MessageBox.Show("High score added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxInput.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.LightSkyBlue,  // Top color
                Color.DarkBlue,        // Bottom color
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            }
        }
    }
}
