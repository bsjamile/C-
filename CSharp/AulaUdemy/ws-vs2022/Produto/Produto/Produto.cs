using System.Globalization;

namespace Produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public Produto()
        {
            Quantidade = 100;
        }

        //Construtor obriga o programador a informar os valores dos atributos
        //quando a classe é instanciada == o construtor tem o mesmo nome da Classe
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
            //O this traz a quantidade do outro construtor
        }

        public Produto(string nome, double preco, int quantidade) : this(nome,preco)
        {
           //O this tá dizendo que vai reaproveitar o construtor de 2 argumentos
            Quantidade = quantidade; //O padrão do programa já é atribuir 0
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade; //Quantidade + quantidade

        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade; //Quantidade - quantidade
        }

        public override string ToString() //override é uma sobreposicao
        {
            return $"{Nome}, " +
                $"$ {(Preco).ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Quantidade} unidades, " +
                $"Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
