using System;
using System.Text.RegularExpressions;

namespace RegexPattern;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        bool isMatch = Regex.IsMatch(input, @"a(bb | bbb)?");

        if (isMatch)
        {
            Console.WriteLine("The string matches the pattern");
        }
        else
        {
            Console.WriteLine("The string does not match the pattern");
        }
    }
}
