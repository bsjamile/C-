Console.Write("Qtd de Num Inteiros: ");
int.TryParse(Console.ReadLine(), out int qtd);

int cont1 = 0, cont2 = 0;

for (int i = 0; i < qtd; i++)
{

    Console.Write("Num Int: ");
    int.TryParse(Console.ReadLine(), out int num);

    if (num >= 10 && num <= 20)
    {
        cont1++;
    }
    else
    {
        cont2++;
    }

}
Console.WriteLine($"{cont1} in");
Console.WriteLine($"{cont2} out");