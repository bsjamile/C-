using System;

namespace lista5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2, p;
            p1 = new Pessoa();
            p2 = new Pessoa();
            p = new Pessoa();


            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            int.TryParse(Console.ReadLine(), out p1.Idade);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            int.TryParse(Console.ReadLine(), out p2.Idade);

            p.MaisVelha(p1.Idade, p2.Idade, p1.Nome, p2.Nome);
        }
    }    
}

