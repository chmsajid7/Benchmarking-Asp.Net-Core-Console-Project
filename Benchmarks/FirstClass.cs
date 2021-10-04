using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class MyClass
    {
        private const string str = "I am using Asp.Net Core";

        [Benchmark]
        public void SplitCharacters()
        {
            string[] characters = str.Split(" ");
        }
    }
}
