```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.202
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2


```
| Method                     | Mean     | Error     | StdDev    |
|--------------------------- |---------:|----------:|----------:|
| SolicitaPizzaSemFactory    | 2.608 ns | 0.0685 ns | 0.0815 ns |
| SolicitaPizzaSimpleFactory | 6.827 ns | 0.1926 ns | 0.5370 ns |
