using PersecInterview;
using Xunit;

public class Task4Tests
{
    [Theory]
    [InlineData(1989, "MCMLXXXIX")]
    [InlineData(2000, "MM")]
    [InlineData(68, "LXVIII")]
    [InlineData(109, "CIX")]
    [InlineData(4, "IV")]
    [InlineData(9, "IX")]
    [InlineData(900, "CM")]
    [InlineData(1, "I")]
    [InlineData(44, "XLIV")]
    [InlineData(944, "CMXLIV")]
    [InlineData(3999, "MMMCMXCIX")]
    public void ConvertsBothDirections(int number, string roman)
    {
        Assert.Equal(roman, Task4.ToRoman(number));
        Assert.Equal(number, Task4.FromRoman(roman));
    }
}
