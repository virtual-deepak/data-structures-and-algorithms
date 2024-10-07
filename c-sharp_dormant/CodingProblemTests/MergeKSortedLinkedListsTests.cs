namespace CodingProblemTests;

using CodingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

[TestClass]
public class MergeKSortedLinkedListsTests
{
    [TestMethod]
    public void AssertBestCaseScenario()
    {
        // Arrange
        // TODO: Prepare an input of array if LinkedListNode 
        List<LinkedListNode> input = new();
        // Act
        var sut = MergeKSortedLinkedLists.Execute(input);

        // Assert
        // TODO: Assert the output LinkedListNode if all appear in sorted order
    }
}