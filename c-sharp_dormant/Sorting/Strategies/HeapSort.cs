namespace Sorting;

public class HeapSort
{
    /// <summary>
    /// The list of integers to sort
    /// </summary>
    private List<int> numbersToSort;

    /// <summary>
    /// Constructor for Heap sort
    /// </summary>
    /// <param name="numbersToSort"></param>
    public HeapSort(List<int> numbersToSort)
    {
        this.numbersToSort = numbersToSort;
    }

    /// <summary>
    /// Sorts the input numbers
    /// </summary>
    public List<int> Sort()
    {
        // Build MaxHeap
        for (int index = (numbersToSort.Count - 1) / 2; index >= 0; index--)
            Heapify(numbersToSort, numbersToSort.Count, index);

        for (int index = numbersToSort.Count - 1; index > 0; index--)
        {
            // Root has the largest element at index 0 for MaxHeap. 
            // Swap with the last element (last leaf node)
            Swap(numbersToSort, 0, index);

            // Heapify again to set it as MaxHeap
            Heapify(numbersToSort, index, 0);
        }

        return numbersToSort;
    }

    /// <summary>
    /// Heapify the array to build max heap under the root given by parentIndex
    /// </summary>
    /// <param name="numbersToSort"></param>
    /// <param name="endIndex"></param>
    /// <param name="parentIndex"></param>
    public void Heapify(List<int> numbersToSort, int endIndex, int parentIndex)
    {
        var largestIndex = parentIndex;
        var leftChildIndex = 2 * parentIndex + 1;
        var rightChildIndex = 2 * parentIndex + 2;

        if ((leftChildIndex < endIndex)
            && numbersToSort[leftChildIndex] > numbersToSort[largestIndex])
            largestIndex = leftChildIndex;

        if ((rightChildIndex < endIndex)
            && numbersToSort[rightChildIndex] > numbersToSort[largestIndex])
            largestIndex = rightChildIndex;

        if (largestIndex != parentIndex)
        {
            Swap(numbersToSort, parentIndex, largestIndex);
            Heapify(numbersToSort, endIndex, largestIndex);
        }
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
