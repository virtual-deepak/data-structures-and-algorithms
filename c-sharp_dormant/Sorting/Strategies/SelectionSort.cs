namespace Sorting;
/// <summary>
/// The SelectionSort class
/// </summary>
public class SelectionSort
{
    /// <summary>
    /// The list of integers to sort
    /// </summary>
    private List<int> numbersToSort;

    /// <summary>
    /// Constructor for SelectionSort
    /// </summary>
    /// <param name="numbersToSort"></param>
    public SelectionSort(List<int> numbersToSort)
    {
        this.numbersToSort = numbersToSort;
    }

    /// <summary>
    /// Sorts the input numbers
    /// </summary>
    public List<int> Sort()
    {
        for (int i = 0; i < numbersToSort.Count; i++)
        {
            var minNumberIndex = i;
            for (int j = i + 1; j < numbersToSort.Count; j++)
            {
                if (numbersToSort[j] < numbersToSort[minNumberIndex])
                    minNumberIndex = j;
            }
            // Select the smallest number and move it ahead of the array
            Swap(numbersToSort, i, minNumberIndex);
        }
        return numbersToSort;
    }

    /// <summary>
    /// Swaps the numbers in the array among the indices provided
    /// </summary>
    /// <param name="arrInput"></param>
    /// <param name="i"></param>
    /// <param name="minNumberIndex"></param>
    static void Swap(List<int> numbersToSort, int i, int minNumberIndex)
    {
        if (i == minNumberIndex)
            return;
        numbersToSort[i] = numbersToSort[i] + numbersToSort[minNumberIndex];
        numbersToSort[minNumberIndex] = numbersToSort[i] - numbersToSort[minNumberIndex];
        numbersToSort[i] = numbersToSort[i] - numbersToSort[minNumberIndex];
    }
}