using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Perfolizer.Horology;

namespace DNTPersianUtils.Core.PerformanceTests;

internal class Program
{
    private static void Main(string[] args)
    {
        runBenchmarks();
    }

    private static void runBenchmarks()
    {
        var config = ManualConfig.Create(DefaultConfig.Instance)
                                 .With(EnvironmentAnalyser.Default)
                                 .With(MarkdownExporter.GitHub)
                                 .With(MemoryDiagnoser.Default)
                                 .With(StatisticColumn.Mean)
                                 .With(StatisticColumn.Median)
                                 .With(StatisticColumn.StdDev)
                                 .With(StatisticColumn.OperationsPerSecond)
                                 .With(BaselineRatioColumn.RatioMean)
                                 .With(RankColumn.Arabic)
                                 .With(Job.Default.With(CoreRuntime.Core31)
                                          .WithIterationCount(300)
                                          .WithInvocationCount(160)
                                          .WithIterationTime(TimeInterval.FromSeconds(1000))
                                          .WithWarmupCount(4)
                                          .WithLaunchCount(1));
        BenchmarkRunner.Run<BenchmarkTestsForStringReplace>(config);
    }
}