using System.Globalization;

namespace exerc35
{
    class program
    {
        static void Main(string[] args)
        {
            Income p = new Income();

            Console.Write("Salário Mínimo: ");
            double salMin = double.Parse(Console.ReadLine());

            Console.Write("Salário Funcionário: ");
            double salF = double.Parse(Console.ReadLine());

            p.CalcSal(salMin, salF);
        }
    }
}