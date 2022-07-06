using System.Globalization;

namespace exerc38
{
    class program
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary();

            Console.Write("Salário: R$");
            double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário após Pgtos: R${salary.CalcSalary(income)}");
        }
    }
}