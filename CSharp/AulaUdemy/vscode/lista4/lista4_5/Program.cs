/*
Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5.
*/

using System.Globalization;

Console.Write("Número de casos: ");
int.TryParse(Console.ReadLine(), out int n);

for (int i = 0; i < n; i++)
{
    string[] caso = Console.ReadLine().Split(' ');
    double.TryParse((caso[0]), out double c1);
    double.TryParse((caso[1]), out double c2);
    double.TryParse((caso[2]), out double c3);

    double media = (((c1 * 2) + (c2 * 3) + (c3 * 5)) / 10);
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));