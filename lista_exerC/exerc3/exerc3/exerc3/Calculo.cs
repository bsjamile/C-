using System;
using System.Globalization;

namespace exerc3
{
    class Calculo
    {
        public double VendaTotal(int qtdPao, int qtdBroa)
        {
            return ((0.12 * qtdPao) + (1.5 * qtdBroa));
        }

        public double QtdPoupar(int qtdPao, int qtdBroa)
        {
            return 0.1 * ((0.12 * qtdPao) + (1.5 * qtdBroa));
        }

    }
}
