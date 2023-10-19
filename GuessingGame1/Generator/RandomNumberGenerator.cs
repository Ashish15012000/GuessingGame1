namespace GuessingGame1.Generator;
public sealed class RandomNumberGenerator : GeneratorNumber
{
    public int Generate(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}
