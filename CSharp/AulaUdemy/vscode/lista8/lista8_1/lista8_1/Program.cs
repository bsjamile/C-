using System;
using System.Globalization;

namespace lista8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            char respCh;
            double saldo = 0;

            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nomeTit = Console.ReadLine();

            do {
                Console.Write("Haverá depósito inicial (s/n)? ");
                resp = Console.ReadLine();
                respCh = char.ToUpper(resp[0]);

                if (respCh != 'S' && respCh != 'N')
                {
                    Console.WriteLine("Digite uma resposta válida!");
                }

            } while (respCh != 'S' && respCh != 'N');

                if (respCh == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                saldo += depIni;
            }

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \nConta {numConta}, Titular: {nomeTit}, Saldo: $ {saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            saldo += valorDep;

            Console.WriteLine($"Dados da conta  atualizados: \nConta {numConta}, Titular: {nomeTit}, Saldo: $ {saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            saldo = saldo - valorSaq - 5;

            Console.WriteLine();
            Console.WriteLine($"Dados da conta  atualizados: \nConta {numConta}, Titular: {nomeTit}, Saldo: $ {saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
