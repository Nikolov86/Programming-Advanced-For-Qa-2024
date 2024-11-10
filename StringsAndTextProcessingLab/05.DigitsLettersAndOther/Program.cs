namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string digits = "";
            string letters = "";
            string others = "";

            foreach (char singleString in input)
            {
                if (char.IsDigit(singleString))
                {
                    digits += singleString;
                }
                else if (char.IsLetter(singleString))
                {
                    letters += singleString;
                }
                else
                {
                    others += singleString;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);

        }
    }
}
