using System;
using System.Globalization;

namespace Construtor
{
    public class Program
    {
        public static void Main(string[] args)
        {           
            Estoque estoq = new Estoque("TV", 500.00, 10);

            estoq.SetNome("T");

            estoq.Nome = "T";
            Console.WriteLine(estoq.Nome);
            Console.WriteLine(estoq.Quantidade);
            Console.WriteLine(estoq.Preco);
            Console.WriteLine(estoq.GetPreco());
            Console.WriteLine(estoq.GetQuantidade());


        }

        public static void Programa()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Estoque estoque = new Estoque(nome, preco);

            Estoque ee = new Estoque();
            /*
            Estoque p = new Estoque
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };*/

            Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);

            Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

        }
    }
}