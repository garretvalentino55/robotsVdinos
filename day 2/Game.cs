using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Game
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        int playerOneScore;
        int playerTwoScore;

        //Constructor - Sets the scores to 0 when a new game is created
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }
        //Don't change anything above this ^^^^^^^^^^^^

        //Member Methods - All your methods go below here!

        public int Diceroll(Random random) 
        {
            random.Next(1, 6);
            int x = random.Next(1, 6);
            return x;
        }
        public int CompareRolls(Random shoe) 
        {
            int playerone = Diceroll(shoe);
            Console.WriteLine(playerone);
            int playertwo = Diceroll(shoe);
            Console.WriteLine(playertwo);
            int winningPlayer = 0;
            if (playerone > playertwo)
            {
                playerOneScore++;
            }
            if (playertwo > playerone)
            {
                playerTwoScore++;
            }
            return winningPlayer;
        }
        public void DisplayGameWinner(Random bluetang) 
        {
            Console.WriteLine(playerOneScore + " to " + playerTwoScore);
            if (playerOneScore > playerTwoScore) 
            {
                Console.WriteLine("And the Winner is Player 1");
                
            }
           else if (playerOneScore < playerTwoScore) 
            {
                Console.WriteLine("And the Winner is Player 2");
            }
            else
            {
                Console.WriteLine("No One Wins You Both Suck");
            }
        }   











        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
        public void RunGame()
        {
            while (true)
            {
                Random random = new Random();
                CompareRolls(random);
                Console.ReadLine();
                DisplayGameWinner(random);
                Console.ReadLine();
            }

        }
    }
}
