using System;
using System.Globalization;

namespace lista8_1_1
{
    class Banco
    {
        public string Resp;
        public char RespCh;
        public double Saldo = 0;
        public int NumConta;
        public string NomeTit;
        public double DepIni;
        public double ValorDep;
        public double ValorSaq;

        public override string ToString()
        {
            return $"Conta {NumConta}, Titular: {NomeTit}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
