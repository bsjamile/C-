int x = 20;
Object obj = x;
int y = (int)obj;

Console.WriteLine($"{x}, {obj}, {y}");
Console.WriteLine(Object.ReferenceEquals(obj.GetType(), y.GetType));