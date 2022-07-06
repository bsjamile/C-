using System.Globalization;

namespace exerc26
{
    class program
    {
        static void Main(string[] args)
        {
            Divisao d = new Divisao();

            Console.Write("Número 1: ");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número 2: ");
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{num1} / {num2} = {d.CalcDiv(num1, num2)}");
        }
    }
}