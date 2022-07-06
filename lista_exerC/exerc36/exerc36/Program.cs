using System.Globalization;

namespace exerc36
{
    class program
    {
        static void Main(string[] args)
        {
            Tabuada tab = new Tabuada();

            Console.Write("Digite um número: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Até qnt quer multiplicar? ");
            int number2 = int.Parse(Console.ReadLine());

            tab.CalcTab(number1, number2);
        }
    }
}