using System.Globalization;

namespace exerc30
{
    class program
    {
        static void Main(string[] args)
        {
            Peso p = new Peso();

            Console.Write("Peso: ");
            double peso = double.Parse(Console.ReadLine());

            p.CalcPeso(peso);
        }
    }
}