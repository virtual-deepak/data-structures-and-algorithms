using BenchmarkDotNet.Running;

namespace SortingBenchmark;

public class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<SelectionSortBenchmark>();
    }
}
