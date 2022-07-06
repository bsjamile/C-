using System;
using System.Globalization;

namespace exerc5
{
    class program
    {
        static void Main(string[] args)
        {
            Gasolina g = new Gasolina();

            Console.Write("Preço da Gasolina: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Valor do Pagamento: ");
            double valorPag = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{g.QtdGasolina(preco, valorPag).ToString("F2", CultureInfo.InvariantCulture)} litros");
        }
    }
}
