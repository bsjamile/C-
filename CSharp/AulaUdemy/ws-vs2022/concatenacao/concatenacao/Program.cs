using System.Globalization;

int idade = 32;
double saldo = 10.35784d;
string nome = "Maria";

Console.WriteLine($"{nome} tem {idade} anos e tem R${saldo.ToString("F2", CultureInfo.InvariantCulture)} na conta!");
Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais!", nome, idade, saldo);
Console.WriteLine($"{nome} tem {idade} anos e tem R${saldo:F2} na conta!");
Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais!");