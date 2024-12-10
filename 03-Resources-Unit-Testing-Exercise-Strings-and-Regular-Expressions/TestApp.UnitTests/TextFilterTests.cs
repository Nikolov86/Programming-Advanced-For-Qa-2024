using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] badWords = new string[] { "bad" };
        string input = "This is a simple text with no banned words";

        // Act
        string result = TextFilter.Filter(badWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] badWords = new string[] { "bad" };
        string input = "This is a simple text with bad banned words";
        string expected = "This is a simple text with *** banned words";

        // Act
        string result = TextFilter.Filter(badWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] badWords = Array.Empty<string>();
        string input = "This is a simple text with no banned words";

        // Act
        string result = TextFilter.Filter(badWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] badWords = new string[] { "bad", " " };
        string input = "This is a simple text with no banned words";
        string expected = "This*is*a*simple*text*with*no*banned*words";

        // Act
        string result = TextFilter.Filter(badWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
