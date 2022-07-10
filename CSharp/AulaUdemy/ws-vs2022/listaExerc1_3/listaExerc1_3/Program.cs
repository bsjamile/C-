//Lista de Exercício 1 - Exercício 3

int a,b,c,d, diferenca;

for(int i=0; i<2; i++)
{
    Console.WriteLine("Digite o valor de a: ");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor de b: ");
    b = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor de c: ");
    c = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor de d: ");
    d = int.Parse(Console.ReadLine());

    diferenca = (a * b - c * d);

    Console.WriteLine($"DIFERENCA = {diferenca}");
    Console.WriteLine();
}


