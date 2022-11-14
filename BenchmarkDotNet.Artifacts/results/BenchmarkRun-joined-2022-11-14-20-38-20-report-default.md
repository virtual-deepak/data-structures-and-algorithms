
BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2130/21H2/November2021Update)
Intel Core i7-8665U CPU 1.90GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2


                     Type |                   Method |        Mean |      Error |     StdDev |      Median |   Gen0 | Allocated |
------------------------- |------------------------- |------------:|-----------:|-----------:|------------:|-------:|----------:|
      BubbleSortBenchmark |          ForSortedInputs |   617.45 ns | 117.376 ns | 346.086 ns |   726.67 ns | 0.0572 |     240 B |
   InsertionSortBenchmark |          ForSortedInputs |    94.20 ns |   1.388 ns |   1.946 ns |    94.02 ns | 0.0573 |     240 B |
       MergeSortBenchmark |          ForSortedInputs |   560.63 ns |  40.566 ns | 117.690 ns |   494.98 ns | 0.2728 |    1144 B |
  QuickSortHoareBenchmark |          ForSortedInputs | 1,128.35 ns |  21.669 ns |  52.747 ns | 1,114.56 ns | 0.1583 |     669 B |
 QuickSortLomutoBenchmark |          ForSortedInputs | 1,278.40 ns |  36.281 ns | 105.834 ns | 1,243.71 ns | 0.1583 |     669 B |
   SelectionSortBenchmark |          ForSortedInputs |   156.32 ns |   3.161 ns |   4.922 ns |   156.08 ns | 0.0572 |     240 B |
      BubbleSortBenchmark |   ForReverseSortedInputs |   321.12 ns |  17.931 ns |  47.862 ns |   305.27 ns | 0.0572 |     240 B |
   InsertionSortBenchmark |   ForReverseSortedInputs |   195.23 ns |  10.052 ns |  29.639 ns |   191.14 ns | 0.0572 |     240 B |
       MergeSortBenchmark |   ForReverseSortedInputs |   604.44 ns |  39.889 ns | 117.614 ns |   603.87 ns | 0.2728 |    1144 B |
  QuickSortHoareBenchmark |   ForReverseSortedInputs | 1,303.71 ns |  37.222 ns | 105.592 ns | 1,284.14 ns | 0.1717 |     723 B |
 QuickSortLomutoBenchmark |   ForReverseSortedInputs | 2,347.00 ns | 260.265 ns | 703.641 ns | 2,186.07 ns | 0.1678 |     709 B |
   SelectionSortBenchmark |   ForReverseSortedInputs |   164.17 ns |   3.298 ns |   2.575 ns |   164.14 ns | 0.0572 |     240 B |
      BubbleSortBenchmark | ForUnorderedSortedInputs |   220.40 ns |   4.407 ns |  10.037 ns |   216.97 ns | 0.0572 |     240 B |
   InsertionSortBenchmark | ForUnorderedSortedInputs |   150.90 ns |   4.315 ns |  12.655 ns |   146.92 ns | 0.0572 |     240 B |
       MergeSortBenchmark | ForUnorderedSortedInputs |   617.01 ns |  36.531 ns | 106.563 ns |   621.64 ns | 0.2728 |    1144 B |
  QuickSortHoareBenchmark | ForUnorderedSortedInputs | 1,428.39 ns |  55.529 ns | 161.981 ns | 1,369.82 ns | 0.1659 |     696 B |
 QuickSortLomutoBenchmark | ForUnorderedSortedInputs | 1,132.54 ns |  22.132 ns |  48.580 ns | 1,123.42 ns | 0.1640 |     697 B |
   SelectionSortBenchmark | ForUnorderedSortedInputs |   160.61 ns |   2.650 ns |   6.142 ns |   158.55 ns | 0.0572 |     240 B |
