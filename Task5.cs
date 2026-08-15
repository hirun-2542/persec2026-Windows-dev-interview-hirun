namespace PersecInterview;

public static class Task5
{
    public static int SortDigitsDescending(int value)
    {
        var digits = value.ToString().ToCharArray();
        Array.Sort(digits);
        Array.Reverse(digits);
        return int.Parse(new string(digits));
    }
}
