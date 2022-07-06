using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc26
{
    internal class Divisao
    {
        public string CalcDiv(double num1, double num2)
        {
            return (num1 / num2).ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
