namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Read the first string from the console
            string substringToRemove = Console.ReadLine();

            // Read the second string from the console
            string originalString = Console.ReadLine();

            // Remove all occurrences of the first string from the second string
            string resultString = originalString.Replace(substringToRemove, "");

            // Print the modified string to the console
            Console.WriteLine(resultString);

        }
    }
}
