using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameFrontEndConsole.Models
{
    public class GameStatus
    {
        public bool IsRunning { get; set; }
        public string GameType { get; set; }
        public DateTime? StartTime { get; set; } = null;
        public DateTime? EndTime { get; set; } = null;

        public bool StartGame(string gameType)
        {
            if (!IsRunning)
            {
                IsRunning = true;
                GameType = gameType;
                StartTime = DateTime.Now;
                return true;
            }

            return false;
        }

        public bool EndGame()
        {
            if (IsRunning)
            {
                IsRunning = false;
                EndTime = DateTime.Now;
                return true;
            }

            return false;
        }

    }
}


