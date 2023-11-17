using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Choose the Options: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    MatchPattern mp = new MatchPattern();
                    string InputToValidate = "aabbb";
                    bool rs = mp.validateString(InputToValidate);
                    if (rs)
                        Console.WriteLine("Valide");
                    else
                        Console.WriteLine("Invalid");
                    break;
                    case 2:
                    UnderscoreLowerCase cs = new UnderscoreLowerCase();
                    string InputToValidate1 = "write_a_code_in_c_sharp";
                    bool rs1 = cs.validateString(InputToValidate1);
                    if (rs1)
                        Console.WriteLine("Valide");
                    else
                        Console.WriteLine("Invalid");
                    break;
                    case 3:
                    string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
                    string pattern = @"<[^>]+>";
                    MatchCollection matches = Regex.Matches(input, pattern);
                    Console.WriteLine("HTML Tags found:");
                    foreach (Match match in matches)
                    {
                        Console.WriteLine(match.Value);
                    }
                    break;
                case 4:
                    string pattern1 = @"fox(es)?"; 
                    string input1 = @"Foxes are omnivorous mammals belonging to several genera of the family Canidae fox."; // Input string
                    MatchCollection matches1 = Regex.Matches(input1, pattern1);
                    Console.WriteLine($"There are {matches1.Count} occurrences of the pattern '{pattern1}' in the string.");
                    break;
                    case 5:
                    string[] fileNames = {
                                          "image.jpg",
                                          "file.png",
                                          "document.txt",
                                          "picture.jpeg",
                                          "data.gif",
                                          "photo.bmp",
                                           "script.py"
        };
                    string pattern2 = @"^.+\.(jpg|jpeg|png|gif|bmp)$";
                    Console.WriteLine("Valid image file names:");
                    foreach (string fileName in fileNames)
                    {
                        if (Regex.IsMatch(fileName, pattern2, RegexOptions.IgnoreCase))
                        {
                            Console.WriteLine(fileName);
                        }
                    }
                    break;
                    case 6:
                    string[] websites = {
                                         "https://www.example.com",
                                         "http://sub.example.org",
                                         "ftp://another-example.net",
                                          "invalidwebsite.com",
                                          "http:/invalid-format.org"
        };
                    string pattern3 = @"^(https?|ftp):\/\/[^\s\/$.?#].[^\s]*$";
                    Console.WriteLine("Valid website addresses:");
                    foreach (string website in websites)
                    {
                        if (Regex.IsMatch(website, pattern3, RegexOptions.IgnoreCase))
                        {
                            Console.WriteLine(website);
                        }
                    }
                    break;
                 default: Console.WriteLine("options don't matched");
                    break;
            }
            Console.ReadLine();
        }
    }
}
