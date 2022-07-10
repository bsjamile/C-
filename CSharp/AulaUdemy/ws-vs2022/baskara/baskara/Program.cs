double a = 1.0d, b = -3.0d, c = -4.0d;

double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

Console.WriteLine($"delta = {delta}");
Console.WriteLine($"x1 = {x1}");
Console.WriteLine($"x2 = {x2}");


