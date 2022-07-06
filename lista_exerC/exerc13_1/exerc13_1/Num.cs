using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc13_1
{
    internal class Num
    {
        public void RetornoNumber(string numero)
        {
            int i = 0;
            while (i < numero.Length)
            {
                if (i == 0)
                {
                    Console.WriteLine($" CENTENA = {numero[i]}");
                }
                else if (i == 1)
                {
                    Console.WriteLine($" DEZENA = {numero[i]}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($" UNIDADE = {numero[i]}");
                }
                i++;
            }
        }
    }
}
