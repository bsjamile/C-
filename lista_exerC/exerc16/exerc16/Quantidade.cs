using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc16
{
    class Quantidade
    {
        public void CalcQtd(double qtd)
        {
            double queijo = 0.1 * qtd;
            double presunto = 0.05 * qtd;
            double hamb = 0.1 * qtd;

            Console.WriteLine($"Qtd queijo: {queijo.ToString("F3", CultureInfo.InvariantCulture)} kg \nQtd presunto: {presunto.ToString("F3", CultureInfo.InvariantCulture)} kg \nQtd Rodela hamb: {hamb.ToString("F3", CultureInfo.InvariantCulture)} kg");
        }
    }
}
