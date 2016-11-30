using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSv2
{
    class Computer : Player
    {
        public override int GetChoice()
        {

            Random random = new Random();
            int compChoice;
            compChoice = random.Next(5);
            switch (compChoice)
            {
                case 0:
                    choice = 0;
                    //"spock";
                    return choice;
                case 1:
                    choice = 1;
                        //"rock";
                    return choice;
                case 2:
                    choice = 2;
                    //"lizard";
                    return choice;
                case 3:
                    choice = 3;
                    //"scissors";
                    return choice;
                case 4:
                    choice = 4;
                        //"paper";
                    return choice;

                default:
                    Console.WriteLine("invalid choice");
                    GetChoice();
                    break;
            }
            return choice;
        }
    }
}

