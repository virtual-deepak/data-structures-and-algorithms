using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(value: "Enter the numbers to be sorted (type 'done' when completed): ");
        List<int> arrInput = new List<int>();

        string input = Console.ReadLine();
        while (!string.Equals(input, "done", StringComparison.InvariantCultureIgnoreCase))
        {
            if (int.TryParse(input, out int number))
            {
                arrInput.Add(number);
            }
            else
            {
                Console.WriteLine("Not a number, try again.");
            }
            input = Console.ReadLine();
        }
        SelectionSort(arrInput);
        Console.WriteLine($"Sorted array: {string.Join(" ", arrInput)}");
    }

    static void SelectionSort(List<int> arrInput)
    {
        for (int index = 0; index < arrInput.Count; index++)
        {
            var minNumber = arrInput[index];
            var minNumberIndex = index;

            for (int innerIndex = index + 1; innerIndex < arrInput.Count; innerIndex++)
            {
                if (arrInput[innerIndex] < minNumber)
                {
                    minNumber = arrInput[innerIndex];
                    minNumberIndex = innerIndex;
                }
            }
            Swap(arrInput, index, minNumberIndex);
        }
    }

    static void Swap(List<int> arrInput, int index, int minNumberIndex)
    {
        var temp = arrInput[index];
        arrInput[index] = arrInput[minNumberIndex];
        arrInput[minNumberIndex] = temp;
    }
}