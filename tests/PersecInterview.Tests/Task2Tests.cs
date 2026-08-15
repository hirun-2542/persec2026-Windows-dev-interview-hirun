using PersecInterview;
using Xunit;

public class Task2Tests
{
    [Fact]
    public void MatchesExamples()
    {
        Assert.Equal(["SG20", "TH2", "TH19"], Task2.SortCodes(["TH19", "SG20", "TH2"]));
        Assert.Equal(
            ["TH1", "TH3Netflix", "TH7", "TH10"],
            Task2.SortCodes(["TH10", "TH3Netflix", "TH1", "TH7"]));
    }

    [Fact]
    public void SortsPrefixBeforeTheFirstNumber()
    {
        Assert.Equal(
            ["SG20", "US2", "US10"],
            Task2.SortCodes(["US10", "SG20", "US2"]));
    }
}
