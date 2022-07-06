using System.Globalization;

namespace exerc20
{
    class program
    {
        static void Main(string[] args)
        {
            Producao prod = new Producao();

            Console.Write("Qtd de Blusas: ");
            int qtdBlusa = int.Parse(Console.ReadLine());

            Console.Write("Qtd de Novelos: ");
            int qtdNovelo= int.Parse(Console.ReadLine());

            Console.WriteLine($"Qtd de Novelo/Blusa : {prod.QtdNovelo(qtdBlusa, qtdNovelo)}");
        }
    }
}