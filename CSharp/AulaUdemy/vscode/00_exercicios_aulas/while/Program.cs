using System;
using System.Globalization;
Console.Write("Digite um número: ");
double.TryParse(Console.ReadLine(), NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out double number);
while (number >= 0.0)
{
    double raiz = Math.Sqrt(number);
    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
    Console.Write("Digite outro número: ");
    double.TryParse(Console.ReadLine(), NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out number);
}
Console.WriteLine("Número negativo!");