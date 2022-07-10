using System;
using System.Globalization;

namespace lista7_2
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }

        public override string ToString()
        {
            return $"{Nome}," +
                $" $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
       
    }
}



