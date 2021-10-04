``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1110 (20H2/October2020Update)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT


```
|          Method |     Mean |   Error |  StdDev | Rank |  Gen 0 | Allocated |
|---------------- |---------:|--------:|--------:|-----:|-------:|----------:|
| SplitCharacters | 114.4 ns | 1.95 ns | 1.52 ns |    1 | 0.0355 |     224 B |
