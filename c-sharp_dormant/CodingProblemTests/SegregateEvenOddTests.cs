namespace CodingProblemTests;

using CodingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

[TestClass]
public class SegregateEvenOddTests
{
    [TestMethod]
    public void AssertBestCaseScenario()
    {
        // Arrange
        List<int> inputNumbers = new List<int> { 1, 2, 3, 4 };
        // Act 
        var sut = SegregateEvenOdd.Execute(inputNumbers);
        // Assert
        CollectionAssert.Equals(sut, new List<int> { 4, 2, 3, 1 });
    }
}