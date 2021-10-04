using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;

namespace Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SecondClass
    {
        private const string dateTimeToString = "2021-12-13T16:33:06Z";

        [Benchmark]
        public int GetYearFromDateTime()
        {
            var dateTime = DateTime.Parse(dateTimeToString);
            return dateTime.Year;
        }

        [Benchmark]
        public int GetYearFromSplit()
        {
            var splitter = dateTimeToString.Split('-');
            return int.Parse(splitter[0]);
        }

        [Benchmark]
        public int GetYearFromSubstring()
        {
            var splitter = dateTimeToString.IndexOf('-');
            return int.Parse(dateTimeToString.Substring(0, splitter));
        }

        [Benchmark]
        public int GetYearFromSpan()
        {
            ReadOnlySpan<char> dateTimeToSpan = dateTimeToString;

            var splitter = dateTimeToString.IndexOf('-');
            return int.Parse(dateTimeToSpan.Slice(0, splitter));
        }

        [Benchmark]
        public int GetYearFromSpan_Manually()
        {
            ReadOnlySpan<char> dateTimeToSpan = dateTimeToString;
            var splitter = dateTimeToString.IndexOf('-');
            var yearAsSpan = dateTimeToSpan.Slice(0, splitter);

            var temp = 0;
            for (int i = 0; i < yearAsSpan.Length; i++)
                temp = temp * 10 + (yearAsSpan[i] - '0');

            return temp;
        }
    }
}
