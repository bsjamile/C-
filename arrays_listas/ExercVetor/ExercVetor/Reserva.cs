using System;
using System.Globalization;

namespace ExercVetor
{
    class Reserva
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Reserva(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return $"{Nome}, {Email}";
        }
    }
}
