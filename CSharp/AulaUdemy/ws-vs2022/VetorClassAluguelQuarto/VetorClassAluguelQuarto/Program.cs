using System;

namespace VetorClassAluguelQuarto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int.TryParse(Console.ReadLine(), out int n);

            if (n > 0 && n <= 10)
            {
                RentRooms[] vect = new RentRooms[10]; //Não considera a posição 10, apenas de 0 a 9

                for (int i = 1; i <= n; i++) //Quarto de 1 a 10
                {
                    Console.WriteLine($"Rent #{i}");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Room: ");
                    int.TryParse(Console.ReadLine(), out int room);

                    vect[room] = new RentRooms(name, email);
                }
                Console.WriteLine();
                Console.WriteLine("Rooms rented:");
                for(int i = 0; i < 10; i++) //se tiver algo no i = 0, ele traz essa informação primeiro
                {
                    if (vect[i] != null)
                    {
                        Console.WriteLine($"{i} : {vect[i]}");
                    }
                }                
            }
            else
                Console.WriteLine("Choose a quantity between 1 and 10 rooms");        
        }
    }
}
