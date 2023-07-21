using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors;

namespace RockPaperScissors
{
    public class GameController
    {

        protected Validation validation = new Validation();
        protected enum Hand { Rock = 1, Paper, Scissors};
        protected enum Outcome { Win, Lose, Tie };


        protected Hand playerHand { get; set; }
        protected Hand computerHand { get; set; }


        protected char userInput { get; set; }


        protected Hand GetUserHand()
        {
            while (!validation.validateInput(userInput))
            {
                Console.WriteLine(TextDisplay.error.invalidInput);
                userInput = Convert.ToChar(Console.ReadLine());
            }
            switch (Char.ToUpper(userInput))
            {
                case 'R':
                    playerHand = Hand.Rock;
                    break;
                case 'P':
                    playerHand = Hand.Paper;
                    break;
                case 'S':
                    playerHand = Hand.Scissors;
                    break;
                    default:
                    throw new Exception(TextDisplay.error.invalidOutcome);
            }
            return playerHand;
        }

        protected Outcome DetermineWinner()
        {
            if (playerHand == computerHand)
                return Outcome.Tie;
            else if (playerHand == Hand.Rock && computerHand == Hand.Scissors )
                return Outcome.Win;
            else if (playerHand == Hand.Paper && computerHand == Hand.Rock)
                return Outcome.Win;
            else if (playerHand == Hand.Scissors && computerHand == Hand.Paper)
                return Outcome.Win;
            else if (playerHand == Hand.Rock && computerHand == Hand.Paper)
                return Outcome.Lose;
            else if (playerHand == Hand.Paper && computerHand == Hand.Scissors)
                return Outcome.Lose;
            else if (playerHand == Hand.Scissors && computerHand == Hand.Rock)
                return Outcome.Lose;
            else
            {
                Console.WriteLine(TextDisplay.error.invalidOutcome);
                return Outcome.Tie;
            }
        }
    }

    public class StandardGameController : GameController
    {
        public StandardGameController()
        {
            PlayGame();
        }

        private void PlayGame()
        {
            bool gameOver = false;
            var rand = new Random();
            char response;

            while (!gameOver)
            {
                Console.WriteLine(TextDisplay.instruction.standardGameRules);
                Console.WriteLine(TextDisplay.instruction.standardGameInitialInstructions);
                userInput = Convert.ToChar(Console.ReadLine());
                GetUserHand();
                computerHand = (Hand)rand.Next(1,4);
                Console.Clear();
                Console.WriteLine("The Computer Chose: {0}", computerHand);
                Console.WriteLine("You Chose: {0}", playerHand);
                
                //this is the same logic in the standard game and LCCP game mode and so it could be a seperate method in the parent class
                if (DetermineWinner() == Outcome.Win)
                {
                    Console.WriteLine(TextDisplay.Outcome.win);
                }else if(DetermineWinner() == Outcome.Lose)
                {
                    Console.WriteLine(TextDisplay.Outcome.lose);
                }
                else
                {
                    Console.WriteLine(TextDisplay.Outcome.tie);
                }
                Console.WriteLine(TextDisplay.instruction.playAgain);
                response = Convert.ToChar(Console.ReadLine());

                while (validation.ValidateResponse(response) == false)
                {
                    Console.WriteLine(TextDisplay.error.invalidInput);
                    response = Convert.ToChar(Console.ReadLine());
                }
                if (char.ToUpper(response) == 'N')
                {
                    gameOver = true;
                    Console.Clear();
                }
            }
        }
    }

    public class LastChoiceGameController : GameController
    {
        public LastChoiceGameController()
        {
            PlayGame();
        }

        private void PlayGame()
        {
         //Similar logic except instead of a random value given to the computers hand, it will be set to the same value as the players hand from the previous gamw
        }

    }

    public class LizardSpockGameController : GameController
    {
        public LizardSpockGameController()
        {
            PlayGame();
        }

        private void PlayGame()
        {
            //Similar logic except the outcome is calculated differently and has 2 extra hands. 
        }

    }


}
