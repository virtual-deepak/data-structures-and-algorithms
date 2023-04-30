namespace CodingProblemTests;

using CodingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

[TestClass]
public class MergeTwoSortedArraysTests
{
    [TestMethod]
    public void AssertBestCaseScenario()
    {
        // Arrange
        var first = new List<int> { 1, 3 };
        var second = new List<int> { 2, 4, 0, 0};
        // Act
        var sut = MergeTwoSortedArrays.Execute(first, second);

        // Assert
        CollectionAssert.Equals(sut, new List<int> { 1, 2, 3, 4});
    }
}