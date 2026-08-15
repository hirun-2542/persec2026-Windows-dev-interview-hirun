using PersecInterview;

if (args.Length != 1 || !int.TryParse(args[0], out var task) || task is < 1 or > 6)
{
    Console.WriteLine("Usage: dotnet run -- <1-6>");
    return;
}

try
{
    switch (task)
    {
        case 1:
            Console.WriteLine(Task1.AreBracketsBalanced("([{}])"));
            break;
        case 2:
            Console.WriteLine(string.Join(", ", Task2.SortCodes(["TH19", "SG20", "TH2"])));
            break;
        case 3:
            Console.WriteLine(string.Join(", ", Task3.Autocomplete(
                "th", ["Worthy", "Mother", "Think"], 3)));
            break;
        case 4:
            Console.WriteLine(Task4.ToRoman(1989));
            Console.WriteLine(Task4.FromRoman("MCMLXXXIX"));
            break;
        case 5:
            Console.WriteLine(Task5.SortDigitsDescending(3008));
            break;
        case 6:
            Console.WriteLine(string.Join(", ", Task6.Tribonacci([1, 3, 5], 5)));
            break;
    }
}
catch (NotImplementedException)
{
    Console.WriteLine($"Task {task} is not implemented yet.");
}
