using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> numbers = new List<int> { 66 };

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(66));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int> { 31, 34, 55, 51213, 33 };

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(51213));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int> { -124, -15, -1, -33, -654 };

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int> { -10, 5, 13, 66, 100 };

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(100));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int> { -10, 5, 100, 13, 66, 100 };

        // Act
        int result = MaxNumber.FindMax(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(100));
    }
}
