using System;
using System.Globalization;

namespace aula5horas
{
    class program
    {

        enum Cor {Azul, Verde, Amarelo, Vermelho};

        static void Main(string[] ags)
        {
            // See https://aka.ms/new-console-template for more information
            /*Console.Write("Digite um número inteiro: ");
            var azul = int.Parse(Console.ReadLine());
            Console.WriteLine(azul);

            dynamic cor = "Vemelho";
            Console.WriteLine(cor);
            cor = 'V';
            Console.WriteLine(cor);

            const int naoMuda = 10;
            Console.WriteLine(naoMuda);

            naoMuda = 50;

            if (1 < 20 && 20 != 20)
                Console.WriteLine("É Verdade!");
            else if (20 == 20)
                Console.WriteLine("Executou elseif!");
            else
                Console.WriteLine("É Mentira!");
            
            Console.Write("Digite o preço: R$");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a qtd: ");
            int quant = int.Parse(Console.ReadLine());
            GerarTotal(valor, quant);

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            GerarPreco(preco);
            Console.Write("Quantidade: ");
            int quant = int.Parse(Console.ReadLine());
            GerarTotal(nome, preco, quant);
            GerarPreco(-60);
            GerarTotal("Cama", -100f, -10);

            int sum1 = Somar(10, 20, 30);
            int sum2 = Somar(100, 200, 300);
            int sum3 = Somar(1000, 2000, 3000);

            Console.WriteLine(Somar(1, 2, 3));
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            Produtos();

            Console.Write("Nome da cor: ");
            string corUP = Console.ReadLine();

            string cor = corUP.ToUpper();

            switch (cor) // O switch só realiza operação de igualdade
            {
                case "VERMELHO":
                    Console.WriteLine("Sua cor favorita é vemelho!");
                    break;
                case "AMARELO":
                    Console.WriteLine("Sua cor favorita é amarelo!");
                    break;
                case "AZUL":
                    Console.WriteLine("Sua cor favorita é azul!");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita não é nem vermelho, nem amarelo e nem azul!");
                    break;
            }*/

            Console.WriteLine((Cor)2);

            Cor corFavorita = Cor.Azul;
            Console.WriteLine((int)corFavorita);

            Cor corFavoritaDaGabi = Cor.Verde;
            Console.WriteLine(corFavoritaDaGabi);
            
        }
        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo(a)!");
            Console.WriteLine("Show de Bola!");
            Console.WriteLine("Jamile Barroso!");
        }

        static void GerarPreco(float price)
        {
            float priceAbs = Math.Abs(price);
            Console.WriteLine($"Preço: R${priceAbs.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static void GerarTotal(string nomeP, float preco, int qtd)
        {
            float precoAbs = Math.Abs(preco);
            int qtdAbs = Math.Abs(qtd);
            Console.WriteLine($"O Valor total de {nomeP} é: R${(precoAbs * qtdAbs).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static int Somar(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
        }

        static void Produtos()
        {
            Console.Write("Qntd produtos: ");
            int num = int.Parse(Console.ReadLine());
            
            string[] produtos = new string[num];

            for (int i = 0; i < num; i++)
            {               
                Console.Write("Nome do produto: ");
                produtos[i] = Console.ReadLine();
            }

            produtos[0] = "JAMILE";

            foreach(string produto in produtos)
            {
                Console.WriteLine(produto);
            }
            int[] valores = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("DigiteInt: ");
                valores[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(valores[i]);
            }
            foreach(int n in valores)
            {
                Console.WriteLine(n);
            }
        }
    }
}


