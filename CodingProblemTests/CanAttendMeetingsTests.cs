using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;
namespace CodingProblemsTests;

[TestClass]
public class CanAttendMeetingsTests
{
    [TestMethod]
    public void PossibleToAttendAllMeetings()
    {
        // Arrange
        List<List<int>> intervals = new List<List<int>> 
        {
            new List<int> { 1, 5 },
            new List<int> { 5, 8},
            new List<int> { 8, 10}
        };

        // Act
        var sut = CanAttendMeetings.Execute(intervals);

        // Assert
        Assert.AreEqual(sut, true);
    }

    [TestMethod]
    public void NotPossibleToAttendAllMeetings()
    {
        // Arrange
        List<List<int>> intervals = new List<List<int>> 
        {
            new List<int> { 1, 5 },
            new List<int> { 4, 10}
        };

        // Act
        var sut = CanAttendMeetings.Execute(intervals);

        // Assert
        Assert.AreEqual(sut, false);
    }
}