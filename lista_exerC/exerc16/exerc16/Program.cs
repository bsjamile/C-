using System.Globalization;

namespace exerc16
{
    class program
    {
        static void Main(string[] args)
        {
            Quantidade q = new Quantidade();

            Console.Write("Qtd de Sanduíches: ");
            int qtd = int.Parse(Console.ReadLine());

            q.CalcQtd(qtd);
        }
    }
}
