using System;
using System.Text.RegularExpressions;

namespace RegexPattern;

class Program
{
    static void Main()
    {
        string input = "image.jpg text.png document.docx code.cs backup.zip";

        MatchCollection matches = Regex.Matches(input, @"\b\w+\.(jpg|jpeg|png|gif|bmp)\b");

        if (matches.Count > 0)
        {
            Console.WriteLine("Valid image file names found:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("No valid image file names found.");
        }
    }
}
