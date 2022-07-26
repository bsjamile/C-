using System;

namespace ModificadorRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            ModifRef.Triple(ref a);
            Console.WriteLine(a);

        }
    }
}