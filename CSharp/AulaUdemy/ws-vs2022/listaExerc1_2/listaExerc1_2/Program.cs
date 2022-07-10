//Lista 1 - Estrutura Sequencial - Exercício 2
using System.Globalization;
double area, raio;

for(int i = 0; i <= 3; i++)
{
    Console.WriteLine("Digite o raio do círculo: ");
    raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    area = Math.Pow(raio, 2) * 3.14159;

    Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
}




