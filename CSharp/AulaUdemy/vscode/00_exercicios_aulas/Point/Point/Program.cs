using System;
using System.Globalization;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;

            p.X = 10;
            p.Y = 20;
            //Nullable<double> Z = null;
            double? y = null;
            double? w = 5.0;
            double x = y ?? 0.0; //Se y for null, atribua o valor 0 a x
            double k = w ?? 0.0;

            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(w.GetValueOrDefault());
            Console.WriteLine(x);
            Console.WriteLine(k);

            Console.WriteLine(y.HasValue);
            Console.WriteLine(w.HasValue);

            if(y.HasValue)
            Console.WriteLine(y.Value);
            else
            Console.WriteLine("Y is null!");

            if(w.HasValue)
                Console.WriteLine(w.Value);
            else
                Console.WriteLine("W is null!");

            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
    
}


