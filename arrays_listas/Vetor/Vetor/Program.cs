using System.Globalization;

double sumAlt = 0;

Console.Write("Qtd de pessoas: ");
int.TryParse(Console.ReadLine(), out int qtd);

for(int i = 0; i < qtd; i++)
{
Console.Write("Altura: ");
double alt = double.Parse(Console.ReadLine());

sumAlt = sumAlt + alt;
}

double avarage = sumAlt / qtd;

Console.WriteLine($"AVARAGE HEIGHT = {avarage.ToString("F2", CultureInfo.InvariantCulture)}");
