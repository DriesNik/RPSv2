using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSv2
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        public void StartGame()
        {
            LaunchIntro();
            ExplainRules();
            GetNumberOfPlayers();
            CollectNames();
            while ((playerOne.GetScore() < 2) && (playerTwo.GetScore() < 2))
            {
                GrabChoices();
                CompareChoices();
            }
            EndGame();
        }

        private void CollectNames()
        {
            playerOne.GetName();
            playerTwo.GetName();
        }

        private string EndGame()
        {
            string ending;
            Console.WriteLine("Would you like to Play Again? Y/N");
            ending = (Console.ReadLine());
            if (ending == "y" )
            {
                StartGame();
                return "hoi";
            }
            else if ( ending == "n")
            {
                return "hoi";
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                EndGame();
                return "hoi";
            }
        }

        

       
        
        private void CompareChoices()
        {
            
            int d;
            d = ((5 + playerOne.FinalChoice() - playerTwo.FinalChoice()) % 5);

            if (d == 0)
            {
                Console.WriteLine("Tie");
            }
            else if(d % 2 == 1)
            {
                Console.WriteLine( playerOne.UseName()+ " Wins");
                playerOne.AddScore();

            }
            else if (d % 2 == 0)
            {
                Console.WriteLine(playerTwo.UseName()+ " Wins");
                playerTwo.AddScore();
            }

        }

        private void GrabChoices()
        {
            playerOne.GetChoice();
            playerTwo.GetChoice();
        }

        public void GetNumberOfPlayers()
        {
            string NumberOfPlayers;
            Console.WriteLine("How many players would you like? 1 or 2");
            NumberOfPlayers = Console.ReadLine();
            if (NumberOfPlayers == "1")
                {
                playerOne = new Human();
                playerTwo = new Computer();
                }
            else if (NumberOfPlayers == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Invalid answer");
                GetNumberOfPlayers();
            }
        }

        

        private void ExplainRules()
        {
            Console.WriteLine("The Object is to Win two times. \n Rock beats Scissors and Lizard \n Paper beats Rock and Spock");
            Console.WriteLine(" Scissors beats Paper and Lizard \n Spock beats Scissors and Rock \n Lizard beats Paper and Spock");
        }

        private void LaunchIntro()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
           
        }
    }
}
