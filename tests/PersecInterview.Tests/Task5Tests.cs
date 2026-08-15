using PersecInterview;
using Xunit;

public class Task5Tests
{
    [Theory]
    [InlineData(3008, 8300)]
    [InlineData(1989, 9981)]
    [InlineData(2679, 9762)]
    [InlineData(9163, 9631)]
    [InlineData(7, 7)]
    [InlineData(1002, 2100)]
    [InlineData(111, 111)]
    [InlineData(1010, 1100)]
    [InlineData(987654321, 987654321)]
    public void MatchesExamples(int input, int expected) =>
        Assert.Equal(expected, Task5.SortDigitsDescending(input));
}
