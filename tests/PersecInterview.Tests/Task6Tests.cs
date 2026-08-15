using PersecInterview;
using Xunit;

public class Task6Tests
{
    [Fact]
    public void MatchesExamples()
    {
        Assert.Equal([1, 3, 5, 9, 17], Task6.Tribonacci([1, 3, 5], 5));
        Assert.Equal([2, 2, 2], Task6.Tribonacci([2, 2, 2], 3));
        Assert.Equal([10, 10, 10, 30], Task6.Tribonacci([10, 10, 10], 4));
        Assert.Equal([1, 1, 1, 3, 5, 9, 17], Task6.Tribonacci([1, 1, 1], 7));
    }

    [Fact]
    public void ReturnsOnlyRequestedItems()
    {
        Assert.Empty(Task6.Tribonacci([], 0));
        Assert.Equal([5], Task6.Tribonacci([5], 1));
        Assert.Equal([3, 4], Task6.Tribonacci([3, 4], 2));
        Assert.Equal([1, 3], Task6.Tribonacci([1, 3, 5], 2));
    }

    [Fact]
    public void RejectsMoreThanThreeSeedValues() =>
        Assert.Throws<ArgumentException>(() => Task6.Tribonacci([1, 2, 3, 4], 4));
}
