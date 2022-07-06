using System.Globalization;

namespace exerc37
{
    class program
    {
        static void Main(string[] args)
        {
            Data dat = new Data();

            Console.Write("Ano de Nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());
            Console.Write("Ano Atual: ");
            int anoAtual = int.Parse(Console.ReadLine());

            dat.CalcNasc(anoNasc, anoAtual);
        }
    }
}