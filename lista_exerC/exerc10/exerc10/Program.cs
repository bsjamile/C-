namespace exerc10
{
    class program
    {
        static void Main(string[] args)
        {
            Acidentes acid = new Acidentes();

            Console.Write("Qtd de dias sem acidentes: ");
            int dia = int.Parse(Console.ReadLine());

            acid.qtdAcidentes(dia);

        }
    }
}





