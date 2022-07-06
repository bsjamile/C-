using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc15
{
    internal class Conta
    {
        public void DivisaoConta(double conta)
        {
            int valorCarlos = (int)conta / 3;
            int valorAndre = (int)conta / 3;
            double valorFelipe = conta - valorCarlos - valorAndre;

            Console.WriteLine($"Carlos: R$ {valorCarlos.ToString("F2", CultureInfo.InvariantCulture)} \nAndré: R$ {valorAndre.ToString("F2", CultureInfo.InvariantCulture)} \nFelipe: R$ {valorFelipe.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
