using System.Globalization;

Console.Write("Qtd de Triangulos: ");
int.TryParse(Console.ReadLine(), out int qtd);

for (int i = 0; i < qtd; i++)
{

    double lA, lB, lC, dA, dB, dC, aL, aD, p;

    Console.WriteLine("Entre com as medidas do triângulo L:");
    double.TryParse(Console.ReadLine(), out lA);
    double.TryParse(Console.ReadLine(), out lB);
    double.TryParse(Console.ReadLine(), out lC);

    Console.WriteLine("Entre com as medidas do triângulo D:");
    double.TryParse(Console.ReadLine(), out dA);
    double.TryParse(Console.ReadLine(), out dB);
    double.TryParse(Console.ReadLine(), out dC);

    p = (lA + lB + lC) / 2.0;
    aL = Math.Sqrt(p * (p - lA) * (p - lB) * (p - lC));

    p = (dA + dB + dC) / 2.0;
    aD = Math.Sqrt(p * (p - dA) * (p - dB) * (p - dC));

    Console.WriteLine($"Área de L = " + aL.ToString("F4", CultureInfo.InvariantCulture));
    Console.WriteLine($"Área de D = " + aD.ToString("F4", CultureInfo.InvariantCulture));

    string maior;

    if (aL > aD)
    {
        maior = "L";
    }
    else if (aD > aL)
    {
        maior = "D";
    }
    else
    {
        maior = "L = D";
    }

    Console.WriteLine($"Maior área: {maior}");
}