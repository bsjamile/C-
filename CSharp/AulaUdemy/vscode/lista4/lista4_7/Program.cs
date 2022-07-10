/*

Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.

*/


Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out int n);

if (n >= 1 && n <= 1000)
{
    for (int i = 1; i <= n; i = i + 2)
    {
        Console.WriteLine(i);
    }
} 
else 
{
    Console.WriteLine("Digite um número de 1 a 1000");
}



