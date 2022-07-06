using System.Globalization;

namespace exerc14
{
    class program
    {
        static void Main(string[] args)
        {
            Area a = new Area();
            Console.Write("Raio da pizza: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"A área da pizza é: {a.AreaPizza(raio).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
