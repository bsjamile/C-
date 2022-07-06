using System;

namespace exerc9
{
    internal class Camisas
    {
        public int p;
        public int m;
        public int g;

        public int Total(int p, int m, int g)
        {
            return p*10 + m*12 + g*15;
        }
    }
}
