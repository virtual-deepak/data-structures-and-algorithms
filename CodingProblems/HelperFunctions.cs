namespace CodingProblems;

public class HelperFunctions
{
    public static List<int> GetUserInputNumbers()
    {
        Console.WriteLine("Enter the numbers separated by space: ");
        var inputStringNumbers = Console.ReadLine().Split(" ").ToList();
        return inputStringNumbers.Select(x => int.Parse(x)).ToList();
    }

    public static void PrintOutput(List<int> numbers)
    {
        Console.WriteLine("Output: " + string.Join(",", numbers));
    }

    public static List<char> GetUserInputCharacters()
    {
        Console.WriteLine("Enter the characters separated by space: ");
        List<char> inputChars = new();
        while (true)
        {
            var inputKey = (char)Console.Read();
            if (inputKey == '\n')
                break;
            inputChars.Add(inputKey);
        }
        return inputChars;
    }

    public static void PrintOutput(List<char> chars)
    {
        Console.WriteLine("Output: " + string.Join(",", chars));
    }

    public static (List<int> inputArray, int target) GetInputTwoSumInSortedArray()
    {
        var inputArray = HelperFunctions.GetUserInputNumbers();
        Console.Write("Enter Target value: ");
        int target = Int32.Parse(Console.ReadLine());
        return (inputArray, target);
    }

    public static List<LinkedListNode> GetInputArrayOfLinkedLists()
    {
        //TODO: Get an input array of numbers, form a linked list for each and return
        return null;
    }

    public static List<List<int>> GetInputArrayOfIntervalsEaschSizeTwo()
    {
        //TODO: Get a List<List<int>> intervals and return
        return null;
    }
}
