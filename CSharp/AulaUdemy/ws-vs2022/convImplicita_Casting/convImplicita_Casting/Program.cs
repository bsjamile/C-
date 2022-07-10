//Conversão Implícita de float para double
//float 4bytes é menor do que double.. então, cabe implicitamente dentro do double
//mas double 8bytes não cabe dentro do float
double x = 4.5f;

float y = (float)x; //casting - eu tô forçando a transformar em float garantindo q nao tem problema

Console.WriteLine(y);

//Casting - double para int há valor que será perdido por int só considerar inteiro

double a;
int b;

a = 5.1d;
b = (int)a;

Console.WriteLine(b);

int w = 5;
int z = 2;

double resultado = w / z;

//Vai imprimir valor inteiro por a as variaveis serem inteiras
Console.WriteLine(resultado);




int trim = 5;
int trum = 2;

double resultado2 = (double) trim / trum;

//Vai imprimir valor 2,5 pela casting atribuida à divisao
Console.WriteLine(resultado2);