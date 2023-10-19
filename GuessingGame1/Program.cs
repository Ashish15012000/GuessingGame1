using GuessingGame1.Generator;
class PlayAndWin
{


    public static void Main(string[] args)
    { 
        try
        {
            GeneratorNumber numberGenerator = new RandomNumberGenerator();

            Game game = new Game(numberGenerator);

            Console.WriteLine("Enter the amount of money to bet:");
            int moneyToBet = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number you want to guess:");
            int numberToGuess = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the difficulty (Easy/Medium/Hard):");
            string difficulty = Console.ReadLine();

            string result = game.PlayGame(moneyToBet, numberToGuess, difficulty);
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
}


