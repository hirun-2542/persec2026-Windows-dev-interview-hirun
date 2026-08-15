using PersecInterview;
using Xunit;

public class Task3Tests
{
    [Fact]
    public void MatchesExample()
    {
        Assert.Equal(
            ["Think", "Mother"],
            Task3.Autocomplete(
                "th", ["Mother", "Think", "Worthy", "Apple", "Android"], 2));
    }

    [Fact]
    public void IgnoresCaseAndExcludesNonMatches()
    {
        Assert.Equal(
            ["ANDROID", "candy"],
            Task3.Autocomplete("and", ["candy", "ANDROID", "Apple"], 10));
    }

    [Fact]
    public void SortsMatchesByTheirPositionInTheWord()
    {
        Assert.Equal(
            ["Think", "Mother", "Worthy"],
            Task3.Autocomplete("th", ["Worthy", "Mother", "Think"], 3));
    }

    [Fact]
    public void ReturnsEmptyWhenThereIsNoMatch() =>
        Assert.Empty(Task3.Autocomplete("zz", ["Apple", "Android"], 2));
}
