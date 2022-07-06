using System;

namespace exerc13
{
    internal class Numero
    {
        public void RetornoNumber(int numero)
        {
            int centena = numero / 100;
            numero -= centena * 100;
            int dezena = numero / 10;
            numero -= dezena * 10;
            int cent = numero / 1;

            Console.WriteLine($"CENTENA = {centena}");
            Console.WriteLine($"DEZENA = {dezena}");
            Console.WriteLine($"DEZENA = {cent}");
        }
    }
}

