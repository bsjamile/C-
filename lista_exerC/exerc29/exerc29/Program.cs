using System.Globalization;

namespace exerc29
{
    class program
    {
        static void Main(string[] args)
        {
           Salario income = new Salario();

            Console.Write("Salario Fixo: R$");
            double salarioF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor vendas: R$");
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário Total: R${income.TotalSalario(salarioF,vendas)}");

        }
    }
}