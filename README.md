# Benchmarking-Asp.Net-Core-Console-Project-

Benchmarks is used to test that how fast your code is. 
To run the Benchmarks;
1. Save the project.
2. Open Power-Shell, and open the directory where project is saved (i.e. cd C:\Users\username\source\repos\Benchmarking)
3. In Power-Shell, Build a release (dotnet build -c Release)
4. Power-Shell will give path of a dll, so run (dotnet C:\Users\username\source\repos\Benchmarking\Benchmarks\bin\Release\netcoreapp3.1\Benchmarks.dll)

Now you can see the results on Power-Shell...

Moreover, Compiler will also create a directory in project's folder with the name "BenchmarkDotNet.Artifacts".
