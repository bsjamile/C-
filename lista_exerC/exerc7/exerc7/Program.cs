using System;

namespace exerc7
{
    class program
    {
        static void Main(string[] args)
        {
            Dias d = new Dias();

            Console.Write("Digite o dia e o mes: ");
            string[] data = Console.ReadLine().Split('/');

            int dia = int.Parse(data[0]);
            int mes = int.Parse(data[1]);

            Console.WriteLine($"{d.QtdDias(dia, mes)} dias"); 
        }
    }
    
}


