using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc10
{
    class Ac
    {

        public void qtdAcidentes(int dia)
        {
            int anos = dia / 360;
            dia -= anos * 360;
            int mes = dia / 30;
            dia -= mes * 30;

            Console.WriteLine($"{dia} dia(s), {mes} mese(s), {anos} ano(s)");
        }
    }
}
