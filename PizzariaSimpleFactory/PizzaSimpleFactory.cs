namespace PizzariaSimpleFactory;

public sealed class PizzaSimpleFactory
{
    public static Pizza CriaPizza(string tipo)
    {
        Pizza pizza = tipo switch
        {
            "C" => new PizzaCalabreza(),
            "M" => new PizzaMussarela(),
            _ => throw new ApplicationException($"A pizza do tipo '{tipo}' não foi encontrada"),
        };
        return pizza;
    }
}
