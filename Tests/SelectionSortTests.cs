namespace SortingTests;

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

/// <summary>
/// Tests for selection sort
/// </summary>
[TestClass]
public class SelectionSortTests
{
    /// <summary>
    /// Test sorting on already sorted list 
    /// </summary>
    [TestMethod]
    public void SelectionSortOnAlreadySortedList()
    {
        var selectionSort = new SelectionSort(new List<int>() { 2, 3, 5, 6, 8, 10 });
        var sortedOutput = selectionSort.Sort();
        // CollectionAssert checks the actual values
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 6, 8, 10 }, sortedOutput);
    }

    /// <summary>
    /// Test sorting on reverse sorted list 
    /// </summary>
    [TestMethod]
    public void SelectionSortOnReverseSortedList()
    {
        var selectionSort = new SelectionSort(new List<int>() { 10, 8, 6, 5, 3, 2 });
        var sortedOutput = selectionSort.Sort();
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 6, 8, 10 }, sortedOutput);
    }

    /// <summary>
    /// Test sorting on a randmon list 
    /// </summary>
    [TestMethod]
    public void SelectionSortOnRandomList()
    {
        var selectionSort = new SelectionSort(new List<int> { 6, 5, 3, 8, 2, 10 });
        var sortedOutput = selectionSort.Sort();
        CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 6, 8, 10 }, sortedOutput);
    }
}