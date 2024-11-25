using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string patern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            //Regex regex = new Regex(patern);

            MatchCollection matches = Regex.Matches(input, patern);

            foreach (Match match in matches)
            {
                Console.Write($"{match} ");
            }

        }
    }
}
