string[] pontos = Console.ReadLine().Split(' ');
double.TryParse(pontos[0], out double x);
double.TryParse(pontos[1], out double y);

while(x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("segundo");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("terceiro");
    }
    else
    {
        Console.WriteLine("quarto");
    }

    pontos = Console.ReadLine().Split(' ');
    double.TryParse(pontos[0], out x);
    double.TryParse(pontos[1], out y);
}
