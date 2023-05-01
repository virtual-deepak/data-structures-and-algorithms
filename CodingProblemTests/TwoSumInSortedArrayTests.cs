namespace CodingProblemTests;

using CodingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

[TestClass]
public class TwoSumInSortedArrayTests
{
    [TestMethod]
    public void AssertBestCaseScenario()
    {
        // Arrange
        List<int> inputNumbers = new List<int> { 1, 2, 4, 5, 10 };
        int target = 7;
        // Act 
        var sut = TwoSumInSortedArrays.Execute(inputNumbers, target);
        // Assert
        CollectionAssert.Equals(sut, new List<int> { 1, 3 });
    }
}