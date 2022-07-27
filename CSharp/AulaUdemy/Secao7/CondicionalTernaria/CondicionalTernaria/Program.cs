using System.Globalization;

namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma condição.
            * 
            * Sintaxe:
            *  (condicao) ? valor_se_verdadeiro : valor_se_falso
            */

            int x = (2 > 4) ? 50 : 80;

            Console.WriteLine(x);

            string nome = (10 != 3) ? "Maria" : "Alex";

            Console.WriteLine(nome);

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;
            if (preco < 20.0)
                desconto = preco * 0.1;
            else
                desconto = preco * 0.05;

            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));

            double d = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(d.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


