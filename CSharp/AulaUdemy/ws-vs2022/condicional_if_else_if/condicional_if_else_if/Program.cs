int hora, vezes;

Console.WriteLine("Quantas vezes vc quer testar?");
vezes = int.Parse(Console.ReadLine());

for (int i = 0; i < vezes; i++)
{
    Console.WriteLine();
    Console.WriteLine("Qual a hora atual?");
    hora = int.Parse(Console.ReadLine());

    if (hora < 12)
    {
        Console.WriteLine("Bom dia!");
    }
    else if (hora < 18)
    {

        Console.WriteLine("Boa tarde!");
    }
    else
    {
        Console.WriteLine("Boa noite!");
    }
}
