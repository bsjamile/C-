using System;
using System.Globalization;

namespace StatusAluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3, Media;

        public double NotaFinal()
        {
            return Media = Nota1 + Nota2 + Nota3;
        }


        public bool StatusAnual()

        {
            if (Media >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (StatusAnual())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - Media;
            }
        }

        public void Result()
        {
            if (StatusAnual())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM " +
                    $"{NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} " +
                    $"PONTOS");
            }
        }

    }

}

