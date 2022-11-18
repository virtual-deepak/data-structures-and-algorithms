namespace Sorting;

public class BubbleSort
{
    /// <summary>
    /// The list of integers to sort
    /// </summary>
    private List<int> numbersToSort;

    /// <summary>
    /// Constructor for BubbleSort
    /// </summary>
    /// <param name="numbersToSort"></param>
    public BubbleSort(List<int> numbersToSort)
    {
        this.numbersToSort = numbersToSort;
    }

    /// <summary>
    /// Sorts the input numbers
    /// </summary>
    public List<int> Sort()
    {
        // is_swapped for optimization of bubble sort for achieving best case
        // of O(n)
        for (int i = 0; i < numbersToSort.Count; i++)
        {
            bool is_swapped = false;
            for (int j = 0; j < numbersToSort.Count - i - 1; j++)
            {
                if (numbersToSort[j] > numbersToSort[j + 1])
                {
                    Swap(numbersToSort, j, j + 1);
                    is_swapped = true;
                }
            }
            if (!is_swapped)
                break;
        }
        return numbersToSort;
    }

    /// <summary>
    /// Swaps the numbers in the array among the indices provided
    /// </summary>
    /// <param name="arrInput"></param>
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
