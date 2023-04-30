namespace CodingProblems;

public class HelperFunctions
{
    public static List<int> GetUserInputNumbers()
    {
        Console.WriteLine("Enter the numbers: ");
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

    public static void PrintNumbers(List<int> numbers)
    {
        Console.WriteLine("Output: " + string.Join(",", numbers));
    }
}
