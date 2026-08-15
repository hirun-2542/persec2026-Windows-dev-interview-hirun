namespace PersecInterview;

public static class Task4
{
    public static string ToRoman(int value)
    {
        var romanMap = new (int Value, string Symbol)[]
    {
        (1000, "M"),
        (900, "CM"),
        (500, "D"),
        (400, "CD"),
        (100, "C"),
        (90, "XC"),
        (50, "L"),
        (40, "XL"),
        (10, "X"),
        (9, "IX"),
        (5, "V"),
        (4, "IV"),
        (1, "I")
    };

    string result = "";

    foreach (var roman in romanMap)
    {
        while (value >= roman.Value)
        {
            value -= roman.Value;
            result += roman.Symbol;
        }
    }

    return result;
    }

    public static int FromRoman(string roman)
    {
        var romanMap = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int result = 0;
        int prevValue = 0;

        for (int i = roman.Length - 1; i >= 0; i--)
        {
            int currentValue = romanMap[roman[i]];
            result += currentValue < prevValue ? -currentValue : currentValue;
            prevValue = currentValue;
        }
         return result;
    }
}
