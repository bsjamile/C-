
DateTime y1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

DateTime z1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

DateTime w1 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine($"y1: {y1}");
Console.WriteLine($"y1 Kind: {y1.Kind}");
Console.WriteLine($"y1 to Local: {y1.ToLocalTime()}");
Console.WriteLine($"y1 to Global: {y1.ToUniversalTime()}");
Console.WriteLine();
Console.WriteLine($"z1: {z1}");
Console.WriteLine($"z1 Kind: {z1.Kind}");
Console.WriteLine($"z1 to Local: {z1.ToLocalTime()}");
Console.WriteLine($"z1 to Global: {z1.ToUniversalTime()}");
Console.WriteLine();
Console.WriteLine($"w1: {w1}");
Console.WriteLine($"w1 Kind: {w1.Kind}");
Console.WriteLine($"w1 to Local: {w1.ToLocalTime()}");
Console.WriteLine($"w1 to Global: {w1.ToUniversalTime()}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------------------------");

//Padrao ISO 8601
//Formato: yyyy-MM-ddTHH:mm:ssZ
//Z indica que a data/hora está em Utc

DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

Console.WriteLine($"d1: {d1}");
Console.WriteLine($"d1 Kind: {d1.Kind}");
Console.WriteLine($"d1 to Local: {d1.ToLocalTime()}");
Console.WriteLine($"d1 to Utc (Global): {d1.ToUniversalTime()}");
Console.WriteLine();
Console.WriteLine($"d2: {d2}");
Console.WriteLine($"d2 Kind: {d2.Kind}");
Console.WriteLine($"d2 to Local: {d2.ToLocalTime()}");
Console.WriteLine($"d2 to Utc (Global): {d2.ToUniversalTime()}");
Console.WriteLine();
Console.WriteLine($"{d2.ToString("yyyy-MM-ddTHH:mm:ssZ")}"); //cuidado!
Console.WriteLine($"{d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")}");//Para usar o ToString tem que garantir que está no formato universal