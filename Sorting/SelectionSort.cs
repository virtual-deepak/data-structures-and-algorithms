public class SelectionSort
{
    private List<int> numbersToSort;

    public SelectionSort(List<int> numbersToSort)
    {
        this.numbersToSort = numbersToSort;
    }

    /// <summary>
    /// Sorts the input numbers
    /// </summary>
    public List<int> Sort()
    {
        for (int index = 0; index < numbersToSort.Count; index++)
        {
            var minNumberIndex = index;
            for (int innerIndex = index + 1; innerIndex < numbersToSort.Count; innerIndex++)
            {
                if (numbersToSort[innerIndex] < numbersToSort[minNumberIndex])
                    minNumberIndex = innerIndex;
            }
            Swap(numbersToSort, index, minNumberIndex);
        }
        return numbersToSort;
    }

    /// <summary>
    /// Swaps the numbers in the array among the indices provided
    /// </summary>
    /// <param name="arrInput"></param>
    /// <param name="index"></param>
    /// <param name="minNumberIndex"></param>
    static void Swap(List<int> numbersToSort, int index, int minNumberIndex)
    {
        if (index == minNumberIndex)
            return;
        numbersToSort[index] = numbersToSort[index] + numbersToSort[minNumberIndex];
        numbersToSort[minNumberIndex] = numbersToSort[index] - numbersToSort[minNumberIndex];
        numbersToSort[index] = numbersToSort[index] - numbersToSort[minNumberIndex];
    }
}