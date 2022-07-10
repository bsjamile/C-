using System;
using System.Globalization;

namespace lista8_1_7
{
    class Banco
    {
        private char _respCh;
        private string _nome;

        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public Banco(string nomeTit, int numConta)
        {
            this.Nome = nomeTit;
            this.Conta = numConta;
        }

        public Banco(string nomeTit, int numConta, double depIni) : this(nomeTit, numConta)
        {
            Saldo = Deposito(depIni);
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public void DepositoInicial()
        {
            do
            {
                Console.Write("Haverá depósito inicial (s/n)? ");
                var Resp = Console.ReadLine();
                _respCh = char.ToUpper(Resp[0]);

                if (_respCh != 'S' && _respCh != 'N')
                {
                    Console.WriteLine("Digite uma resposta válida!");
                }

            } while (_respCh != 'S' && _respCh != 'N');

            if (_respCh == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double DepIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Saldo += Deposito(DepIni);
            }
        }
        public double Deposito(double ValorDep)
        {      
            return Saldo += ValorDep;
        }

        public double Saque(double ValorSaq)
        {       
            return Saldo = Saldo - ValorSaq - 5;
        }
        public override string ToString()
        {
            return $"Conta {Conta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
