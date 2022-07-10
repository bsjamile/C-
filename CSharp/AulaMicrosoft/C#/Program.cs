// Console.WriteLine('Hello World!');
//O C# não aceita aspas simples ('')

Console.Write("Congratulations!");

Console.Write(" ");

Console.WriteLine("You wrote your first lines of code!");

// or.. it's the same!

Console.WriteLine("Congratulations! ");

// A próxima linha vai aparecer em outro parágrafo por causa da função 'WriteLine"

Console.WriteLine("You wrote your second lines of code!");

Console.WriteLine("Hello World!");
// O C# só aceita asplas duplas ("")

Console.WriteLine("This is the first line.");

Console.WriteLine("This is the second line.");

Console.Write("This is ");
Console.Write("the second");
Console.WriteLine(" line.");

Console.WriteLine('b');
// Apenas um único caractere alfanumérico impresso na tela, poderíamoso criar um literal char circundando um caractere alfanumérico com aspas simples.

Console.WriteLine(120);
Console.WriteLine(12.3m);
// O m pode ser maiúsculo ou minúsculo

Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine("123");
Console.WriteLine(123);
Console.WriteLine("true");
Console.WriteLine(true);

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

char userOption;
userOption = 'J';
Console.WriteLine(userOption);

int gameScore;
gameScore = 1;
Console.WriteLine(gameScore);

decimal particlesPerMillon;
particlesPerMillon = 1.0m;
Console.WriteLine(particlesPerMillon);

bool processedCustomer;
processedCustomer = true;
Console.WriteLine(processedCustomer);

string myName;
myName = "Jamile";
//"Jamile = myName; (não funciona. Só do outro modo)
Console.WriteLine(myName);

string myNickname;
myNickname = "Mile";
Console.WriteLine(myNickname);

// int myNickname;
// myNickname = "Jam";
// Console.WriteLine(myNickname);
// O C# foi projetado para impor tipos, 
// O que significa que você não pode atribuir um valor de um tipo de dados a uma variável declarada com a finalidade de conter um tipo de dados diferente.

firstName = "Beth";
Console.WriteLine(firstName);
firstName = "Conrad";
Console.WriteLine(firstName);
firstName = "Grant";
Console.WriteLine(firstName);
firstName = "Maricota";
//Inicializar uma variável
Console.WriteLine(firstName);

// string firstName;
// Console.WriteLine(firstName);
// É preciso definir uma variável como um valor antes de poder obter o valor da variável.

var message = "Hello World!";
Console.WriteLine(message);
message = "Olá!";
Console.WriteLine(message);
// a partir daí, a variável message só aceita dados do tipo string.

string nameDog = "Bob";
int numberInbox = 3;
decimal temperature = 34.4m;
Console.Write("Hello, ");
Console.Write(nameDog);
Console.Write("! You have ");
Console.Write(numberInbox);
Console.Write(" messages inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");

Console.WriteLine("Hello\nWorld!");
// \n adicionará uma nova linha

Console.WriteLine("Hello\tWorld!");
// \t adicionará um espaço em branco

Console.WriteLine("Hello \"World\"!");
// \" para colocar entre aspas

// Console.WriteLine("c:\source\repos"); dá erro porque a \ é reservada para sequências de escape. \s e \r são sequências de escape
// Então, quando precisarmos colocar um nome de um local ou algo do tipo, precisamos adicionar uma segunda \. Ex:
Console.WriteLine("c:\\source\\repos");

Console.Write("Generating invoices for cusromer \"ABC Corp\"...\n");
Console.Write("Invoice:2021\t\tComplete!\n");
Console.WriteLine("Invoice 1022\t\tComplete!");
Console.WriteLine("Output Directory:\t");
Console.WriteLine(@"c:\invoices");

// as sequeências de escape: \t - espaço em braanco ; \n pula uma linha ; \" Jmile \" coloca aspas em Jmile
// o @ antes de tudo faz com que não seja necessário o uso das duas barras (\\)
Console.WriteLine(@"c:\source\repos
    (this is where your code goes)");
Console.WriteLine(@"c:\invoices");

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyu-sho o seisei suru ni wa:
Console.Write("\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

// Concatenar Valores
// operador de concatenação = +
message = "Hello " + firstName;
Console.WriteLine(message);

string getting = "Hello";
Console.WriteLine(getting + " " + firstName + "!");
message = $"{getting} {firstName}!!!!!!!!!!!";
Console.WriteLine(message);

//Interpolação pode criar um modelo com $
myName = "Jamile";
message = $"Hello {firstName} e {myName}!";
Console.WriteLine(message);
// Não criar variáveis intermediárias
Console.WriteLine($"{getting} {firstName} e {myName}!");

Console.WriteLine($"Olá! Eu gostaria de conhecer {firstName} e {myName}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string projetoNome = "ACME";
string englishLocation = $@"c:\Exercise\{projetoNome}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMensagem = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c  \u0440\u0443\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMensagem}:\n\t\t{russianLocation}\n");


//string projetoNome = "ACME";
//string russianMensagem = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c  \u0440\u0443\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"View English output:
    c:\Exercise\{projetoNome}\data.txt");
Console.WriteLine($@"{russianMensagem}:
    c:\Exercise\{projetoNome}\ru-RU\data.txt");

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
// aqui o sinal de + funciona como soma

int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// aqui o sinal de + serve como compilador

Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
// o compilador trata tudo como uma cadeia de caracteres e concatena tudo.

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
int resto = 7 % 5;
decimal decimalQuotient = 7.0m / 5;
decimal decimalQuootient = 7 / 5;
int decimalQuootiient = 7 / 5;


Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine("Resto: " + resto);
Console.WriteLine("Descimal Quotient: " + decimalQuotient);

int first = 7;
int second = 5;
decimal quotiient = (decimal)first / (decimal)second;
Console.WriteLine(quotiient);

Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));
// Quando o módulo é 0, isso significa que o dividendo é divisível pelo divisor.

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

int value = 0;
value = value + 5;
value += 5;
//incrementa o valor, vai acrescentando
value++;
//incrementa mais 1
Console.WriteLine(value);

int value4 = 1;

value4 = value4 + 1;
Console.WriteLine("First increment: " + value4);

value4 += 5;
Console.WriteLine("Second inicrement: " + value4);

value4++;
Console.WriteLine("Tird increment: " + value4);

value4 = value4 - 1;
Console.WriteLine("First decrement: " + value4);

value4 -= 5;
Console.WriteLine("Second decrement: " + value4);

value4--;
Console.WriteLine("Tird decrement: " + value4);

value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
//recupera o valor atual e incrementa o valor
Console.WriteLine("Third: " + value);
//confirma que o valor foi, de fato, incrementado
Console.WriteLine("Fourth: " + (++value));
// Incrementa o valor e recupera o novo valor incrementado

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

Console.WriteLine(5m / 10m);

Random dice = new Random();
int roll = dice.Next(1, 7);
//parâmetros de entrada definem o limite inferior e superior, respectivamente, para o método Next(), conforme gera um número aleatório. 
Console.WriteLine(roll);

int numbers = 7;
string texto = "seven";
Console.WriteLine(numbers);
Console.WriteLine();
Console.WriteLine(texto);
// 3 versões sobrecarregadas do método WriteLine()

Random nice = new Random();
int roll1 = nice.Next();
int roll2 = nice.Next(101);
int roll3 = nice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
//3 versões sobrecarregadas diferentes

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

Random naice = new Random();

int rooll10 = naice.Next(1, 7);
int rooll11 = naice.Next(1, 7);
int rooll12 = naice.Next(1, 7);

int total = rooll10 + rooll11 + rooll12;

Console.WriteLine($"Naice rooll: {rooll10} + {rooll11} + {rooll12} = {total}");

if ((rooll10 == rooll11) || (rooll11 == rooll12) || (rooll12 == rooll10))
//condição composta ; || operadores lógicos or/ou
{
    if ((rooll10 == rooll11) && (rooll12 == rooll10))
    // condição && = e ; todas as condições precisam ser verdadeiras para a condição booliana = True;
    {
        Console.WriteLine("You rolled triples! +6 bonus to total");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine($"You Win a new car! O total foi {total}!");
}
else if (total >= 10)
{
    Console.WriteLine($"You Win a new laptop. O total foi {total}");
}
else if (total == 7)
{
    Console.WriteLine($"You Win a trip for two! O total foi {total}!");
}
else
{
    Console.WriteLine($"You Win a kitten! O total foi de {total}");
}

message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

 // Usando espaçamento correto
Random random = new Random();

int daysUntilExpration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
    //Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpration} days.");
    discountPercentage = 10;
    //Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}//Fim

string[] fraudulentOrderIDs = new string[3];
// declarar uma nova matriz de cadeias de caracteres para conter três elementos
// O conjunto de colchetes [] indica ao compilador que a variável de nome fraudulentOrderIDs será uma matriz
// O número 3 dentro do colchetes contém o número de elementos que a matriz conterá.

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

string[] fraudulentOrderIDDs = { "Jamile", "Linda", "Bob", "Pretinha" };

Console.WriteLine($"First: {fraudulentOrderIDDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDDs[2]}");
Console.WriteLine($"Fourth: {fraudulentOrderIDDs[3]}");

fraudulentOrderIDDs[0] = "JBS";

Console.WriteLine($"Reassign First: {fraudulentOrderIDDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDDs.Length} fraudulent orders to process.");

//Foreach

string[] names = { "Bobz", "Conrad", "Grant" };
foreach (string name in names)
//realiz o loop dentro da matriz
// a variável name é uma variável temporária para facilitar o acesso dentro do bloco de código
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int summ = 0;
int bin = 0;
foreach (int items in inventory)
{
    summ += items;
    bin++;
    //O operador ++ incrementa o valor da variável em 1. É um atalho para escrever bin = bin + 1
    Console.WriteLine($"Bin {bin} = {items} items (Running total:{summ})");
}

Console.WriteLine($"O inventário contém {summ} produtos ao total.");

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine($"{orderID}");
    }
}

// This is a code comment!

/*
string named = "JBarrosinho";
int widgetsPurchased = 7;
Console.WriteLine($"{named} sold {widgetsPurchased} widgets.");
*/

/*

*/

// Example 1 - Espaços em branco são ignorados pelo compilador do C#
Console
.
WriteLine
(
    "Hello World!"
);

// Example 2
string firstWoord="Hello";string laastWord="World";Console.WriteLine(firstWoord+" "+laastWord+"!");