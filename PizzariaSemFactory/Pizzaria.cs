namespace PizzariaSemFactory;

public class Pizzaria
{
    
    public static void SolicitaPizza()
    {
        PizzaCalabreza pizza1;
        PizzaMussarela pizza2;
        //Console.WriteLine("======Pizzaria======");
        //Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussarela \n");
        //var pizzaEscolhida = Console.ReadLine()!.ToUpper();
        var pizzaEscolhida = "M";

        if (pizzaEscolhida.Equals("C"))
        {
            pizza1 = new PizzaCalabreza();
            pizza1.Preparar();
            pizza1.Assar(10);
            pizza1.Embalar();
            //Console.WriteLine("Pizza finalizada");
        }
        else if (pizzaEscolhida == "M")
        {
            pizza2 = new PizzaMussarela();
            pizza2.Preparar();
            pizza2.Assar(10);
            pizza2.Embalar();
            //Console.WriteLine("Pizza finalizada");
        }
        else
        {
            Console.WriteLine("Pizza não existe no catálogo.");
        }
    }
}
