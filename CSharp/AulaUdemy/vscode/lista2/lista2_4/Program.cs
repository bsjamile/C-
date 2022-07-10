Console.WriteLine("Quantos números deseja digitar?");
int.TryParse(Console.ReadLine(), out int n);

for (int i = 0; i < n; i++)
{

    int tempo1;

    Console.WriteLine("Hora Início: ");
    int.TryParse(Console.ReadLine(), out int x);

    Console.WriteLine("Hora Fim: ");
    int.TryParse(Console.ReadLine(), out int y);

    if (x < y)
    {
        tempo1 = y - x;
    }
    else
    {
        tempo1 = 24 - x + y;
    }
    Console.WriteLine($"O JOGO DUROU {tempo1} HORA(S)");
}
