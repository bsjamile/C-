string [] numbers = Console.ReadLine().Split(' ');

int m = int.Parse(numbers[0]);
int n = int.Parse(numbers[1]);

int[,] ints = new int[m, n]; //matriz m x n

for (int i = 0; i < m; i++)
{
    string[] values = Console.ReadLine().Split(' ');

        for(int j = 0; j < n; j++)
    {
        ints[i, j] = int.Parse(values[j]);
    }
}

int searchInt = int.Parse(Console.ReadLine());

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if(ints[i, j] == searchInt)
        {
            Console.WriteLine($"Position {i},{j}:");
            if(j > 0)
                Console.WriteLine($"Left: {ints[i, j - 1]}");
            if(i > 0)
                Console.WriteLine($"Up: {ints[i - 1, j]}");
            if(j < n - 1)
                Console.WriteLine($"Right: {ints[i, j + 1]}");
            if (i < m - 1)
                Console.WriteLine($"Down: {ints[i + 1, j]}");
        }
    }
}
