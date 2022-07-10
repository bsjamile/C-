// Precedência ! > && > ||

bool c1 = 4 != 5;
bool c2 = 2 > 3 && 4 != 5; // false
bool c3 = 2 < 3 && 4 != 5; // true
bool c4 = 2 > 3 || 4 != 5;
bool c5 = !(2 > 3) && 4 != 5;

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);
Console.WriteLine(c4);
Console.WriteLine(c5);

Console.WriteLine("---------------------");

bool c6 = 10 < 5; // false
bool c7 = c6 || c2 && c3; // Primeiro é resolvido && por causa da precedência

Console.WriteLine(c7);
