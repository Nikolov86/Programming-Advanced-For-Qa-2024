using NUnit.Framework;

using System;
using System.Linq;
using System.Text;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        string expected = string.Empty;

        // Act
        //string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.AreEqual(expected, input);
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string input = "abc";
        string expected = "abc";

        // Act
        //string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.AreEqual(expected, input);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrenge
        string[] input = new string[] { "abc", "def" ,"niki"};
        string expected = "nikidefabc";

        //Act 
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        //Arrenge
        string[] input = null;
        string expected = string.Empty;

        //Act 
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        //Assert
        Assert.AreEqual (expected, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        //Arrenge
        string[] input = { "abc", " " };
        string expected = " abc";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        //Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[1000];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = new string('a', i + 1); // Generate strings of increasing lengths
        }

        StringBuilder expectedBuilder = new StringBuilder();
        foreach (string str in input)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            expectedBuilder.Append(new string(charArray));
        }
        string expected = expectedBuilder.ToString();

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
