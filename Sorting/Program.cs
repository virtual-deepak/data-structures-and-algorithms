namespace Sorting
{
    /// <summary>
    /// The startup class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The SortOption enumeration
        /// </summary>
        enum SortOption
        {
            SelectionSort = 1,
            BubbleSort = 2,
            InsertionSort = 3,
            MergeSort = 4
        }

        /// <summary>
        /// Entry point of the program
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            try
            {
                (SortOption sortOption, List<int> numbersToSort) = GetValidUserInput();
                List<int> sortedOutput = sortOption switch
                {
                    SortOption.SelectionSort => new SelectionSort(numbersToSort).Sort(),
                    SortOption.BubbleSort => new BubbleSort(numbersToSort).Sort(),
                    SortOption.InsertionSort => new InsertionSort(numbersToSort).Sort(),
                    SortOption.MergeSort => new MergeSort(numbersToSort).Sort(),
                    _ => throw new Exception($"Not a valid sort option: {sortOption}"),
                };
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
            Console.WriteLine("1. Selection Sort");
            Console.WriteLine("2. Bubble Sort");
            Console.WriteLine("3. Insertion Sort");
            Console.WriteLine("4. Merge Sort");
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
}