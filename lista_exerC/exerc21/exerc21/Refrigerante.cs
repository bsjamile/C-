using System;
using System.Globalization;

namespace exerc21
{
    class Refrigerante
    {
        public void QtdCoca(int lata, int garrafa1, int garrafa2)
        {
            double um = 0.35 * lata;
            double dois = 0.6 * garrafa1;
            double tres = 2 * garrafa2;

            Console.WriteLine($"{(um + dois + tres).ToString("F2", CultureInfo.InvariantCulture)} litros"); 
        }
    }
}
