using System;

namespace TempoTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("22/06/1995");
            DateTime today = DateTime.Now;

            TimeSpan intervalo = today - d1;
            Console.WriteLine($"{d1} - {today} = {intervalo.ToString()}"); // retorno dd, hh, m, ss, ms

            TimeSpan t1 = new TimeSpan(); //Retorna 00:00:00
            Console.WriteLine(t1);

            TimeSpan t2 = new TimeSpan(0, 1, 30); //hh, m, ss
            Console.WriteLine(t2);
            Console.WriteLine(t2.Ticks);

            TimeSpan t3 = new TimeSpan(900000000L); //Lendo em ticks que sao 100 nanosegundos
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(2, 11, 21);//hh, m, ss
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(1,2,11,21);//dd, hh, m, ss
            Console.WriteLine(t5);

            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);//dd, hh, m, ss, milisegundos
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t8);
            
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t9);
            
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t10);

            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t11);
            
            TimeSpan t12 = TimeSpan.FromTicks(900000000L); // só aceita long pq é a menor unidade (nanosegundos)
            Console.WriteLine(t12);



        }
    }
}