using System.Globalization;

namespace exerc25
{
    class program
    {
        static void Main(string[] args)
        {
            Multiplicacao mult = new Multiplicacao();

            Console.Write("Número 1: ");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número 2: ");
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número 3: ");
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Multiplicação: {mult.Mult(num1, num2, num3)}");

        }
    }
}