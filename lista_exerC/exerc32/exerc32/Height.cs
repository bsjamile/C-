using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc32
{
    internal class Weight
    {
        public void CalcPeso(double pesoK)
        {
            Console.WriteLine();
            double pesoG = pesoK * 1000;
            Console.WriteLine($"Peso em gramas: {pesoG.ToString("F0", CultureInfo.InvariantCulture)}");
        }
    }
}
