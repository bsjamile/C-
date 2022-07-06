using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc29
{
    internal class Salario
    {
        public string TotalSalario(double salario, double vendas)
        {
            return (salario + vendas * 0.04).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
