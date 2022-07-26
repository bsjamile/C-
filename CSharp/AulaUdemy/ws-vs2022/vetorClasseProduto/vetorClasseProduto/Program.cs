using System;
using System.Globalization;

namespace vetorClasseProduto
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            double sum = 0.0, average = 0.0;

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };

                sum += vect[i].Price;

            }

            average = sum / n;

            Console.WriteLine($"AVERAGE PRICE = {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
