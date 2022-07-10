using System.Globalization;

double preco_mcflurry = 10;
double preco_mcfritas = 5;
double preco_bigmac = 15;

double total = 0;
CultureInfo pt = new CultureInfo("pt-BR");

Console.Write("Digite o seu nome:");
var nome = Console.ReadLine();

Console.Write("Quantos McFlurries? ");
int.TryParse(Console.ReadLine(), out int qtd_mcflurry);

Console.Write("Quantas McFritas? ");
int.TryParse(Console.ReadLine(), out int qtd_mcfritas);

Console.Write("Quantos BigMacs? ");
int.TryParse(Console.ReadLine(), out int qtd_bigmac);

total = (preco_mcflurry * qtd_mcflurry) + (preco_mcfritas * qtd_mcfritas) + (preco_bigmac * qtd_bigmac);

Console.WriteLine($"Olá, {nome}! O valor total é de {total.ToString("c", pt)}.");
Console.WriteLine("Você vai pagar em dinheiro? s/n");
var resp = Console.ReadLine();

char respChar= resp[0];

if (respChar == 'n' || respChar == 'N')
{
    Console.WriteLine($"Ok, {nome} retire na próxima cabine");
}
else if (respChar == 's' || respChar == 'S')
{
    Console.Write($"Digite o valor: ");
    double.TryParse(Console.ReadLine(), out double valor);

    double valorDoTroco = valor - total;

    if (valorDoTroco > 0)
    {
        Console.WriteLine($"Ok, esse é o seu troco {valorDoTroco}, retire na próxima cabine!");
    }
    else
    {
        valorDoTroco = -(valorDoTroco);
        Console.WriteLine($"Está faltando {valorDoTroco} reais.");
        Console.WriteLine("Complete o valor para finalizar o seu pedido.");
    }   
}

