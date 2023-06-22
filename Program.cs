using System;
using System.Text.RegularExpressions;

namespace RegexPattern;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a website address: ");
        string input = Console.ReadLine();

        bool isValid = Regex.IsMatch(input, @"^(https?://)?([\w-]+(\.[\w-]+)+)(:\d+)?(/.*)?$");

        if (isValid)
        {
            Console.WriteLine("The website address is valid.");
        }
        else
        {
            Console.WriteLine("The website address is invalid.");
        }
    }
}
