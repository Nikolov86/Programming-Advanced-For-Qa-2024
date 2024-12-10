using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "30-Dec-2022";
        string expected = "Day: 30, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "7-Dec-202";
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Assert 
        string input = "07-Dec-2022, 25-Dec-2024, 31-Dec-2024";
        string expected = "Day: 07, Month: Dec, Year: 2022";
;

        //Act
        string actual = MatchDates.Match(input);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrenge 
        string input = string.Empty;
        //Act
        string actual = MatchDates.Match(input);
        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrenge
        string input = null;
        string expectedText = "Input can`t be null.";
        //Act , Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(input));
    }
}
