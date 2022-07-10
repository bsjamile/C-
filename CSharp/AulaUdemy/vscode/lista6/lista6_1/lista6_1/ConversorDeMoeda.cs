using System;
using System.Globalization;

namespace lista6_1
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double ConverterMoeda(double cotacao, double valorCompra)
        {
            double total = valorCompra * cotacao;
            return total + total * Iof / 100;
        }
    }
}
