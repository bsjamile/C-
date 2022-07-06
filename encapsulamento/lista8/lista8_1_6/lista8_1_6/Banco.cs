using System;
using System.Globalization;

namespace lista8_1_6
{
    class Banco
    {
        private int _numConta;
        private string _nomeTit;
        private char _respCh;
        private double _saldo = 0;

        public Banco()
        {

        }

        public Banco(string nomeTit)
        {
            this._nomeTit = nomeTit;
        }
        public Banco(string nomeTit, int numConta) : this(nomeTit)
        {
            this._numConta = numConta;
        }

        public string Nome
        {
            get { return _nomeTit; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nomeTit = value;
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

                _saldo += DepIni;
            }
        }

        public int Conta
        {
            get { return _numConta; }
            set { _numConta = value; }
        }

        public double Deposito()
        {
            Console.Write("Entre um valor para depósito: ");
            double ValorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return _saldo += ValorDep;
        }

        public double Saque()
        {
            Console.Write("Entre um valor para saque: ");
            double ValorSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return _saldo = _saldo - ValorSaq - 5;
        }

        public double Saldo
        {
            get {return _saldo; }
        }

        public override string ToString()
        {
            return $"Conta {_numConta}, Titular: {_nomeTit}, Saldo: $ {_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
