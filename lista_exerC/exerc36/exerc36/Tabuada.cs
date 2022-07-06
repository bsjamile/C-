using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc36
{
    internal class Tabuada
    {
        public void CalcTab(double num, int num2)
        {
            for (int i = 0; i <= num2; i++)
            {
                double num3 = num * i;
                Console.WriteLine($"{num} x {i} = {num3}");
            }
        }
    }
}
