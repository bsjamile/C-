using System.Globalization;

double a, b, c, d;

a = 2;
b = 3;
c = 4;
d = 5;

Console.WriteLine($"O valor máximo entre {a} e {b} é {Math.Max(a, b)}"); //maiorvalor entre doisnúmeros
Console.WriteLine($"O valor mínimo entre {a} e {b} é {Math.Min(a, b)}"); //menorvalor entre doisnúmeros
Console.WriteLine($"A raiz quadrada de {a} é {Math.Sqrt(a).ToString("F2", CultureInfo.InvariantCulture)}"); //raizquadradade a
Console.WriteLine($"{c} elevado a {d} é {Math.Pow(c, d)}"); // c elevadoa d
