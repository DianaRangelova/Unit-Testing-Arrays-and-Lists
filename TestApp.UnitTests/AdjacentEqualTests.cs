using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> numbers = new List<int> {1, 20, 30, 4, 5};

        // Act
        string result = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("1 20 30 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 2, 5 };

        // Act
        string result = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("1 4 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> numbers = new List<int> { 2, 2, 2, 2 };

        // Act
        string result = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 1, 4, 8 };

        // Act
        string result = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("2 4 8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 32, 13, 24, 24 };

        // Act
        string result = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("32 13 48"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 17, 190, 10, 10, 13, 18 };

        // Act
        string result = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("17 190 20 13 18"));
    }
}
