using System.Globalization;

namespace VetorClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            double sumPreco = 0;

            Console.Write("Qtd de Produtos: ");
            int qtd = int.Parse(Console.ReadLine());

            Produto[] valores = new Produto[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Produto: ");
                string prod = Console.ReadLine();

                Console.Write($"Preço {prod}: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                valores[i] = new Produto { Nome = prod, Preco = preco };

                sumPreco += valores[i].Preco;
            }

            double avg = p.Media(sumPreco, qtd);

            Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}



