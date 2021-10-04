using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks
{
    [MemoryDiagnoser] // Get the Memory allocated at each Benchmark.
    [Orderer(SummaryOrderPolicy.FastestToSlowest)] // Get the results in specified order.
    [RankColumn] // Get the Rank Column.
    public class FirstClass
    {
        private const string str = "I am using Asp.Net Core";

        [Benchmark] // Benchmarks will get the results for this method.
        public void SplitCharacters()
        {
            string[] characters = str.Split(" ");
        }
    }
}
