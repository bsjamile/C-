namespace triang_obj
{
    using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo l, d;

            l = new Triangulo();
            d = new Triangulo();

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

                double aL = l.Area() ;
                double aD = d.Area();

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



