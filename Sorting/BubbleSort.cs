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
        for (int i = 0; i < numbersToSort.Count; i++)
        {
            for (int j = i + 1; j < numbersToSort.Count; j++)
            {
                if (numbersToSort[i] > numbersToSort[j])
                    Swap(numbersToSort, i, j);
            }
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
