using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using System;

namespace Benchmarks
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MyClass>();
            BenchmarkRunner.Run<SecondClass>();
        }
    }
}
