using System;
using System.Globalization;

double sumAlt = 0;

Console.Write("Qtd de pessoas: ");
int.TryParse(Console.ReadLine(), out int qtd);

double[] vect = new double[qtd];

for (int i = 0; i < qtd; i++)
{
    Console.Write("Altura: ");
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    sumAlt += vect[i];
}

double avarage = sumAlt / qtd;

Console.WriteLine($"AVARAGE HEIGHT = {avarage.ToString("F2", CultureInfo.InvariantCulture)}");
