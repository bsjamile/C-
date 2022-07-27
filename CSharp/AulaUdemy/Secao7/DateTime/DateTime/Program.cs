using System;
using System.Globalization;

namespace TipoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {                        
            DateTime d2 = new DateTime(2018, 11, 25); // 25/11/2018 às 00h
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03); // 25/11/2018 às 20:45:03h
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500); // 25/11/2018 às 20:45:03h + os milisegundos

            DateTime d5 = DateTime.Today; //data de hoje com a hora 00h
            // Console.WriteLine(d1.Ticks); a data na verdade é um numero inteiro grandao
            DateTime d1 = DateTime.Now; // data e horario de agora (horario do pc)
            DateTime d6 = DateTime.UtcNow; //data de hoje com horario de greenwich

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d10 = DateTime.Parse("15/08/2000");
            DateTime d11 = DateTime.Parse("15/08/2000 13:05:58");
            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("22/06/1995 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);


            Console.WriteLine(d1); 
            Console.WriteLine(d2);           
            Console.WriteLine(d3);          
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            DateTime d9 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
            Console.WriteLine(d13);
            DateTime d14 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d14);
        }
    }
}