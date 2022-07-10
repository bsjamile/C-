/*
Console.WriteLine("Digite um número");
var umNumero = Console.ReadLine();


if (int.TryParse(umNumero, out int umNumeroInt) == false) //se o primeiro numero for válido
{
    Console.WriteLine("Digite um número válido");
}
else  //se o outro número for válido
{
    Console.WriteLine("Digite outro número");
    var outroNumero = Console.ReadLine();

    if(int.TryParse(outroNumero, out int outroNumeroInt) == false)
    {
        Console.WriteLine("Digite outro número válido");
    }
    else
    {
        Console.WriteLine(umNumeroInt > outroNumeroInt && outroNumeroInt % 2 == 0);
    }
}
*/

/*
Console.WriteLine("Digite um numero");
var umNumero = Console.ReadLine();

if (int.TryParse(umNumero, out int umNumeroInt) == false)
{
    Console.WriteLine("Digite um numero valido");
}
else // se o numero for valido
{
    Console.WriteLine("Digite outro numero");
    var outroNumero = Console.ReadLine();



    if (int.TryParse(outroNumero, out int outroNumeroInt) == false)
    {
        Console.WriteLine("Digite outro numero valido");
    }
    else // se o Segundo for valido
    {
        Console.WriteLine(umNumeroInt > outroNumeroInt && outroNumeroInt % 2 == 0);
    }
}
*/
/*

var mes = Console.ReadLine();
var mesMinusculo = mes.ToLower();
switch (mesMinusculo)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    case "abril":
    case "junho":
    case "setembro":
    case "novembro":
        Console.WriteLine("Este mês tem 30 dias");
        break;
    default:
        Console.WriteLine("Digite um mes valido");
        break;
}
Console.WriteLine("o que executa depois do break");
*/
/*
Console.Write("Digite um número: ");
string n = Console.ReadLine();

int.TryParse(n.Substring((n.Length - 1), 1), out int digFinal);

switch (digFinal)
{
    case 2:
    case 4:
    case 6:
    case 8:
    case 0:
        Console.WriteLine("Este número é par");
        break;
    default:
        Console.WriteLine("Este número é ímpar");
        break;

}

Console.Write("Digite um número: ");
string n = Console.ReadLine();

 

string ultimoDigito = n.Substring((n.Length - 1), 1);

 

switch (ultimoDigito)
{
    case "2":
    case "4":
    case "6":
    case "8":
    case "0":
        Console.WriteLine("Este número é par");
        break;
    default:
        Console.WriteLine("Este número é ímpar");
        break;

 

}
*/

/*
Console.WriteLine("Digite um numero");
var numeroStr = Console.ReadLine();
var numero = Convert.ToInt32(numeroStr);

for (int i = 0; i < numero; i++)
{
    Console.WriteLine($"olha aqui eu no loop - {i}");
}

Console.WriteLine("Digite um numero");
var num1Str = Console.ReadLine();
var numero1 = Convert.ToInt32(num1Str);

Console.WriteLine("Digite um numero");
var num2Str = Console.ReadLine();
var numero2 = Convert.ToInt32(num2Str);

for (int i = 1; i < numero; i++)
{
    Console.WriteLine($"olha aqui eu no loop - {i}");
}

*/
/*
Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out int n1);
Console.Write("Digite outro número: ");
int.TryParse(Console.ReadLine(), out int n2);

int soma = 0;

for (int i = 0; i < n2; i++)
{
    soma += n1;
}

Console.WriteLine($"A multiplicação entre {n1} e {n2} é {soma}");


List<int> minhaListaDeInteiros = new List<int>();
minhaListaDeInteiros.Add(10);
minhaListaDeInteiros.Add(20);
minhaListaDeInteiros.Add(30);
minhaListaDeInteiros.Add(40);
minhaListaDeInteiros.Add(55);
minhaListaDeInteiros.Add(550);
minhaListaDeInteiros.Add(10);


foreach (var meuInteiro in minhaListaDeInteiros)
{
    Console.WriteLine(meuInteiro);
}


Console.Write("Digite uma palavra: ");
var minhaPalavra = Console.ReadLine();
var charArray = minhaPalavra.ToCharArray();

foreach (var cadaLetra in charArray)
{
    Console.WriteLine(cadaLetra);
}


Console.Write("Digite uma palavra: ");
string word = Console.ReadLine();

foreach (char letra in word)
{
    Console.WriteLine(letra);
}

var minhaPalavra = Console.ReadLine();

 

var minhaPalavraArray = minhaPalavra.ToCharArray();

 

int i = 0;
while (i < minhaPalavraArray.Length)
{
    Console.WriteLine(i + " - " + minhaPalavraArray[i]);
    i++;
}

var minhaPalavra = Console.ReadLine(); 

var minhaPalavraArray = minhaPalavra.ToCharArray();

 

int i = 0;
do
{
    Console.WriteLine(i + " - " + minhaPalavraArray[i]);
    i++;
} while (i < minhaPalavraArray.Length);


int soma = 0;
int n = 0;
do
{
    Console.Write("Digite números para somar. Quando quiser conferir a soma, digite 0: ");
    int.TryParse(Console.ReadLine(), out n);

    soma += n;
} while (n != 0);

Console.WriteLine($"A soma dos números foi {soma}");


int a, b, c;
double delta;
double raizDelta;
double primeiraRaiz;
double segundaRaiz;

Console.WriteLine("Digite o valor de a: ");
int.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Digite o valor de b: ");
int.TryParse(Console.ReadLine(), out b);

Console.WriteLine("Digite o valor de c: ");
int.TryParse(Console.ReadLine(), out c);

delta = Math.Pow(b,2) - (4 * a * c);
raizDelta = Math.Sqrt(delta);

primeiraRaiz = (-b + raizDelta) / (2 * a);
segundaRaiz = (-b - raizDelta) / (2 * a);

Console.WriteLine($"primeira raiz {primeiraRaiz} - segunda raiz {segundaRaiz}");

*/

// int n1, n2;
// do
// {
//     Console.Write("Digite um número inteiro (n1): ");
// } while (!int.TryParse(Console.ReadLine(), out n1));

// do
// {
//     Console.Write("Digite outro número inteiro (n2): ");
// } while (!int.TryParse(Console.ReadLine(), out n2));

// Console.WriteLine((n2 % 2) == 0 && n1 > n2);









