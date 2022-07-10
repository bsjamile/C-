using System.Globalization;

int codigoP1, nP1, codigoP2, nP2;
double vP1, vP2, calculo;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o código, o número de peças e o preço unitário da peça 1 (na mesma linha): ");
    string[] vetP1 = Console.ReadLine().Split(' ');

    Console.WriteLine("Digite o código, o número de peças e o preço unitário da peça 2 (na mesma linha): ");
    string[] vetP2 = Console.ReadLine().Split(' ');

    codigoP1 = int.Parse(vetP1[0]);
    nP1 = int.Parse(vetP1[1]);
    vP1 = double.Parse(vetP1[2], CultureInfo.InvariantCulture);

    codigoP2 = int.Parse(vetP2[0]);
    nP2 = int.Parse(vetP2[1]);
    vP2 = double.Parse(vetP2[2], CultureInfo.InvariantCulture);

    calculo = nP1 * vP1 + nP2 * vP2;

    Console.WriteLine();
    Console.WriteLine($"VALOR A PAGAR: R$ {calculo.ToString("F2", CultureInfo.InvariantCulture)}");
    Console.WriteLine();
}

