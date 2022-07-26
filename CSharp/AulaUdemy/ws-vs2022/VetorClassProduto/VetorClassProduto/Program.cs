using System;
using System.Globalization;

namespace VetorClassProduto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qtd produto: ");
            int n = int.Parse(Console.ReadLine());

            string[] produtos = new string[n];

            double[] valorProdutos = new double[n];

            double sum = 0.0, average = 0.0;

            for(int i = 0; i < n; i++)
            {
                Console.Write("Produto: ");
                produtos[i] = Console.ReadLine();

                Console.Write("Valor: ");
                valorProdutos[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                sum += valorProdutos[i];
            }

            average = sum / n;

            Console.WriteLine($"AVERAGE PRICE = {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
