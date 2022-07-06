using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc22
{
    internal class Moeda
    {
        public double QtdMoeda(int um, int dois, int tres, int quatro, int cinco, int seis)
        {
            double qtdUm = 0.01 * um;
            double qtdDois = 0.05 * dois;
            double qtdTres = 0.1 * tres;
            double qtdQuatro = 0.25 * quatro;
            double qtdCinco = 0.5 * cinco;
            int qtdSeis = 1 * seis;

            return qtdUm + qtdDois + qtdTres + qtdQuatro + qtdCinco + qtdSeis;
        }
    }
}
