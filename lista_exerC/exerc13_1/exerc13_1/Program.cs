using System;

namespace exerc13_1
{
    class program
    {
        static void Main(string[] args)
        {
            Num n = new Num();

            Console.Write("Digite um número: ");
            var minhaPalavra = Console.ReadLine();

            n.RetornoNumber(minhaPalavra);
        }
    }
}