Console.Write("Quantos números inteiros vc vai digitar? ");
int.TryParse(Console.ReadLine(), out int number);

int n = 0;

for (int i = 1; i <= number; i++)
{
    Console.Write($"Valor #{i}: ");
    int.TryParse(Console.ReadLine(), out int valor);

    n = n + valor;
}
Console.WriteLine($"Soma = {n}");