using System.Globalization;

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] s = Console.ReadLine().Split(' ');
string nome = s[0];
char sexo = char.Parse(s[1]);
int idade = int.Parse(s[2]);
double alt = double.Parse(s[3], CultureInfo.InvariantCulture);

Console.WriteLine($"Você digitou: {n1}");
Console.WriteLine($"Você digitou: {ch}");
Console.WriteLine($"Você digitou: {n2.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine(sexo);
Console.WriteLine(alt.ToString("F2", CultureInfo.InvariantCulture));

