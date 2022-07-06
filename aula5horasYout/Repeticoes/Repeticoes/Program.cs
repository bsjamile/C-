namespace Repeticoes
{
    class program
    {
        static string meuNome = "Jamile";
        //Escopo global, pode ser acessada por todas as funções
        static void Main(string[] args)
        {
            LacoWhile();
            LacoDoWhile();
            LacoForEach();
            LacoForArray();
            LacoFor();     
            LacoForArray2();
            LacoForEachTestando();
            Console.WriteLine(meuNome);
        }

        static void LacoWhile()
        {
            Console.WriteLine(meuNome);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("LAÇO WHILE");
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine($"Repetindo {contador}x");
                contador++;
            }
            Console.WriteLine("Fim da linha!");

        }

        static void LacoDoWhile()
        {
            Console.WriteLine(meuNome);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("LAÇO DO WHILE");
            int contador = 1;
            do
            {
                Console.WriteLine($"Repetindo {contador}x");
                contador += 1;

            } while (contador <= 10);

            Console.WriteLine("Fim da linha!");
        }


        static void LacoForEach()
        {
            Console.WriteLine(meuNome);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("LAÇO FOREACH");
            string[] nomes = { "Jamile", "Barroso", "Guia do Prog", "Form CSharp", "VStudio", "Programando", "Estudando" };
            foreach (string name in nomes)
            {
                Console.Write($"{name}\n");
            }
            Console.WriteLine("Fim da linha!");

        }

        static void LacoForArray()
        {
            Console.WriteLine(meuNome);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("LAÇO FOR ARRAY 1");

            int[] numeros = new int[] {1,2,3,4,5,6,7,8,9,10,11,12};

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {numeros[i]}\n");
            }
            Console.WriteLine("Fim da linha!");
        }

        static void LacoFor()
        {
            Console.WriteLine(meuNome);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("LAÇO FOR");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Fim da linha!");

        }

        static void LacoForArray2()
        {
            Console.WriteLine(meuNome);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("LAÇO FOR ARRAY 2");

            string[] palavras = { "Cachorro", "Papagaio", "Periquito", "Cágado", "Leão"};

            for (int i = 0; i < palavras.Length; i++) 
            {
                Console.WriteLine(palavras[i]);
            }

            Console.WriteLine("Fim da linha!");

        }

        static void LacoForEachTestando()
        {
            Console.WriteLine(meuNome);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("LAÇO FOR && FOREACH");

            Console.Write("Números: ");
            int num = int.Parse(Console.ReadLine());
            int[] numeros = new int[num];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i;
            }

            foreach(int n in numeros)
            {
                Console.Write($"Número {n}\n");
            }

            Console.WriteLine("Fim da linha!");
        }
    }
}
