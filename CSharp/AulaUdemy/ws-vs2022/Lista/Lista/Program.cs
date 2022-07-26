namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            //List<string> list2 = new List<string> { "Marie", "Mary", "Mari", "Maria", "M", "Maraiia" };

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Jamile");
            list.Add("Gabriella");
            list.Add("Rodrigo");
            list.Insert(2, "Marco");//adiciona na posição 2

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"List count: {list.Count}"); //Conta qnts elementos há na lista

            string s1 = list.Find(x => x[0] == 'A'); //Funcao lambda, funcao anonima

            Console.WriteLine($"First A: {s1}");

            string s2 = list.FindLast(x => x[0] == 'A');

            Console.WriteLine($"Last A: {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First Position A: {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last Position A: {pos2}");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2);
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); //A partir da posição 2, quero remover 2 elementos
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}