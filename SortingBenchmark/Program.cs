using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace SortingBenchmark;

public class Program
{
    public static void Main()
    {
        _ = BenchmarkRunner.Run(
            typeof(Program).Assembly, // all benchmarks from given assembly are going to be executed
            ManualConfig
                .Create(DefaultConfig.Instance)
                .With(ConfigOptions.JoinSummary)
                .With(ConfigOptions.DisableLogFile));
    }
}
