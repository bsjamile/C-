using System;
using System.Globalization;

namespace lista8_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = (Console.ReadLine());

            b = new Banco(nome, conta);

            b.DepositoInicial();

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{b}");

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposito(valorDep);

            Console.WriteLine($"Dados da conta  atualizados: \n{b}");

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Saque(valorSaq);

            Console.WriteLine();
            Console.WriteLine($"Dados da conta  atualizados: \n{b}");

            Console.WriteLine();
            Console.Write("Entre o número da conta: ");
            int conta1 = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome1 = (Console.ReadLine());

            Banco b1 = new Banco(nome1, conta1);

            b1.DepositoInicial();

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{b1}");

            Console.Write("Entre um valor para depósito: ");
            valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b1.Deposito(valorDep);

            Console.WriteLine($"Dados da conta  atualizados: \n{b1}");

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valorSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b1.Saque(valorSaq);

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
