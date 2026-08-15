namespace PersecInterview;

public static class Task6
{
    public static int[] Tribonacci(int[] seed, int count)
    {
        if (seed.Length > 3)
        {
            throw new ArgumentException("Seed array must have a length of 3 or less.");
        }

        int[] result = new int[count];
        Array.Copy(seed, result, Math.Min(seed.Length, count));

        for (int i = 3; i < count; i++)
        {
            int sum = 0;

            for (int j = 1; j <= 3; j++)
            {
                sum += result[i - j];
            }

            result[i] = sum;
        }

        return result;
    }
}
