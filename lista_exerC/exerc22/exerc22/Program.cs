using System.Globalization;

namespace exerc22
{
    class program
    {
        static void Main(string[] args)
        {
            Moeda coin = new Moeda();

            Console.Write("Qtd Moeda 1 cent: ");
            int umCent = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qtd Moeda 5 cent: ");
            int cincoCent = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qtd Moeda 10 cent: ");
            int dezCent = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qtd Moeda 25 cent: ");
            int vinteCincoCent = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qtd Moeda 50 cent: ");
            int cinquentaCent = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qtd Moeda 1 real: ");
            int umReal = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total economizado: R${ coin.QtdMoeda(umCent, cincoCent, dezCent, vinteCincoCent, cinquentaCent, umReal).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}