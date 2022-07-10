using System.Globalization;

Console.Write("Quantos números? ");
int.TryParse(Console.ReadLine(), out int n);

for (int i = 0; i <= n; i++)
{
    string[] line = Console.ReadLine().Split(' ');
    int x = int.Parse(line[0]);
    int y = int.Parse(line[1]);

    if(y == 0)
    {
        Console.WriteLine("divisão impossível");
    }
    else
    {
        double div = (double)x/y;
        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
    }
}
