namespace Sorting;

public class CountingSort
{
    /// <summary>
    /// The list of integers to sort
    /// </summary>
    private List<int> numbersToSort;

    /// <summary>
    /// Constructor for Counting sort
    /// </summary>
    /// <param name="numbersToSort"></param>
    public CountingSort(List<int> numbersToSort)
    {
        this.numbersToSort = numbersToSort;
    }

    /// <summary>
    /// Sorts the input numbers
    /// </summary>
    public List<int> Sort()
    {
        var min = int.MaxValue;
        var max = int.MinValue;
        Dictionary<int, int> counts = new Dictionary<int, int>();

        for (int index = 0; index < numbersToSort.Count; index++)
        {
            if (numbersToSort[index] < min)
                min = numbersToSort[index];

            if (numbersToSort[index] > max)
                max = numbersToSort[index];

            if (!counts.ContainsKey(numbersToSort[index]))
                counts.Add(numbersToSort[index], 0);
            counts[numbersToSort[index]] += 1;
        }

        var k = 0;
        for (int i = min; i <= max; i++)
        {
            if (counts.ContainsKey(i))
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    numbersToSort[k++] = i;
                }
            }
        }
        return numbersToSort;
    }
}
