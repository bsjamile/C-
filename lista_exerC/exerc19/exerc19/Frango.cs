using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc19
{
    internal class Frango
    {
        public string TotalAnel(int frango)
        {
            double anelChip = 4 * frango;
            double anelAlimento = 3.5 * 2 * frango;

            return (anelChip + anelAlimento).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
