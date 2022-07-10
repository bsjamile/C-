using System;
using System.Globalization;

namespace lista6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ConverterMoeda(cot, qtd);

            Console.WriteLine($"Valor a ser pago em reais = {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}