using System;
using System.Globalization;

namespace lista8_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco(); ;

            Console.Write("Entre o número da conta: ");
            b.SetConta(int.Parse(Console.ReadLine()));

            Console.Write("Entre o titular da conta: ");
            b.SetNome(Console.ReadLine());

            b = new Banco(b.GetNome(), b.GetConta());

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

            Banco b1 = new Banco();

            Console.WriteLine();
            Console.Write("Entre o número da conta: ");
            b1.SetConta(int.Parse(Console.ReadLine()));

            Console.Write("Entre o titular da conta: ");
            b1.SetNome(Console.ReadLine());

            b1 = new Banco(b1.GetNome(), b1.GetConta());

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

            double saldo1 = b.GetSaldo();
            double saldo2 = b1.GetSaldo();

            Console.WriteLine($"{b.GetNome()} tem $ {saldo1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{b1.GetNome()} tem $ {saldo2.ToString("F2", CultureInfo.InvariantCulture)}");

            if (saldo1 > saldo2)
            {
                Console.WriteLine($"{b.GetNome()} tem mais dinheiro do que {b1.GetNome()}");
            }
            else if (saldo1 < saldo2)
            {
                Console.WriteLine($"{b1.GetNome()} tem mais dinheiro do que {b.GetNome()}");
            }
            else
            {
                Console.WriteLine($"{b.GetNome()} e {b1.GetNome()} tem o mesmo valor na conta!");
            }
        }
    }
}
