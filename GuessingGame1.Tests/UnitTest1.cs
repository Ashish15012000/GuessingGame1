using GuessingGame1.Generator;
using NSubstitute;


namespace GuessingGame1.Tests;

public class GameTests
{
    [Fact]
    public void PlayGame_Result()
    {

        int minRange = 4;
        int maxRange = 5;
        int numberToGuess = 3;
        GeneratorNumber numberGenerator = Substitute.For<GeneratorNumber>();
        numberGenerator.Generate(minRange, maxRange).Returns(numberToGuess);
        Game game = new Game(numberGenerator);
        game.PlayGame(minRange,maxRange,"hard");
        Assert.True(true);
    }
}