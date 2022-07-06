using System.Globalization;

namespace exerc28
{
    class program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();

            Console.Write("Preço produto: R$");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Preço com desconto: R${prod.PrecoProd(preco)}");

        }
    }
}