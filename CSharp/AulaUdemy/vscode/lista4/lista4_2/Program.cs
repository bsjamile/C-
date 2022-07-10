Console.WriteLine("Digite um número: ");
int.TryParse(Console.ReadLine(), out int num);

int fator = 1;

for (int i = 1; i <= num; i++)
{
    fator = fator * i;
}
Console.WriteLine($"Fatorial:{fator}");