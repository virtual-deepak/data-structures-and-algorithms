using BenchmarkDotNet.Attributes;
using Sorting;

namespace SortingBenchmark;

[MemoryDiagnoser]
[MarkdownExporter]
public class BubbleSortBenchmark
{
    [Benchmark]
    public void ForSortedInputs()
    {
        new BubbleSort(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).Sort();
    }

    [Benchmark]
    public void ForReverseSortedInputs()
    {
        new BubbleSort(new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }).Sort();
    }

    [Benchmark]
    public void ForUnorderedSortedInputs()
    {
        new BubbleSort(new List<int> { 10, 1, 5, 8, 3, 9, 2, 4, 6, 7 }).Sort();
    }
}
