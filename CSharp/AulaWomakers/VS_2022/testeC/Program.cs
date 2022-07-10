// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

uint ui = 100;
float fl = 10.2f; //float sempre com f
long l = 45755452222222;
ulong ul = 45755452222222;
double d = 11452222.555;
decimal mon = 1000.15m; //decimal sempre com m
string meuNome = "Jamile"; //string aspas duplas
char primeiraLetraDoMeuNome = 'J'; //char aspas simples
Console.WriteLine(ui);
Console.WriteLine(fl);
Console.WriteLine(l);
Console.WriteLine(ul);
Console.WriteLine(d);
Console.WriteLine(mon);
Console.WriteLine(meuNome);
Console.WriteLine(primeiraLetraDoMeuNome);

double a = 10.555;
int b = (int)a;
Console.WriteLine(b);

string inteiroPossivel = "1234";
int cont = Convert.ToInt32(inteiroPossivel);
Console.WriteLine(cont);

int numero = 0;
string numeroString = "1234";
Console.WriteLine(int.TryParse(numeroString, out numero));
Console.WriteLine(numero);

string x = Console.ReadLine();
string y = Console.ReadLine();

int contX = Convert.ToInt32(x);
int contY = Convert.ToInt32(y);

//int c = Convert.ToInt32(x) + Convert.ToInt32(y);

int z = contX + contY;

// int xConvertido, yConvertido;
// int.tryParse(x, out xConvertido);
//int.tryParse(y, out yConvertido);
// int c = xConvertido + yConvertido

Console.WriteLine(z);


