using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSv2
{
    class Human : Player
    {


        public override int GetChoice()
        {
            Console.WriteLine(" Make your Choice");
            Console.WriteLine(" Lizard Spock Scissors Paper Rock");
            string duh = (Console.ReadLine().ToLower());
            switch(duh)
            {
                case "spock":
                    choice = 0;
                    return choice;
                case "rock":
                    choice = 1;
                    return choice;
                case "lizard":
                    choice = 2;
                    return choice;
                case "scissors":
                    choice = 3;
                    return choice;
                case "paper":
                    choice = 4;
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
