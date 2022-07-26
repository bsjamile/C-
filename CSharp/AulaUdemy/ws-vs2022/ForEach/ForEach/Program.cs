namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            Console.WriteLine("---FOR---");
            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("---FOREACH---");
            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}