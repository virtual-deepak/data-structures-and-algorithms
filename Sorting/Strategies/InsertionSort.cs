namespace Sorting;

public class InsertionSort
{
    /// <summary>
    /// The list of integers to sort
    /// </summary>
    private List<int> numbersToSort;

    /// <summary>
    /// Constructor for InsertionSort
    /// </summary>
    /// <param name="numbersToSort"></param>
    public InsertionSort(List<int> numbersToSort)
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
            var temp = numbersToSort[i];
            var startComparingFromIndex = i - 1;
            while ((startComparingFromIndex >= 0)
            && (numbersToSort[startComparingFromIndex] > temp))
            {
                numbersToSort[startComparingFromIndex + 1] = numbersToSort[startComparingFromIndex];
                startComparingFromIndex--;
            }
            numbersToSort[startComparingFromIndex + 1] = temp;
        }
        return numbersToSort;
    }
}
