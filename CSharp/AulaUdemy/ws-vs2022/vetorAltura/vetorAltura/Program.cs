using System;
using System.Globalization;

namespace vetorAltura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas alturas: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] altura = new double[n];

            double sum = 0.0, average = 0.0;

            for (int i = 0; i < n; i++)
            {            
                altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                sum += altura[i];

                average = sum / n;
            }           

            Console.WriteLine($"AVERAGE HEIGHT = {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
