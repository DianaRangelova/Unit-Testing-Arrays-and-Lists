using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> numbers = new List<int> { 15 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> numbers = new List<int> { 10, 20, 30, 40 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        List<int> expected = new List<int> { 50, 50 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        List<int> expected = new List<int> { 60, 60, 30 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> numbers = new List<int> { 22, 35, 44, 60, 70, 50, 100, 20 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        List<int> expected = new List<int> { 42, 135, 94, 130 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> numbers = new List<int> { 3, 2, 10, 15, 6, 13, 27 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        List<int> expected = new List<int> { 30, 15, 16, 15 };
        CollectionAssert.AreEqual(expected, result);
    }
}
