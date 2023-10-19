namespace GuessingGame1.Generator;
using Microsoft.VisualBasic;

public sealed class Game
{
     private readonly GeneratorNumber _numberGenerator;

        public Game(GeneratorNumber numberGenerator)
        {
            _numberGenerator = numberGenerator;
        }

    private Random random = new Random();
    public string PlayGame(int moneyToBet, int numberToGuess, string difficulty)
    {
         

        int minRange, maxRange, multiplier;
        switch (difficulty.ToLower())
        {
            case "easy":
                minRange = 1;
                maxRange = 5;
                multiplier = 5;
                break;
            case "medium":
                minRange = 1;
                maxRange = 10;
                multiplier = 10;
                break;
            case "hard":
                minRange = 1;
                maxRange = 20;
                multiplier = 20;
                break;
            default:
                return "Invalid difficulty. Please choose Easy, Medium, or Hard.";
        }
        if (numberToGuess < minRange || numberToGuess > maxRange)
        {
            return $"Invalid guess. Please choose a number between {minRange} and {maxRange}.";
        }
        int randomNumber = random.Next(minRange, maxRange + 1);
        if (numberToGuess == randomNumber)
        {
            int winnings = moneyToBet * multiplier + moneyToBet;
            return $"Congratulations! You won ${winnings}!";
        }
        else
        {
            return $"Sorry, you lost.{randomNumber}";
        }
    }

}
