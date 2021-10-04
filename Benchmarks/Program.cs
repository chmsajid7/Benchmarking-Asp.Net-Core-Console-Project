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
            BenchmarkRunner.Run<FirstClass>(); // Here you will get results of Benchmarks in FirstClass
            BenchmarkRunner.Run<SecondClass>(); // Here you will get results of Benchmarks in SecondClass

            // By running both, you will get the results of Benchmarks in both the classes
        }
    }
}
