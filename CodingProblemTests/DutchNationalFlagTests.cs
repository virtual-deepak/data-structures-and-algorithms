using CodingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblemTests;

[TestClass]
public class DutchNationalFlagTests
{
    [TestMethod]
    public void AssertBestCase()
    {
        // Arrange
        var balls = new List<char> { 'G', 'R', 'G', 'R', 'G', 'R', 'R', 'B', 'R', 'G', 'B' };
        // Act
        var sut = DutchNationalFlag.Execute(balls);

        // Assert
        CollectionAssert.Equals(sut, new List<char> { 'R', 'R', 'R', 'R', 'R', 'G', 'G', 'G', 'G', 'B', 'B' });
    } 
}