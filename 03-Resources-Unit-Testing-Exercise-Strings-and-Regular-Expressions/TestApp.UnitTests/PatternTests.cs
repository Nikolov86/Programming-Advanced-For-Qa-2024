using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("Hi", 1 ,"hI")]
    [TestCase("abc", 3 ,"aBcaBcaBc")]
    [TestCase("Niki", 5 , "nIkInIkInIkInIkInIkI")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("")]
    [TestCase(null)]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException(string input)
    {
        // Arrenge ,
        int repetitionFactor = 3;

        //
        // Act and Assert

        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        //Arrenge 
        string input = string.Empty;
        int repetitionFactor = -3;

        // Act , Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        //Arrenge 
        string input = string.Empty;
        int repetitionFactor = 0;

        // Act , Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }
}
