using System;
using System.Linq;

namespace PersecInterview;

public static class Task3
{
        public static string[] Autocomplete(string search, string[] items, int maxResult)
        {
            var results = items
                .Where(item => item.Contains(search, StringComparison.OrdinalIgnoreCase)) // Ignore case sensitive when searching
                .OrderBy(item => item.IndexOf(search, StringComparison.OrdinalIgnoreCase)) // Sort the results in alphabet order
                .Take(maxResult) // Limit the number first of results to maxResult
                .ToArray();

            return results;
        }
}
