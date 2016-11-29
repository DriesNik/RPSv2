using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSv2
{
    class Player
    {
        protected int score;
        protected string choice;

        public int GetScore()
        {
            return score;
        }
        public string GetChoice()
        {
            return choice;
        }
    }
}
