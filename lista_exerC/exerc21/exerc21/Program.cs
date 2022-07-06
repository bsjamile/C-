using System.Globalization;

namespace exerc21
{
    class program
    {
        static void Main(string[] args)
        {
            Refrigerante refri = new Refrigerante();

            Console.Write("Qtd lata: ");
            int lata = int.Parse(Console.ReadLine());
            Console.Write("Qtd Garrafa 600ml: ");
            int garrafaUm = int.Parse(Console.ReadLine());
            Console.Write("Qtd Garrafa 2L: ");
            int garrafaDois = int.Parse(Console.ReadLine());

            refri.QtdCoca(lata, garrafaUm, garrafaDois);
        }
    }
}