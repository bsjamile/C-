DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

Console.WriteLine(d);
Console.WriteLine($"1) Date: {d.Date}"); //desconsidera o horário
Console.WriteLine($"2) Day: {d.Day}");
Console.WriteLine($"3)DayOfWeek: {d.DayOfWeek}");
Console.WriteLine($"4) DayOfYear: {d.DayOfYear}");
Console.WriteLine($"5) Hour: {d.Hour}");
Console.WriteLine($"6) Kind: {d.Kind}"); //tipo
Console.WriteLine($"7) Millisecond: {d.Millisecond}");
Console.WriteLine($"8) Minute: {d.Minute}");
Console.WriteLine($"9) Month: {d.Month}");
Console.WriteLine($"10) Second: {d.Second}");
Console.WriteLine($"11) Ticks: {d.Ticks}");
Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
Console.WriteLine($"13) Year: {d.Year}");

Console.WriteLine("---------------------------------------");

DateTime d1 = new DateTime(1995, 6, 22, 03, 45, 01); //considera a data completa por extenso

string s1 = d.ToLongDateString();
string s4 = d.ToShortDateString();
string s2 = d.ToLongTimeString();
string s3 = d.ToShortTimeString();

string s5 = d.ToString();

string s6 = d.ToString("yyyy-MM-dd HH:mm:ss"); //máscara de formaatação
string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff"); //máscara de formaatação


Console.WriteLine(d.ToLongDateString());
Console.WriteLine(d.ToShortDateString());
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);
Console.WriteLine(s5);
Console.WriteLine(s6);
Console.WriteLine(s7);

Console.WriteLine("---------------------------------------");

DateTime d2 = d.AddHours(2);
DateTime d3 = d.AddMinutes(3);
DateTime d4 = d.AddDays(7);

TimeSpan t = d.Subtract(d1);

Console.WriteLine(d);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(t);