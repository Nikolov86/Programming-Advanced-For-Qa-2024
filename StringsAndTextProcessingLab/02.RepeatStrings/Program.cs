namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Read the input array of strings
            string[] strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Initialize an empty result string
            string result = string.Empty;

            // Iterate over each string in the array
            foreach (string str in strings)
            {
                int repeatCount = str.Length;

                // Repeat the string N times and append to the result
                for (int i = 0; i < repeatCount; i++)
                {
                    result += str;
                }
            }

            // Print the concatenated result
            Console.WriteLine(result);

        }
    }
}
