/*
Console.WriteLine("Digite uma frase legal: ");
var bomdia = Console.ReadLine();

Console.WriteLine("Digite uma cor:");
var x = Console.ReadLine();

Console.WriteLine("Digite outra cor:");
var y = Console.ReadLine();

Console.WriteLine("Digite mais uma outra cor:");
var z = Console.ReadLine();
*/

string frase = Console.ReadLine();
string j = Console.ReadLine();
string m = Console.ReadLine();
string l = Console.ReadLine();

// O Split vai reconhecer cada palavra que
// está separado pelo espaço em branco
//string s = Console.ReadLine();

string[] vet = Console.ReadLine().Split(' ');
string p1 = vet[0];
string p2 = vet[1];
string p3 = vet[2];

Console.WriteLine($"Você digitou: {frase}");
Console.WriteLine($"Você digitou: {j}");
Console.WriteLine($"Você digitou: {m}");
Console.WriteLine($"Você digitou: {l}");
Console.WriteLine($"Você digitou: {p1}, {p2}, {p3}");