using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy dog";

        // Act

        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "quick";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The brown fox jumps over the lazy dog";

        // Act

        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "lazy";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps over the dog";

        // Act

        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "quick";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The brown fox jumps over the lazy dog";

        // Act

        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert

        Assert.That(result, Is.EqualTo(expected));
    }
}
