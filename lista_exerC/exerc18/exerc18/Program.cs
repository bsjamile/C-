using System.Globalization;

namespace exerc18
{
    class program
    {
        static void Main(string[] args)
        {
            Salario sal = new Salario();

            Console.Write("Horas trabalhadas: ");
            double hT = double.Parse(Console.ReadLine());

            Console.Write("Horas extras: ");
            double hE = double.Parse(Console.ReadLine());

            sal.CalcSal(hT, hE);
        }
    }
}