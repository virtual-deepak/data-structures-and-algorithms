namespace Sorting;

public class RadixSort
{
    /// <summary>
    /// The list of integers to sort
    /// </summary>
    private List<int> numbersToSort;

    /// <summary>
    /// Constructor for Radix sort
    /// </summary>
    /// <param name="numbersToSort"></param>
    public RadixSort(List<int> numbersToSort)
    {
        this.numbersToSort = numbersToSort;
    }

    /// <summary>
    /// Sorts the input numbers
    /// </summary>
    public List<int> Sort()
    {
        int maxDigits = GetMaxElement(numbersToSort).ToString().Length;
        int BASEVALUE = 10;
        for (int digitCount = 0; digitCount < maxDigits; digitCount++)
        {
            // Bucket sort to bucket elements for the n-th digit place of the numbers 
            numbersToSort = BucketSort(numbersToSort, (int)Math.Pow(BASEVALUE, digitCount), BASEVALUE);
        }
        return numbersToSort;
    }

    public List<int> BucketSort(List<int> numbersToSort, int place, int BASEVALUE)
    {
        Dictionary<int, List<int>> buckets = new();
        List<int> output = new();

        int minKey = int.MaxValue;
        int maxKey = int.MinValue;

        for (int elementIndex = 0; elementIndex < numbersToSort.Count; elementIndex++)
        {
            // Get the key of the dictionary (bucket) as "place" of number i.e. unit, tenth, hundredth etc.   
            var key = (numbersToSort[elementIndex] / place) % BASEVALUE;

            // Find out the min and max key for bucket which appears in the given "place" of numbers
            if (key < minKey)
                minKey = key;
            if (key > maxKey)
                maxKey = key;

            if (!buckets.ContainsKey(key))
                buckets.Add(key, new List<int>());

            // Add the elements in the bucket given the key
            buckets[key].Add(numbersToSort[elementIndex]);
        }

        // Iterate through the bucket and append all elements with each key
        for (int i = minKey; i <= maxKey; i++)
        {
            if (buckets.ContainsKey(i))
                output.AddRange(buckets[i]);
        }
        return output;
    }

    public int GetMaxElement(List<int> numbersToSort)
    {
        int maxElement = int.MinValue;
        for (int i = 0; i < numbersToSort.Count; i++)
        {
            if (numbersToSort[i] > maxElement)
                maxElement = numbersToSort[i];
        }
        return maxElement;
    }
}
