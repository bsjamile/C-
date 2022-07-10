Console.WriteLine("Digite três números:");
int.TryParse(Console.ReadLine(), out int n1);
int.TryParse(Console.ReadLine(), out int n2);
int.TryParse(Console.ReadLine(), out int n3);

int resultado = Maior(n1, n2, n3);

int resultado2 = Maior(3, 7, 4);

Console.WriteLine("Maior1 = " + resultado);
Console.WriteLine("3,7,4 --- Maior2: " + resultado2);

static int Maior(int a, int b, int c)
{
    int m;
    if (a > b && a > c)
  {
    m = a;
}
  else if (b > c)
{
    m = b;
}
else
{
    m = c;
}
return m;
}