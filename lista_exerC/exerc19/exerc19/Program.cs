using System.Globalization;

namespace exerc19
{
    class program
    {
        static void Main(string[] args)
        {
            Frango f = new Frango();

            Console.Write("Qtd de frangos: ");
            int qtdFrango = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total R$ {f.TotalAnel(qtdFrango)}"); 
        }
    }
}