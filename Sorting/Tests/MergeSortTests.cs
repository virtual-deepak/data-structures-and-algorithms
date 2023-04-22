using Sorting;

namespace SortingTests;

[TestClass]
public class MergeSortTests
{
    /// <summary>
    /// Test sorting on already sorted list 
    /// </summary>
    [TestMethod]
    public void MergeSortOnAlreadySortedList()
    {
        var mergeSort = new MergeSort(new List<int>() { 2, 3, 5, 6, 8, 10 });
        var sortedOutput = mergeSort.Sort();
        // CollectionAssert checks the actual values
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 6, 8, 10 }, sortedOutput);
    }

    /// <summary>
    /// Test sorting on reverse sorted list 
    /// </summary>
    [TestMethod]
    public void MergeSortOnReverseSortedList()
    {
        var mergeSort = new MergeSort(new List<int>() { 10, 8, 6, 5, 3, 2 });
        var sortedOutput = mergeSort.Sort();
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 6, 8, 10 }, sortedOutput);
    }

    /// <summary>
    /// Test sorting on a randmon list 
    /// </summary>
    [TestMethod]
    public void MergeSortOnRandomList()
    {
        var mergeSort = new MergeSort(new List<int> { 6, 5, 3, 8, 2, 10 });
        var sortedOutput = mergeSort.Sort();
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 6, 8, 10 }, sortedOutput);
    }
}
