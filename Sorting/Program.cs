internal class Program
{
    enum SortOption
    {
        BenchmarkAll = 1,
        SelectionSort = 2
    }

    private static void Main(string[] args)
    {
        try
        {
            (SortOption sortOption, List<int> numbersToSort) = GetValidUserInput();
            List<int> sortedOutput = null;
            switch (sortOption)
            {
                case SortOption.SelectionSort:
                    sortedOutput = new SelectionSort(numbersToSort).Sort();
                    break;
                case SortOption.BenchmarkAll:
                    break;
                default:
                    throw new Exception($"Not a valid sort option: {sortOption}");
            }
            Console.WriteLine($"Sorted output: {string.Join(" ", sortedOutput)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Program terminated. Reason: {ex.Message}");
        }
    }

    /// <summary>
    /// Gets a valid sort option and list of numbers to be sorted from user
    /// </summary>
    /// <returns></returns>
    private static (SortOption, List<int>) GetValidUserInput()
    {
        Console.WriteLine("1. Benchmark All");
        Console.WriteLine("2. Selection Sort");
        Console.Write("Your choice (enter option number): ");

        string userInput = Console.ReadLine();
        if (Enum.TryParse(typeof(SortOption), userInput.Trim(), true, out var userOption))
            return ((SortOption)userOption, GetNumbersToSort());
        throw new Exception($"Not a valid user input: {userInput}");
    }

    /// <summary>
    /// Gets the numbers to be sorted from user
    /// </summary>
    /// <returns></returns>
    private static List<int> GetNumbersToSort()
    {
        Console.WriteLine("Enter the numbers to be sorted (type 'done' when completed): ");
        List<int> arrInput = new List<int>();

        string input = Console.ReadLine();
        while (!string.Equals(input, "done", StringComparison.InvariantCultureIgnoreCase))
        {
            if (int.TryParse(input, out int number))
                arrInput.Add(number);
            else
                Console.WriteLine("Not a number, try again.");
            input = Console.ReadLine();
        }
        return arrInput;
    }
}
