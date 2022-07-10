using System.Text;

/*var date = new DateTime();
Console.WriteLine(date);
date = date.AddDays(2);
Console.WriteLine(date);

Console.WriteLine(date.DayOfWeek);
Console.WriteLine(date.Day);
Console.WriteLine(date.Month);
Console.WriteLine(date.Year);


var date1 = DateTime.Now;
Console.WriteLine(date1);

var date2 = DateTime.UtcNow;
Console.WriteLine(date2);

var date3 = new DateTime(2020, 07, 02, 22, 59, 59);
Console.WriteLine(date3);

var date4 = new DateTime(2020, 07, 02);
Console.WriteLine(date4);*/

/*
Console.WriteLine("Qual o dia que você nasceu?");
var dia = (Console.ReadLine());

Console.WriteLine("Qual o mês que você nasceu?");
var mes = Console.ReadLine();

Console.WriteLine("Qual o ano que você nasceu?");
var ano = Console.ReadLine();

var diaInteiro = Convert.ToInt32(dia);
var mesInteiro = Convert.ToInt32(mes);
var anoInteiro = Convert.ToInt32(ano);

var dataDoAniversario = new DateTime(anoInteiro, mesInteiro, diaInteiro);

Console.WriteLine("Você nasceu no dia " + dataDoAniversario.DayOfWeek);
Console.WriteLine(dataDoAniversario.DayOfYear); */

/* string minhaString = "Jamile";
Console.WriteLine(minhaString);

string minhaNovaString = minhaString + " Barroso";
Console.WriteLine(minhaNovaString);

minhaString += " dos Santos";
Console.WriteLine(minhaString);

StringBuilder sb = new StringBuilder();
sb.Append("Jamile");
sb.Append(" Barroso dos Santos");
string str = sb.ToString();
Console.WriteLine(str);
*/


/*
var a = "minha string";
Console.WriteLine(a);

var b = "minha outra string";
Console.WriteLine(b);

Console.WriteLine(a == b); // se a > b -1 ou se a < b 1
Console.WriteLine(a.Equals(b));

Console.WriteLine(string.Compare(a, b, true));

string s = new string('*', 20);
Console.WriteLine(s);

 Retorna -1 se a < b
Retorna 0 se forem iguais
Retorrna 1 se a > b
 */

/*
string s1 = "trabalhar com C# é demais!!!";
string s2 = "demais";

var pos = s1.IndexOf(s2);
Console.WriteLine(pos);

var poss = s1.ToCharArray();
Console.WriteLine(poss[10]);
*/

/*
Console.WriteLine("Digite uma string");
var primeiraString = Console.ReadLine();
Console.WriteLine("Digite outra string");
var segundaString = Console.ReadLine();
Console.WriteLine(primeiraString + " " + segundaString);
var pos = primeiraString.ToCharArray();
Console.WriteLine(pos[4]);
*/

var a = "a";
var b = "b";
var c = "";
Console.WriteLine(a + " " + b);
c += a;
c += " ";
c + b = b;
Console.WriteLine(c);

StringBuilder sb = new StringBuilder();
sb.Append(a);
sb.Append(" ");
sb.Append(b);
Console.WriteLine(sb.ToString());




