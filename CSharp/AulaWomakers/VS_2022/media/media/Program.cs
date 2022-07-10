Console.Write("Quantos números?: ");
int.TryParse(Console.ReadLine(), out int qtd);

Console.WriteLine($"Digite os {qtd} números: ");

int i;
double result = 0, maior = 0, menor = 0;

for (i = 0; i < qtd; i++)
{
    double soma = int.Parse(Console.ReadLine());

    if (i == 0)
    {
        maior = soma;
        menor = soma;
    } 
    else{
        if(soma > maior)
        {
            maior = soma;
        }
        if (soma < menor)
        {
            menor = soma;
        }
    }

    result += soma;
}

Console.WriteLine($"A média é: { result / i}");
Console.WriteLine($"O maior elemento é: {maior}");
Console.WriteLine($"O menor elemento é: {menor}");
