using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class TextDisplay
    {
        //instead of readonly strings, this class could have been a set of void tasks to neatly write out multiple lines on the console
        public static class instruction
        {
            public static readonly string welcome = "Hello and welcome to Rock Paper and Scissors";

            public static readonly string selectGameMode = "Would you like to play a standard game (enter - S) or against a 'last choice' AI opponent? (enter - L)";

            public static readonly string standardGameRules = "Rock beats Scissors, Scissors beats Paper, Paper beats Rock. A Tie occurs when both players select the same option";

            public static readonly string standardGameInitialInstructions = "Select option. R = Rock, P = Paper, S = Scissors";

            public static readonly string lastChoiceGameInitialInstructions = "";

            public static readonly string lastChoiceGameRules = "";

            public static readonly string playAgain = "Would you like to play another game?";
        }

        public static class Outcome
        {
            public static readonly string win = "Congratulations! You beat that AI Noob";

            public static readonly string lose = "You Lose! Now Whos the Noob?";

            public static readonly string tie = "Its a Tie! Atleast you didnt lose.";
        }

        public static class error
        {
            public static readonly string invalidInput = "Sorry, invalid character selected. Please try again";

            public static readonly string invalidOutcome = "it appears there is something wrong with the outcome logic";
        }

    }
}
