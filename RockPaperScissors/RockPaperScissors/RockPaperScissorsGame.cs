using RockPaperScissors;

GameController gameController = new GameController();

Validation validation = new Validation();

Console.WriteLine(TextDisplay.instruction.welcome);
Console.WriteLine(TextDisplay.instruction.selectGameMode);

char userInput = Convert.ToChar(Console.ReadLine());

while (validation.ValidateGameTypeResponse(userInput) == false)
{
    Console.WriteLine(TextDisplay.error.invalidInput);
    userInput = Convert.ToChar(Console.ReadLine());
}
    if (char.ToLower(userInput) == 's')
    {
        StandardGameController standardGameController = new StandardGameController();
    }
    else if(char.ToLower(userInput) == 'l')
    {
        LastChoiceGameController lastChoiceGameController = new LastChoiceGameController();
    }

