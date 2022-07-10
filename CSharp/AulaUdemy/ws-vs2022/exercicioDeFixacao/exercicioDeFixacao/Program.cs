using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0d;
double preco2 = 650.50d;
double medida = 53.234567d;

Console.WriteLine("Produtos:");
Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
Console.WriteLine();
Console.WriteLine("Registro: {0} anos de idade, código {1} e genero: {2}", idade, codigo, genero);
Console.WriteLine();
Console.WriteLine($"Medida com oitos casa decimais: {medida}");
Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
Console.WriteLine($"Separador decimal invariant culture: {(medida.ToString("F3", CultureInfo.InvariantCulture))}");