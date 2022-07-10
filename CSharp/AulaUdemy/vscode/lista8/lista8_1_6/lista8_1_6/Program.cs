using System;
using System.Globalization;

namespace lista8_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco(); ;

            Console.Write("Entre o número da conta: ");
            b.Conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            b.Nome = (Console.ReadLine());

            b = new Banco(b.Nome, b.Conta);

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
            b1.Conta= int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            b1.Nome = (Console.ReadLine());

            b1 = new Banco(b1.Nome, b1.Conta);

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

            Console.WriteLine($"{b.Nome} tem $ {saldo1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{b1.Nome} tem $ {saldo2.ToString("F2", CultureInfo.InvariantCulture)}");

            if (saldo1 > saldo2)
            {
                Console.WriteLine($"{b.Nome} tem mais dinheiro do que {b1.Nome}");
            }
            else if (saldo1 < saldo2)
            {
                Console.WriteLine($"{b1.Nome} tem mais dinheiro do que {b.Nome}");
            }
            else
            {
                Console.WriteLine($"{b.Nome} e {b1.Nome} tem o mesmo valor na conta!");
            }
        }
    }
}
