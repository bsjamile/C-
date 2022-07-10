/* Mais utilizados
 * int - +/- inteiro e 4 bytes
 * long - +/- inteiro e 8 bytes
 * float - +/- casa decimais 4 bytes
 * double - +/- casa decimais 8 bytes
 * decimal - +/- casa decimais 12 bytes e calculos com alta precisão
 * char - armazena 1 caracter
 * bool - V or F
 * Overflow - quando o cálculo estrapola o limite da sua variável
 */
sbyte x = 127; // vai de -128 0 a 127
x++;
Console.WriteLine($"sbyte:{x}; minValue: {sbyte.MinValue}; maxValue: {sbyte.MaxValue}"); // Retorna -128 pq ultrapassou o limite da variável sbyte

byte n1 = 255; // não aceita número negativo e vai de 0 a 255
n1++; // Retorna 0 pq ultrapassou o limite da variável byte
Console.WriteLine($"Byte: {n1}; minValue: {byte.MinValue}; maxValue: {byte.MaxValue}"); 

int n2 = 1000;
Console.WriteLine($"Int: {n2}; minValue: {int.MinValue}");

int n3 = 2147483647; // número máximo do int
n3++;
Console.WriteLine(n3); // Retorna -2147483648 pq ultrapassou o limite da variável int

long n4 = 2147483648L; // Sem o L também funciona
Console.WriteLine(n4); // O long comporta mais números do que o int

bool completo = false;
Console.WriteLine(completo); // V ou F - true ou false

char genero = 'F'; //char fica sempre entre aspas simples
Console.WriteLine(genero);

char letra = '\u0041'; // código unicode do caracter A
Console.WriteLine(letra);

float n5 = 4.5f;
Console.WriteLine(n5);

double n6 = 4.5d; // sem o d também funciona
Console.WriteLine(n6);

// A variável do tipo String é IMUTÁVEL.
// Uma vez que você cria uma variável String, não pode alterar o valor dela.
// Segurança, Simplicade e thread safe (livre de erro)

string nome = "Maria Green"; // String fica sempre entre aspas duplas
Console.WriteLine(nome);
nome = "João"; //Está criando um novo string e não alterando
Console.WriteLine(nome);

// Object = Toda classe em C# é subclasse de object - ela também é um object
object obj1 = "Alex Brown"; // Tipo genérico, aceita qlqr coisa!
Console.WriteLine(obj1);

object obj2 = 4.5f; // Tipo genérico, aceita qlqr coisa!
Console.WriteLine(obj2);

decimal dec = 42934723894;
Console.WriteLine($"decimal: {dec}; minValue: {decimal.MinValue}; maxValue: {decimal.MaxValue}");

