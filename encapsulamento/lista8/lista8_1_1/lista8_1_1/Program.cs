using System;
using System.Globalization;

namespace lista8_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco();
            Banco b1 = new Banco();

            Console.Write("Entre o número da conta: ");
            b.NumConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            b.NomeTit = Console.ReadLine();

            do
            {
                Console.Write("Haverá depósito inicial (s/n)? ");
                b.Resp = Console.ReadLine();
                b.RespCh = char.ToUpper(b.Resp[0]);

                if (b.RespCh != 'S' && b.RespCh != 'N')
                {
                    Console.WriteLine("Digite uma resposta válida!");
                }

            } while (b.RespCh != 'S' && b.RespCh != 'N');

            if (b.RespCh == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                b.DepIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                b.Saldo += b.DepIni;
            }

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{b}");

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            b.ValorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            b.Saldo += b.ValorDep;

            Console.WriteLine($"Dados da conta  atualizados: \n{b}");

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            b.ValorSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            b.Saldo = b.Saldo - b.ValorSaq - 5;

            Console.WriteLine();
            Console.WriteLine($"Dados da conta  atualizados: \n{b}");

            Console.WriteLine();
            Console.Write("Entre o número da conta: ");
            b1.NumConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            b1.NomeTit = Console.ReadLine();

            do
            {
                Console.Write("Haverá depósito inicial (s/n)? ");
                b1.Resp = Console.ReadLine();
                b1.RespCh = char.ToUpper(b1.Resp[0]);

                if (b1.RespCh != 'S' && b1.RespCh != 'N')
                {
                    Console.WriteLine("Digite uma resposta válida!");
                }

            } while (b1.RespCh != 'S' && b1.RespCh != 'N');

            if (b1.RespCh == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                b1.DepIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                b1.Saldo += b1.DepIni;
            }

            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n{b1}");

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            b1.ValorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            b1.Saldo += b1.ValorDep;

            Console.WriteLine($"Dados da conta  atualizados: \n{b1}");

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            b1.ValorSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            b1.Saldo = b1.Saldo - b1.ValorSaq - 5;

            Console.WriteLine();
            Console.WriteLine($"Dados da conta  atualizados: \n{b1}");
        }
    }
}