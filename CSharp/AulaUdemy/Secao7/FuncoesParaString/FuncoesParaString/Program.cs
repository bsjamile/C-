namespace FuncoesParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();     
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc"); //primeiro bc comeca a partir de quando?
            int n2 = original.LastIndexOf("bc"); //último bc comeca a partir de quando?

            string s4 = original.Substring(3); //Cortar da posicao 3 em diante
            string s5 = original.Substring(3, 5); //Cortar da posicao 3, mas cortar apenas 5 caracteres

            string s6 = original.Replace('a' , 'x'); //substituir caracter
            string s7 = original.Replace("abc" , "jamile"); //substituir uma string

            bool b1 = String.IsNullOrEmpty(original); //verificar se é null ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original); //verificar se é null ou está apenas com espaço em branco

            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"ToUpper: -{s1}-");
            Console.WriteLine($"ToLower: -{s2}-");          
            Console.WriteLine($"Trim: -{s3}-");
            Console.WriteLine($"IndexOf('bc'): -{n1}-");
            Console.WriteLine($"LastIndexOf('bc'): -{n2}-");
            Console.WriteLine($"Substring(3): -{s4}-");
            Console.WriteLine($"Substring(3,5): -{s5}-");
            Console.WriteLine($"Replace('a', 'x'): -{s6}-");          
            Console.WriteLine($"ReplaceS('abc', 'jamile'): -{s7}-");          
            Console.WriteLine($"IsNullOrEmpty: -{b1}-");          
            Console.WriteLine($"IsNullOrWhiteSpace: -{b2}-");          
        }
    }
}