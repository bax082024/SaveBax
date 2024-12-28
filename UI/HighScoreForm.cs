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


    }
}
