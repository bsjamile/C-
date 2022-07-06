using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc18
{
    internal class Salario
    {
        public void CalcSal(double horasT, double horasE)
        {
            double pagT = horasT * 10;
            double pagE = horasE * 15;
            double salB = pagT + pagE;
            double salL = salB * 0.9;

            Console.WriteLine($"Salário Bruto: R${salB.ToString("F2", CultureInfo.InvariantCulture)}\nSalário Líquido: R${salL.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
