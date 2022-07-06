using System;
using System.Globalization;

namespace exerc3
{
    class program
    {
        static void Main(string[] args)
        {
            Calculo c = new Calculo();

            Console.Write("Qtd pães: ");
            int qtdPao = int.Parse(Console.ReadLine());
            Console.Write("Qtd broas: ");
            int.TryParse(Console.ReadLine(), out int qtdBroa);

            Console.WriteLine($"O valor total da venda: R${c.VendaTotal(qtdPao, qtdBroa).ToString(CultureInfo.InvariantCulture)}\nValor a poupar: R${c.QtdPoupar(qtdPao,qtdBroa).ToString(CultureInfo.InvariantCulture)}");


        }
    }
}