using System;
using System.Text.RegularExpressions;

namespace RegexPattern;

class Program
{
    static void Main()
    {
        string pattern = "fox(es)?";
        string input = "foxes are omnivorous mammals belonging to several genera of the family Canidae fox.";

        MatchCollection matches = Regex.Matches(input, pattern);
        int count = matches.Count;

        Console.WriteLine("There are {0} occurrences.", count);
    }
}
