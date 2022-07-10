int.TryParse(Console.ReadLine(), out int opcao);

int alcool = 0, gasolina = 0, diesel = 0;

while (opcao != 4)
{
    if (opcao == 1)
    {
        alcool++;
    }
    else if (opcao == 2)
    {
        gasolina++;
    }
    else if (opcao == 3)
    {
        diesel++;
    }

    Console.WriteLine("MUITO OBRIGADO");
    Console.WriteLine($"Alcool: {alcool}");
    Console.WriteLine($"Gasolina: {gasolina}");
    Console.WriteLine($"Diesel: {diesel}");
    int.TryParse(Console.ReadLine(), out opcao);
}


