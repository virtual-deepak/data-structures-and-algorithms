namespace CodingProblems;
internal class SegregateEvenOdd
{
    public static List<int> Execute(List<int> numbers)
    {
        if (numbers.Count < 2)
            return numbers;

        var startPointer = 0;
        var endPointer = numbers.Count - 1;

        while (startPointer < endPointer)
        {
            if (numbers[startPointer] % 2 == 0)
                startPointer++;
            else if (numbers[endPointer] % 2 == 1)
                endPointer--;
            else
            {
                Swap(numbers, startPointer, endPointer);
                startPointer++;
                endPointer--;
            }
        }
        return numbers;
    }

    public static void Swap(List<int> numbers, int i, int j)
    {
        if (i == j)
            return;

        numbers[i] = numbers[i] + numbers[j];
        numbers[j] = numbers[i] - numbers[j];
        numbers[i] = numbers[i] - numbers[j];
    }
}