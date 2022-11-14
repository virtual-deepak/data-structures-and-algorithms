namespace Sorting;

public class QuickSortHoare
{
    /// <summary>
    /// The list of integers to sort
    /// </summary>
    private List<int> numbersToSort;

    /// <summary>
    /// Constructor for Quick sort using Hoare's partitioning technique
    /// </summary>
    /// <param name="numbersToSort"></param>
    public QuickSortHoare(List<int> numbersToSort)
    {
        this.numbersToSort = numbersToSort;
    }

    /// <summary>
    /// Sorts the input numbers
    /// </summary>
    public List<int> Sort()
    {
        return PerformQuickSort(numbersToSort, 0, numbersToSort.Count - 1);
    }

    private List<int> PerformQuickSort(List<int> numbersToSort, int startIndex, int endIndex)
    {
        // Exit condition
        if (startIndex >= endIndex)
            return numbersToSort;

        // Get randomized pivot number to avoid deterministic pivot
        var random = new Random();
        // Swap pivot with index 0 number
        Swap(numbersToSort, startIndex, random.Next(startIndex, endIndex));

        // Apply Hoare's in-place partition technique
        var smallerRangeEndIndex = HoarePartition(numbersToSort, startIndex, endIndex);

        PerformQuickSort(numbersToSort, startIndex, smallerRangeEndIndex - 1);
        PerformQuickSort(numbersToSort, smallerRangeEndIndex + 1, endIndex);
        return numbersToSort;
    }

    static int HoarePartition(List<int> numbersToSort, int startIndex, int endIndex)
    {
        // Pivot is assumed to be the start index of the array
        var pivotIndex = startIndex;
        var pivotNumber = numbersToSort[pivotIndex];

        var smallerRangeIndex = startIndex + 1;
        var biggerRangeIndex = endIndex;

        while (smallerRangeIndex <= biggerRangeIndex)
        {
            if (numbersToSort[smallerRangeIndex] < pivotNumber)
                smallerRangeIndex++;
            else if (numbersToSort[biggerRangeIndex] > pivotNumber)
                biggerRangeIndex--;
            else
            {
                Swap(numbersToSort, smallerRangeIndex, biggerRangeIndex);
                smallerRangeIndex++;
                biggerRangeIndex--;
            }
        }

        Swap(numbersToSort, pivotIndex, biggerRangeIndex);

        // Here the biggerRangeIndex is pointing to pivot number
        return biggerRangeIndex;
    }

    /// <summary>
    /// Swaps the numbers in the array among the indices provided
    /// </summary>
    /// <param name="numbersToSort"></param>
    /// <param name="i"></param>
    /// <param name="j"></param>
    static void Swap(List<int> numbersToSort, int i, int j)
    {
        if (i == j)
            return;
        numbersToSort[i] = numbersToSort[i] + numbersToSort[j];
        numbersToSort[j] = numbersToSort[i] - numbersToSort[j];
        numbersToSort[i] = numbersToSort[i] - numbersToSort[j];
    }
}