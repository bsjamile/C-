using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc25
{
    internal class Multiplicacao
    {
        public string Mult(double num1, double num2, double num3)
        {
            return (num1 * num2 * num3).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
