
while (true)
{
    string input = Console.ReadLine();

    // Exit the loop if the input is "end"
    if (input == "end")
    {
        break;
    }

    // Reverse the string
    string reversed = ReverseString(input);

    // Print the output in the desired format
    Console.WriteLine($"{input} = {reversed}");
}

    static string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
