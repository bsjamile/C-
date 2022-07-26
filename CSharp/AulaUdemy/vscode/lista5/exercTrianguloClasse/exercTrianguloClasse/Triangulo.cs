using System;

namespace exercTrianguloClasse
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); 
        }
        public void Maior(double AreaX, double AreaY)
        {
            if (AreaX > AreaY)
                Console.WriteLine("Maior área: X");
            else
                Console.WriteLine("Maior área: Y");
        }
    }
}
