using System.Globalization;

namespace VetorClass
{
    class Produto
    {
        public string Nome { get; set; }        
        public double Preco {get; set;}


        public double Media(double sumPreco, int qtd)
        {
            return sumPreco / qtd;
        }
    }
}
