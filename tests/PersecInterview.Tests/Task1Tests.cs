using PersecInterview;
using Xunit;

public class Task1Tests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("([]]", false)]
    [InlineData("([{}])", true)]
    [InlineData("([[{}]]]", false)]
    [InlineData(")", false)]
    [InlineData("(]}])", false)]
    [InlineData("([)]", false)]
    [InlineData("{", false)]
    [InlineData("{}[]()", true)]
    [InlineData("{[()]}", true)]
    [InlineData("[(])", false)]
    [InlineData("(()", false)]

    public void MatchesExamples(string input, bool expected) =>
        Assert.Equal(expected, Task1.AreBracketsBalanced(input));
}
