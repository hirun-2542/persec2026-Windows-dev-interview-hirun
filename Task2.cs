using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PersecInterview;

public static class Task2
{
    public static string[] SortCodes(string[] items)
    {
        items = items.OrderBy(item => Regex.Match(item, @"^[A-Za-z]+").Value) //Sort items by the alphabet at the beginning of each item
        .ThenBy(item =>
        {
           var match = Regex.Match(item, @"\d+");
           return match.Success ? int.Parse(match.Value) : 0;
        })
        .ToArray();
        return items;
    }
}
