namespace CodingProblems;

public class HelperFunctions
{
    public static List<int> GetUserInputNumbers()
    {
        Console.WriteLine("Enter the numbers separated by space: ");
        List<int> inputNumbers = new();
        while (true)
        {
            var inputKey = (char)Console.Read();
            if (inputKey == '\n')
                break;
            bool isValid = Int32.TryParse(inputKey.ToString(), out var inputNumber);
            if (isValid)
                inputNumbers.Add(inputNumber);
        }
        return inputNumbers;
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
}
