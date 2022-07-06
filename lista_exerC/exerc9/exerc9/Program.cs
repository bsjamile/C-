
namespace exerc9
{
    class program
    {
        static void Main(string[] args)
        {

            Camisas c = new Camisas();

            Console.Write("Camisas P: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Camisas M: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Camisas G: ");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine($"O total do valor arrecadado é: R$ { c.Total(p, m, g)}");
        }
    }
}
