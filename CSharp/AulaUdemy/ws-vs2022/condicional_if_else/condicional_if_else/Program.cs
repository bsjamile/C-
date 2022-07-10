int n;

Console.WriteLine("Digite a quantidade de números: ");
int m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    Console.WriteLine("Entre com um número inteiro: ");
    n = int.Parse(Console.ReadLine());

    if (n % 2 == 0)
    {
        Console.WriteLine("Par!");
    }
    else
    {
        Console.WriteLine("Ímpar!");
    }

    Console.WriteLine();
}



