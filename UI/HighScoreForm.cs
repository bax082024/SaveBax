using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Get the last game score (you can pass it as a parameter or retrieve it from another source)
            int score = GameSession.CurrentScore; // This assumes you track the score in the main game

            // Save the new high score
            var highScores = JsonHelper.LoadHighScores();
            highScores.Add(new HighScore { PlayerName = playerName, Score = score });
            highScores.Sort((x, y) => y.Score.CompareTo(x.Score)); // Sort by highest score
            JsonHelper.SaveHighScores(highScores);

            // Update the list box
            LoadHighScores();

            MessageBox.Show("High score added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input
            textBoxInput.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
