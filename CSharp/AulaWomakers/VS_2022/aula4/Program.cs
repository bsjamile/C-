/* 

var date = new DateTime(2020, 07, 02, 22, 59, 59);
DateTime minhaString = new DateTime();
Console.WriteLine("");
Console.WriteLine(minhaString);

*/

/*
 *
var a = "OlaThays";
try
{    
    Convert.ToInt32(a);
    Console.WriteLine("lalalla");
}
catch (Exception e)
{
    Console.WriteLine("Deu Erro");
    Console.WriteLine(e.ToString());
}

*/

/*
Console.WriteLine("Digite o dia do seu aniversário no formato DD/MM/AAAA");
string dataDeNascimentoStr = Console.ReadLine();
string diaStr = dataDeNascimentoStr.Substring(0, 2);
string mesStr = dataDeNascimentoStr.Substring(3, 2);
string anoStr = dataDeNascimentoStr.Substring(6, 4);

try
{
    short dia = Convert.ToInt16(diaStr);
    short mes = Convert.ToInt16(mesStr);
    short ano = Convert.ToInt16(anoStr);
    var dataDeNascimentoDate = new DateTime(ano, mes, dia);
    Console.WriteLine(dataDeNascimentoDate.DayOfWeek);
} 

catch (Exception e)
{
    Console.WriteLine("Favor digitar a data no formato correto.");
    Console.WriteLine(e.ToString());
} 
*/

/*
int i = 3;
Console.WriteLine(i);
Console.WriteLine(i++);
Console.WriteLine(i);



int j = 4;
Console.WriteLine(j);
Console.WriteLine(++j);
Console.WriteLine(j);

int c = 3;
Console.WriteLine(c);
Console.WriteLine(c--);
Console.WriteLine(c);


int d = 4;
Console.WriteLine(d);
Console.WriteLine(--d);
Console.WriteLine(d);
*/

/*
Console.WriteLine("Digite um número");
var n = (Console.ReadLine());
var nInteiro = Convert.ToInt32(n);
Console.WriteLine($"O Resto da Divisão por 2 é:  {nInteiro % 2}");
*/

/*
int a = 10;
a += 20;
a = a + 20;
Console.WriteLine(a);

int b = 10;
b -= 5;
b = b + 20;
Console.WriteLine(b);

Console.WriteLine(a == b);
Console.WriteLine(!(a == b || a >= b));
Console.WriteLine(a > b);
*/

/*
Console.WriteLine("Digite um número");
var uol = Console.ReadLine();
Console.WriteLine("Digite o segundo númnro");
var uhu = Console.ReadLine();

var uolInt = Convert.ToInt32(uol);
var uhuInt = Convert.ToInt32(uhu);

if(uolInt >= uhuInt)
{
    Console.WriteLine("True");
} else
{
    Console.WriteLine("False");
}
*/

/*
Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out int n1);
Console.Write("Digite outro número: ");
int.TryParse(Console.ReadLine(), out int n2);

Console.WriteLine($"{n1} >= {n2}: {n1 >= n2}");
*/

/*
Console.Write("Digite um número");
var n1 = Console.ReadLine();

var n1Int = Convert.ToInt32(n1);

if (n1Int % 2 == 0)
{
    Console.WriteLine($"{n1Int} é par!");
}
else
{
    Console.WriteLine($"{n1Int} é ímpar!");
}
*/

/*
Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out int n3);
Console.WriteLine($"{n3 % 2 == 0}");
*/

/*
Console.WriteLine("Digite um número");
var n4 = Console.ReadLine();

var n4 = Convert.ToInt32(n4);

int div = n4 % 2 == 0;

Console.WriteLine($"{div}");
*/

/*

Console.Write("Digite um número: ");
var n6 = Console.ReadLine();
Console.Write("Digite o segundo númenro: ");
var n7 = Console.ReadLine();

try
{
    var n6Int = Convert.ToInt32(n6);
    var n7Int = Convert.ToInt32(n7);

    bool result = n6Int > n7Int;

    Console.WriteLine($"{n6} > {n7} = {result}");
}
catch
{
    Console.WriteLine("Digite um número válido!");
}

Console.WriteLine("Digite um numero");
var umNumero = Console.ReadLine();
Console.WriteLine("Digite outro numero");
var outroNumero = Console.ReadLine();



try
{
    var umNumeroInt = Convert.ToInt32(umNumero);
    var outroNumeroInt = Convert.ToInt32(outroNumero);



    Console.WriteLine(umNumeroInt > outroNumeroInt && outroNumeroInt % 2 == 0);
}
catch (Exception)
{
    Console.WriteLine("Digite o numero corretamente");
}

*/