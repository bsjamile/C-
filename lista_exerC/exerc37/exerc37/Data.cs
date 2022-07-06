using System;


namespace exerc37
{
    internal class Data
    {
        public void CalcNasc(int anoN, int anoA)
        {
            int idadeA = anoA - anoN;
            int idadeM = idadeA * 12;
            int idadeD = idadeM * 30;
            int idadeS = idadeM * 4;

            Console.WriteLine();
            Console.Write($"Idade em Anos: {idadeA}\nIdade em Meses: {idadeM}\nIdade em Dias: {idadeD}\n Idade em Semanas: {idadeS}");
        }
    }
}
