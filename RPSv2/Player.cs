using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSv2
{
    class Player
    {
        protected int score = 0;
        protected int choice;

        public int GetScore()
        {
            return score;
        }
        public virtual int GetChoice()
        {
            return choice;
        }
        public int AddScore()
        {
            score++;
            return score;
        }
        public virtual int FinalChoice()
        {
            return choice;
        }
        
    }
}
