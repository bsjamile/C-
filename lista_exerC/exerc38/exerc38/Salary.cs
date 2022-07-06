using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc38
{
    internal class Salary
    {
        public string CalcSalary(double income)
        {
            Console.WriteLine();
            double payments = income - (200 + 120) * 1.02;
            return payments.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
