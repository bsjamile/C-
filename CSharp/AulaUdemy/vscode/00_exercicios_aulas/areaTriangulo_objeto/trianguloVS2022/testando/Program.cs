namespace testando
{
    using System.Globalization;
    class Program
    {
        static void Main(string [] Args){

            Triangulo l, d;

            l = new Triangulo();
            d = new Triangulo();

            double aL, aD, p;

            Console.Write("Qtd de Triangulos: ");
            int.TryParse(Console.ReadLine(), out int qtd);

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Entre com as medidas do triângulo L:");
                double.TryParse(Console.ReadLine(), out l.A);
                double.TryParse(Console.ReadLine(), out l.B);
                double.TryParse(Console.ReadLine(), out l.C);

                Console.WriteLine("Entre com as medidas do triângulo D:");
                double.TryParse(Console.ReadLine(), out d.A);
                double.TryParse(Console.ReadLine(), out d.B);
                double.TryParse(Console.ReadLine(), out d.C);

                p = (l.A + l.B + l.C) / 2.0;
                aL = Math.Sqrt(p * (p - l.A) * (p - l.B) * (p - l.C));

                p = (d.A + d.B + d.C) / 2.0;
                aD = Math.Sqrt(p * (p - d.A) * (p - d.B) * (p - d.C));

                Console.WriteLine($"Área de L = " + aL.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine($"Área de D = " + aD.ToString("F4", CultureInfo.InvariantCulture));

                string maior;

                if (aL > aD)
                {
                    maior = "L";
                }
                else if (aD > aL)
                {
                    maior = "D";
                }
                else
                {
                    maior = "L = D";
                }

                Console.WriteLine($"Maior área: {maior}");
            }
        }
    }
}

