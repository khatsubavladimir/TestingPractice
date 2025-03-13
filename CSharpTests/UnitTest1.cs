using Xunit;

public class UnitTest1
{
    [Fact]
    public void Guess_Lower_ReturnsMessage()
    {
        var game = new GuessingGame(50);
        var result = game.Guess(30);
        Assert.Equal("Загадане число бiльше.", result);
    }

    [Fact]
    public void Guess_Higher_ReturnsMessage()
    {
        var game = new GuessingGame(50);
        var result = game.Guess(70);
        Assert.Equal("Загадане число менше.", result);
    }

    [Fact]
    public void Guess_Correct_ReturnsWin()
    {
        var game = new GuessingGame(50);
        var result = game.Guess(50);
        Assert.Contains("Ви вгадали число", result);
    }

    [Fact]
    public void Guess_NumberOfAttempts()
    {
        var game = new GuessingGame(50);
        game.Guess(30);
        game.Guess(70);
        game.Guess(50);
        Assert.Equal(3, game.Attempts);
    }

    [Fact]
    public void FirstTryWin_AttemptsShouldBeOne()
    {
        var game = new GuessingGame(50);
        game.Guess(50);
        Assert.Equal(1, game.Attempts);
    }
}
