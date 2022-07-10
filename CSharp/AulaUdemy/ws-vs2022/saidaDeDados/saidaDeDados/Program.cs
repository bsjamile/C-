using System.Globalization; //Para usar o CultureInfo.InvariantCulture
                            //e usar . ao invés de ,

char genero = 'F';
int idade = 32;
double saldo = 10.3575754548d;
string nome = "Maria";
float pi = 3.1458786654f; 

Console.Write("Bom dia! ");
Console.WriteLine("Boa tarde!");
Console.WriteLine("Boa noite!");
Console.WriteLine("---------------------");
Console.WriteLine(genero);
Console.WriteLine(idade);
Console.WriteLine(saldo);
Console.WriteLine(nome);
Console.WriteLine(saldo.ToString("F2")); // double para string e arredondar
Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(pi.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(pi.ToString("F4", CultureInfo.InvariantCulture));

