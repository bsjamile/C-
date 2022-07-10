using System;

namespace triang_obj
{
    class Triangulo
    {
        public double A;//Public = posso acessar esse atributo pelo programa principal, por ex.
        public double B;
        public double C;

        public double Area() // não vai ter nenhum parametro de entrada por só precisar do A, B e C que já foi definido
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //return raiz; ou o jeito de cima
        }
    }
}
