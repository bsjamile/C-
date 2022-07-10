Console.Write(" Number : ");
int.TryParse(Console.ReadLine(), out int n);

for(int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
    }
}