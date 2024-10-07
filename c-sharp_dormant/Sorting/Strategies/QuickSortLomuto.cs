namespace Sorting;

public class QuickSortLomuto
{
    /// <summary>
    /// The list of integers to sort
    /// </summary>
    private List<int> numbersToSort;

    /// <summary>
    /// Constructor for Quick sort using Lomuto's partitioning technique
    /// </summary>
    /// <param name="numbersToSort"></param>
    public QuickSortLomuto(List<int> numbersToSort)
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

        // Apply Lomuto's in-place partition technique
        var smallerRangeEndIndex = LomutoPartition(numbersToSort, startIndex, endIndex);

        PerformQuickSort(numbersToSort, startIndex, smallerRangeEndIndex - 1);
        PerformQuickSort(numbersToSort, smallerRangeEndIndex + 1, endIndex);
        return numbersToSort;
    }

    static int LomutoPartition(List<int> numbersToSort, int startIndex, int endIndex)
    {
        // Pivot is assumed to be the start index of the array
        var pivotIndex = startIndex;
        var pivotNumber = numbersToSort[pivotIndex];

        var i = startIndex;
        for (var j = i + 1; j <= endIndex; j++)
        {
            // Number less than the pivot on the left side of pivot
            // i -> index for smaller numbers
            // j -> index for larger numbers
            if (numbersToSort[j] < pivotNumber)
            {
                i++;
                Swap(numbersToSort, i, j);
            }
        }
        Swap(numbersToSort, pivotIndex, i);

        // Here the 'i' is pointing to pivot number
        return i;
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