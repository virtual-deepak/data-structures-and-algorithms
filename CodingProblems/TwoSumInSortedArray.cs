namespace CodingProblems;

public static class TwoSumInSortedArrays
{
    public static List<int> Execute(List<int> numbers, int target)
    {
        int i = 0;
        int j = numbers.Count - 1;
        
        while ( i < j)
        {
            if ((numbers[i] + numbers[j]) < target)
                i++;
            else if ((numbers[i] + numbers[j]) > target)
                j--;
            else
                return new List<int> { i, j };
        }
        return new List<int> { -1, -1 };
    }
}