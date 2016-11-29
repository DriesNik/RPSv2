using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSv2
{
    class Game
    {
        public void StartGame()
        {
            LaunchIntro();
            ExplainRules();
            GetNumberOfPlayers();

        }

        private void GetNumberOfPlayers()
        {
            string NumberOfPlayers;
            Console.WriteLine("How many players would you like? 1 or 2");
            NumberOfPlayers = Console.ReadLine();
            if (NumberOfPlayers == "1")
                {
                Player playerOne = new Human();
                Player playerTwo = new Computer();
                }
            else if (NumberOfPlayers == "2")
            {
                Player playerOne = new Human();
                Player playerTwo = new Computer();
            }
            else
            {
                Console.WriteLine("Invalid answer");
                GetNumberOfPlayers();
            }
        }

        

        private void ExplainRules()
        {
            Console.WriteLine("The Rules Go here for now");

        }

        private void LaunchIntro()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
           
        }
    }
}
