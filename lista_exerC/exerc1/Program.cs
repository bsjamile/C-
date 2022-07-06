using System;
using System.Globalization;

namespace lista_exerC
{
    class program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.Write("Digite altura: ");
            double alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite largura: ");
            double larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{r}{ r.Area(alt, larg).ToString("F2", CultureInfo.InvariantCulture)} m²");
        }
    }
}



