﻿
namespace exercHackerR1
{
    class program
    {
        public static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = Result.kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
        }
    }
}
