/*
A grande diferença entre o ref e o out é que com o out a variável não precisa ser iniciada
*/

Console.Write("Digite o número: ");
int a = int.Parse(Console.ReadLine()); // a variável precisa ser inicializada
Calc.Triple(ref a);

Console.WriteLine(a);

int triple;
Calc.Mult(a, out triple);
Console.WriteLine(triple);