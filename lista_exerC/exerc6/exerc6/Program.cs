using System;
using System.Globalization;

namespace exerc6
{
    class program
    {
        static void Main(string[] args)
        {
            Restaurante r = new Restaurante();

            Console.Write("Peso do prato (em quilos): ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O valor a pagar é: R${r.Valor(peso).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
