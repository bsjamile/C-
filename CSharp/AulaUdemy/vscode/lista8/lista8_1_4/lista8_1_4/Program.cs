using System;
using System.Globalization;

namespace lista8_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Banco b = new Banco(nome, conta);

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
            conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();

            Banco b1 = new Banco(nome, conta);

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
