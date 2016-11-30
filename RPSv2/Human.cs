using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSv2
{
    class Human : Player
    {
        public override string GetName()
        {
            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();
            return name;
        }

        public override int GetChoice()
        {
            Console.WriteLine("Make your Choice");
            Console.WriteLine("Lizard Spock Scissors Paper Rock");
            string duh = (Console.ReadLine().ToLower());
            switch(duh)
            {
                case "rock":
                    choice = 1;
                    return choice;
                case "paper":
                    choice = 2;
                    return choice;
                case "scissors":
                    choice = 3;
                    return choice;
                case "lizard":
                    choice = 4;
                    return choice;
                case "spock":
                    choice = 5;
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
