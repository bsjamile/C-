using System.Globalization;

namespace exerc17
{
    class program
    {
        static void Main(string[] args)
        {
            Temperatura t = new Temperatura();

            Console.Write("Temp em Cº: ");
            double temp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Temp em Fº: { t.CalcTemp(temp)}");
        }
    }
}