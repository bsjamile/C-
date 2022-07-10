using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);*/

            Produto p;

            p = new Produto(nome, preco);

            Produto p2 = new Produto(); // Aceita o vazio por causa do Construtor sem valor

            Produto p3 = new Produto//Também é uma formaa de instanciar o produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine();
            Console.Write($"Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine();
            Console.Write($"Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}