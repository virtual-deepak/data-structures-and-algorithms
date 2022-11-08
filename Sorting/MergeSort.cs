namespace Sorting;

public class MergeSort
{
    /// <summary>
    /// The list of integers to sort
    /// </summary>
    private List<int> numbersToSort;

    /// <summary>
    /// Constructor for MergeSort
    /// </summary>
    /// <param name="numbersToSort"></param>
    public MergeSort(List<int> numbersToSort)
    {
        this.numbersToSort = numbersToSort;
    }

    /// <summary>
    /// Sorts the input numbers
    /// </summary>
    public List<int> Sort()
    {
        return PerformMergeSort(numbersToSort, 0, numbersToSort.Count - 1);
    }

    private List<int> PerformMergeSort(List<int> numbersToSort, int startIndex, int endIndex)
    {
        // Exit condition - only single number in the sub array
        if (startIndex == endIndex)
            return numbersToSort;

        // Divide the array into 2 halves
        var mid = (startIndex + endIndex) / 2;

        // Work on the first half of sub-array 
        PerformMergeSort(numbersToSort, startIndex, mid);

        // Work on the second half of sub-array
        PerformMergeSort(numbersToSort, mid + 1, endIndex);

        // Combine both halves and fill the auxilliary array with sorted numbers
        var firstHalfStartIndex = startIndex;
        var secondHalfStartIndex = mid + 1;
        var auxilliarySpace = new List<int>();
        while ((firstHalfStartIndex <= mid)
            && (secondHalfStartIndex <= endIndex))
        {
            if (numbersToSort[firstHalfStartIndex] <= numbersToSort[secondHalfStartIndex])
            {
                auxilliarySpace.Add(numbersToSort[firstHalfStartIndex]);
                firstHalfStartIndex++;
            }
            else
            {
                auxilliarySpace.Add(numbersToSort[secondHalfStartIndex]);
                secondHalfStartIndex++;
            }
        }

        // Collect all remaining of first half
        while (firstHalfStartIndex <= mid)
        {
            auxilliarySpace.Add(numbersToSort[firstHalfStartIndex]);
            firstHalfStartIndex++;
        }

        // Collect all remaining of second half
        while (secondHalfStartIndex <= endIndex)
        {
            auxilliarySpace.Add(numbersToSort[secondHalfStartIndex]);
            secondHalfStartIndex++;
        }

        // Replace the sorted sub-array within the input array 
        var auxIndex = 0;
        for (int i = startIndex; i <= endIndex; i++)
        {
            numbersToSort[i] = auxilliarySpace[auxIndex];
            auxIndex++;
        }
        return numbersToSort;
    }
}