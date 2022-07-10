int a, b, c;
double delta;
double raizDelta;
double primeiraRaiz;
double segundaRaiz;

Console.WriteLine("Digite o Valor de A");
int.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Digite o Valor de B");
int.TryParse(Console.ReadLine(), out b);

Console.WriteLine("Digite o Valor de C");
int.TryParse(Console.ReadLine(), out c);

delta = Math.Pow(b, 2) -(4 * a * c);
raizDelta= Math.Sqrt(delta);
primeiraRaiz= (-b + raizDelta) / (2 * a);
segundaRaiz= (-b -raizDelta) / (2 * a);

Console.WriteLine($"primeira raiz {primeiraRaiz.ToString("F2")} ; segunda raiz {segundaRaiz.ToString("F2")}");