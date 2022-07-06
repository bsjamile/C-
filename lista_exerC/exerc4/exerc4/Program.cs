using System;
using System.Globalization;

namespace exerc4
{
    class program
    {
        static void Main(string[] args)
        {
            Vida v = new Vida();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            string nomeUp = nome.ToUpper();

            Console.WriteLine($"{nomeUp}, VOCÊ JÁ VIVEU {v.QtdVida(idade)} DIAS");
        }
    }
}
