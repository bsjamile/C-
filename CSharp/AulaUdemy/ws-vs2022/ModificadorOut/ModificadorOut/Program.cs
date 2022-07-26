namespace ModificadorOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            ModifOut.Triple(a, out triple);
            Console.WriteLine(triple);
            //Tanto ref quanto out são code smells e deve ser evitado
        }
    }
}