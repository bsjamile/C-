namespace exerc10
{
    class program
    {
        static void Main(string[] args)
        {
            Ac acid = new Ac();

            Console.Write("Qtd de dias sem acidentes: ");
            int dia = int.Parse(Console.ReadLine());

            acid.qtdAcidentes(dia);
        }
    }
}





