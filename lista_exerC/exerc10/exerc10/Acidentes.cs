using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc10
{
    class Acidentes
    {

       public void qtdAcidentes(int dia)
        {

            int mes = 0;
            int ano = 0;

            while (dia >= 30)
            {
                dia = dia - 30;
                mes = mes + 1;
                if (mes % 12 == 0 && mes != 0)
                {
                    ano++;
                    mes = 0;
                }
            }

            if (dia < 0)
                Console.WriteLine("Digite um dia válido!");
            else
                Console.WriteLine($"{dia} dia(s), {mes} mese(s), {ano} ano(s)");
        }
    }
}
