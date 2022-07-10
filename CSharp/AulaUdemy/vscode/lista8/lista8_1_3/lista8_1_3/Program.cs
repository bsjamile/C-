using System;
using System.Globalization;

namespace lista8_1_3
{
    class Program
    {
        static void Main(string[] arg)
        {
            Banco b, b1;
            b = new Banco();
            b1 = new Banco();

            Console.Write("Entre o número da conta: ");
            b.NumConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            b.NomeTit = Console.ReadLine();

            b.DepositoInicial();

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{b}");

            Console.WriteLine();
            b.Deposito();

            Console.WriteLine($"Dados da conta  atualizados: \n{b}");

            Console.WriteLine();
            b.Saque();

            Console.WriteLine();
            Console.WriteLine($"Dados da conta  atualizados: \n{b}");

            Console.WriteLine();
            Console.Write("Entre o número da conta: ");
            b1.NumConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            b1.NomeTit = Console.ReadLine();

            b1.DepositoInicial();

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{b1}");

            Console.WriteLine();
            b1.Deposito();

            Console.WriteLine($"Dados da conta  atualizados: \n{b1}");

            Console.WriteLine();
            b1.Saque();

            Console.WriteLine();
            Console.WriteLine($"Dados da conta  atualizados: \n{b1}");
            Console.WriteLine();

            double saldo1 = b.Saldo;
            double saldo2 = b1.Saldo;

            Console.WriteLine($"{b.NomeTit} tem $ {saldo1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{b1.NomeTit} tem $ {saldo2.ToString("F2", CultureInfo.InvariantCulture)}");

            if (saldo1 > saldo2)
            {
                Console.WriteLine($"{b.NomeTit} tem mais dinheiro do que {b1.NomeTit}");
            }
            else if (saldo1 < saldo2)
            {
                Console.WriteLine($"{b1.NomeTit} tem mais dinheiro do que {b.NomeTit}");
            }
            else
            {
                Console.WriteLine($"{b.NomeTit} e {b1.NomeTit} tem o mesmo valor na conta!");
            }
        }
    }
}