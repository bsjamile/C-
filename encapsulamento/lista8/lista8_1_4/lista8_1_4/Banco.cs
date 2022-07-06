using System;
using System.Globalization;

namespace lista8_1_4
{
    class Banco
    {
        public int NumConta;
        public string NomeTit;
        public char RespCh;
        public double Saldo = 0;

        public Banco( string NomeTit, int NumConta)
        {
            this.NomeTit = NomeTit;
            this.NumConta = NumConta;
        }

        public void DepositoInicial()
        {
            do
            {
                Console.Write("Haverá depósito inicial (s/n)? ");
                var Resp = Console.ReadLine();
                RespCh = char.ToUpper(Resp[0]);

                if (RespCh != 'S' && RespCh != 'N')
                {
                    Console.WriteLine("Digite uma resposta válida!");
                }

            } while (RespCh != 'S' && RespCh != 'N');

            if (RespCh == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double DepIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Saldo += DepIni;
            }
        }

        public double Deposito()
        {
            Console.Write("Entre um valor para depósito: ");
            double ValorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return Saldo += ValorDep;
        }

        public double Saque()
        {
            Console.Write("Entre um valor para saque: ");
            double ValorSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return Saldo = Saldo - ValorSaq - 5;
        }


        public override string ToString()
        {
            return $"Conta {NumConta}, Titular: {NomeTit}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
