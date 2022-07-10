Console.Write("Digite o número de linhas: ");
int.TryParse(Console.ReadLine(), out int linha);

for (int i = 1; i <= linha; i++)
{
    int quad = i * i;
    int trip = i * i * i;
    Console.WriteLine($"{i} {quad} {trip}");
}