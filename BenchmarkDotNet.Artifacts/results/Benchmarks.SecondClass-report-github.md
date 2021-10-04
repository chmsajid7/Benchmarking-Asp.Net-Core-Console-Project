``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1110 (20H2/October2020Update)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT


```
|                   Method |       Mean |     Error |    StdDev |     Median | Rank |  Gen 0 | Allocated |
|------------------------- |-----------:|----------:|----------:|-----------:|-----:|-------:|----------:|
| GetYearFromSpan_Manually |   5.779 ns | 0.1193 ns | 0.1058 ns |   5.717 ns |    1 |      - |         - |
|          GetYearFromSpan |  17.634 ns | 0.3593 ns | 0.3361 ns |  17.657 ns |    2 |      - |         - |
|     GetYearFromSubstring |  28.337 ns | 0.4440 ns | 0.3936 ns |  28.247 ns |    3 | 0.0051 |      32 B |
|         GetYearFromSplit |  88.539 ns | 1.7807 ns | 3.9086 ns |  87.103 ns |    4 | 0.0254 |     160 B |
|      GetYearFromDateTime | 332.806 ns | 2.5854 ns | 2.1589 ns | 332.494 ns |    5 |      - |         - |
