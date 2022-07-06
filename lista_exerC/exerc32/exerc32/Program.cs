using System.Globalization;

namespace exerc32
{
    class program
    {
        static void Main(string[] args)
        {
            Weight p = new Weight();

            Console.Write("Peso em Kgs: ");
            double peso = double.Parse(Console.ReadLine());

            p.CalcPeso(peso);
        }
    }
}