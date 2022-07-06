using System.Globalization;

namespace exerc27
{
    class program
    {
        static void Main(string[] args)
        {
            Media m = new Media();

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Média: { m.CalcMedia(nota1, nota2)}");
        }
    }
}