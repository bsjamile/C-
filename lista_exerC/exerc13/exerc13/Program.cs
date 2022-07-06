using System;

namespace exerc13
{
    class program
    {
        static void Main(string[] args)
        {
            Numero n = new Numero();

            Console.Write("Digite um número: ");
            int minhaPalavra = int.Parse(Console.ReadLine());

            n.RetornoNumber(minhaPalavra);
        }
    }
}