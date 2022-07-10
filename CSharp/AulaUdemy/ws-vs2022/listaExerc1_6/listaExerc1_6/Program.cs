using System.Globalization;

float a, b, c;
double areaTriang, areaC, areaTrap, areaQ, areaR;

for(int i = 1; i < 3; i++)
{
    Console.WriteLine("Digite o valor de a: ");
    a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Digite o valor de b: ");
    b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Digite o valor de c: ");
    c = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    areaTriang = (a * c) / 2;
    areaC = 3.14159 * Math.Pow(c, 2);
    areaTrap = ((a + b) * c) / 2;
    areaQ = Math.Pow(b, 2);
    areaR = a * b;

    Console.WriteLine();
    Console.WriteLine($"TRIANGULO {i}: {areaTriang.ToString("F3", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"CIRCULO {i}: {areaC.ToString("F3", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"TRAPEZIO {i}: {areaTrap.ToString("F3", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"QUADRADO {i}: {areaQ.ToString("F3", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"RETANGULO {i}: {areaR.ToString("F3", CultureInfo.InvariantCulture)}");
    Console.WriteLine();
}


