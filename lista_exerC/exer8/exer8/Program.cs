using System;
using System.Globalization;

namespace exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas n = new Notas();

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"A média é: {n.Media(nota1,nota2,nota3).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}




