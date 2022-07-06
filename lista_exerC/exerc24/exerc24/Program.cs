using System.Globalization;

namespace exerc24
{
    class program
    {
        static void Main(string[] args)
        {
            Litros l = new Litros();

            Console.Write("Qtd de litros de refresco: ");
            double qtdRefresco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            l.QtdLitros(qtdRefresco);
        }
    }
}
