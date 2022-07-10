//Exercício Proposto
using System.Globalization;

Console.WriteLine("Entre com seu nome completo:");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com um preço de um produto: ");
double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
string[] xis = Console.ReadLine().Split(' ');
string ultimoNome = xis[0];
int idade = int.Parse(xis[1]);
double altura = double.Parse(xis[2],CultureInfo.InvariantCulture);


Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

