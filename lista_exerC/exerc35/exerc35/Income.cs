using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc35
{
    internal class Income
    {
        public void CalcSal(double salMin, double salF)
        {
            Console.WriteLine();
            double porcentSal = salF / salMin;
            Console.WriteLine($"O funcionário recebe {porcentSal.ToString("F2", CultureInfo.InvariantCulture)} Salários Mínimos");
        }
    }
}
