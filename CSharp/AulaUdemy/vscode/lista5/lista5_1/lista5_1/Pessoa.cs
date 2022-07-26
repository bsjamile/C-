namespace lista5_1
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public void MaisVelha(int idade1, int idade2, string nome1, string nome2)
        {
            string velha;

            if (idade1 > idade2)
            {
                velha = nome1;
            }
            else if (idade2 > idade1)
            {
                velha = nome2;
            }
            else
            {
                velha = "possuem a mesma idade";
            }
            Console.WriteLine($"Pessoa mais velha: {velha}");
        }
    }
}
