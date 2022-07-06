
namespace exerc2
{
    class program
    {
        static void Main(string[] args)
        {
            Ferraduras f = new Ferraduras();

            Console.Write("Qnts cavalos? ");
            int qtdCavalos = int.Parse(Console.ReadLine());

            Console.WriteLine($"{f.QtdFerraduras(qtdCavalos)} ferraduras para {qtdCavalos} cavalos!");

        }

    }
}



