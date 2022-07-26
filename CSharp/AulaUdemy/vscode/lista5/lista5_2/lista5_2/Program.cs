using System.Globalization;

namespace lista5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f, f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();
            f = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            double.TryParse(Console.ReadLine(), out f1.sal1);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            double.TryParse(Console.ReadLine(), out f2.sal2);

            f.Media(f1.sal1, f2.sal2);

            Console.WriteLine($"{f}");
            
            
        }
    }
}
