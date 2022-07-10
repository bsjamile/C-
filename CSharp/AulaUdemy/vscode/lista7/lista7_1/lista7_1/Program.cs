using System;
using System.Globalization;

namespace lista7_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo q = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retângulo");
            q.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            q.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(q);
        }
    }
}
