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
        protected string name;


        public int GetScore()
        {
            return score;
        }
        public string UseName()
        {
            return name;
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
        public virtual string GetName()
        {
            return name;
        }
        
    }
}
