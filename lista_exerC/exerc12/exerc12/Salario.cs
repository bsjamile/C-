using System;
using System.Globalization;

namespace exerc12
{
    internal class Salario
    {
        public void SalarioAumento(double SalarioI)
        {
            double SalarioAum;
            double SalarioF;

            SalarioAum = SalarioI * 1.15;
            SalarioF = SalarioAum * 0.92;

            Console.WriteLine($"Salário Inicial: R$ {SalarioI.ToString("F2", CultureInfo.InvariantCulture)} \nSalário com Aumento: R$ {SalarioAum.ToString("F2", CultureInfo.InvariantCulture)} \nSalário Final: R$ {SalarioF.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
