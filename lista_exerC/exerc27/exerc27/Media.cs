using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc27
{
    internal class Media
    {
        public string CalcMedia(double num1, double num2)
        {
            return ((num1 * 2 + num2 * 3) / 5).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
