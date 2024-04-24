namespace PizzariaSimpleFactory;

public class Pizzaria
{
    public static void SolicitaPizza()
    {
        //Console.WriteLine("======Pizzaria======");
        //Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussarela \n");
        //var tipo = Console.ReadLine()!.ToUpper();
        var tipo = "M";
        try
        {
            Pizza pizza = PizzaSimpleFactory.CriaPizza(tipo);
            pizza.Preparar();
            pizza.Assar(10);
            pizza.Embalar();
            //Console.WriteLine("Pizza finalizada.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro :" + ex.Message);
        }
    }
}
