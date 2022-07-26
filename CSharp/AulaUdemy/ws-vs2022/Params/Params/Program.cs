namespace Params
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
            //para não precisar instanciar com o new, utilizamos o prams na classe calculator

            int result = Calculator.Sum(10,20,30,40,50);

            Console.WriteLine(result);
        }
    }
}

