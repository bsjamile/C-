using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc17
{
    internal class Temperatura
    {

        public string CalcTemp(double c)
        {
            double f = (c * 1.8 + 32);
            return f.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
