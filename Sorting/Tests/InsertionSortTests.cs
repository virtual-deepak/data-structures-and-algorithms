using Sorting;

namespace SortingTests;

[TestClass]
public class InsertionSortTests
{
    /// <summary>
    /// Test sorting on already sorted list 
    /// </summary>
    [TestMethod]
    public void InsertionSortOnAlreadySortedList()
    {
        var insertionSort = new InsertionSort(new List<int>() { 2, 3, 5, 6, 8, 10 });
        var sortedOutput = insertionSort.Sort();
        // CollectionAssert checks the actual values
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 6, 8, 10 }, sortedOutput);
    }

    /// <summary>
    /// Test sorting on reverse sorted list 
    /// </summary>
    [TestMethod]
    public void InsertionSortOnReverseSortedList()
    {
        var insertionSort = new InsertionSort(new List<int>() { 10, 8, 6, 5, 3, 2 });
        var sortedOutput = insertionSort.Sort();
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 6, 8, 10 }, sortedOutput);
    }

    /// <summary>
    /// Test sorting on a randmon list 
    /// </summary>
    [TestMethod]
    public void InsertionSortOnRandomList()
    {
        var insertionSort = new InsertionSort(new List<int> { 6, 5, 3, 8, 2, 10 });
        var sortedOutput = insertionSort.Sort();
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 6, 8, 10 }, sortedOutput);
    }
}
