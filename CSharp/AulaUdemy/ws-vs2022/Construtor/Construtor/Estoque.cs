using System.Globalization;
namespace Construtor
{
    public class Estoque
    {
        private string _nome; //nao usa autoproperty por ter ma regra de negócio especófoca
        public double Preco { get; private set; } //preço nao pode ser alterado por outros arquivos
        public int Quantidade { get; private set; }

        public Estoque()
        {
            Quantidade = 10;
        }

        public Estoque(string nome, double preco) : this() //Executa tbm o construtor padrão dessa classe
            //O padrão é em minúsculo
        {
            this._nome = nome;
            Preco = preco;
        }

        public Estoque(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }

            set {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

  
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {           
                    
        }

        public double GetPreco()
        {
            return Preco;
        }

        public int GetQuantidade()
        {
            return Quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}