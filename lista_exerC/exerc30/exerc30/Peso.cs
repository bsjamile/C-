using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc30
{
    internal class Peso
    {
        public void CalcPeso(double peso)
        {
            Console.WriteLine();
            double pesoEngor = peso * 1.15;
            Console.WriteLine($"Se engordar 15%: { pesoEngor.ToString("F2", CultureInfo.InvariantCulture)}");
            double pesoEmag = peso * 0.8;
            Console.WriteLine($"Se emagrecer 20%: {pesoEmag.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
