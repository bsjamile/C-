using System.Globalization;

namespace exerc15
{
    class program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            Console.Write("Valor da Conta: ");
            double valorConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c.DivisaoConta(valorConta);
        }
    }
}