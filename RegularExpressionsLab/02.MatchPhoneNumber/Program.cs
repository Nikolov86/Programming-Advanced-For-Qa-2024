using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = @"\+359([ |-])2\1\d{3}\1\d{4}\b";

            MatchCollection matches = Regex.Matches(input, patern);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
