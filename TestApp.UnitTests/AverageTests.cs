using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] numbers = { 1, 3, 4, 4 };

        // Act
        double result = Average.CalculateAverage(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] numbers = { -10, -20, -30 };

        // Act
        double result = Average.CalculateAverage(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(-20));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] numbers = { 3, -1, 4 };

        // Act
        double result = Average.CalculateAverage(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}
