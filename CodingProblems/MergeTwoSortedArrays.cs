namespace CodingProblems;

public static class MergeTwoSortedArrays
{
    public static List<int> Execute(List<int> first, List<int> second)
    {
        int firstIndex = first.Count - 1;
        int secondIndex = first.Count - 1;
        int writeIndex = second.Count - 1;
        
        while ((firstIndex >= 0) && (secondIndex >= 0))
        {
            if (first[firstIndex] >= second[secondIndex])
            {
                second[writeIndex--] = first[firstIndex--];
            }
            else
            {
                second[writeIndex--] = second[secondIndex--];
            }
        }
        
        while (firstIndex >= 0)
        {
            second[writeIndex--] = first[firstIndex--];
        }
        
        while (secondIndex >= 0)
        {
            second[writeIndex--] = second[secondIndex--];
        }
        return second;
    }
}