using BenchmarkDotNet.Attributes;

namespace PadroesCriacionais;

public class ComparacaoBenchmarks
{
    [Benchmark]
    public void SolicitaPizzaSemFactory()
    {
        PizzariaSemFactory.Pizzaria.SolicitaPizza();
    }

    [Benchmark]
    public void SolicitaPizzaSimpleFactory()
    {
        PizzariaSimpleFactory.Pizzaria.SolicitaPizza();
    }
}
