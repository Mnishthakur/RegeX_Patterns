using System;
using System.Text.RegularExpressions;

namespace RegexPattern;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        MatchCollection matches = Regex.Matches(input, @"\b[a-z]+_[a-z]+\b");

        if (matches.Count > 0)
        {
            Console.WriteLine("Sequences of lowercase letter joined by an underscore;");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("No sequences of lowercase letters");
        }
    }
}
