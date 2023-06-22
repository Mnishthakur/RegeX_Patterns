using System;
using System.Text.RegularExpressions;

namespace RegexPattern;

class Program
{
    static void Main()
    {
        string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";

        MatchCollection matches = Regex.Matches(input, "<[^>]+>");

        if (matches.Count > 0)
        {
            Console.WriteLine("HTML tags found:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("No HTML tags found.");
        }
    }
}
