using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        // Arrange
        string[] input = { "abc" };
        string expected = "abcabcabc";

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        // Arrange
        string[] input = { "abc" ,"he", "abcd"};
        string expected = "abcabcabcheheabcdabcdabcdabcd";

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
