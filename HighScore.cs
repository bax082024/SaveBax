using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgingGame
{
    public class HighScore
    {
        public string PlayerName { get; set; } = "Player";
        public int Score { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
