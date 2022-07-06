using System;
using System.Globalization;

namespace ExercVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Reserva[] reservas = new Reserva[10];

            Console.Write("Quantos quartos serão alugados? ");
            int.TryParse(Console.ReadLine(), out int qtd);

            int i;

            for (i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                reservas[quarto] = new Reserva (nome, email, quarto);
            }

            Console.WriteLine();
            Console.WriteLine($"Quartos ocupados:");
            for (i = 0; i < 10; i++)
            {
                if (reservas[i] != null)
                    Console.WriteLine($"{i} : {reservas[i]}");
            }
        }
    }
}