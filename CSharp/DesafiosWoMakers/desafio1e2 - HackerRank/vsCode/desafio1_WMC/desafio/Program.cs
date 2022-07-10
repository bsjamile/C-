string palavra = Console.ReadLine();

string palavraInvertida = "";
int tamanhoPalavra = palavra.Length;
int invert = palavra.Length - 1; 

for (int i = 0; i < tamanhoPalavra; i++)
{
    palavraInvertida += palavra[invert - i].ToString();
}

int mudancas = 0;
for (int normal = 0; normal < invert; normal++, invert--)
{
    if (palavra[normal] != palavra[invert])
    {
        mudancas++;
    }
}

string verificacao;
if (palavra == palavraInvertida)
{
    verificacao = "TRUE";
}
else
{
    verificacao = "FALSE";
}
Console.WriteLine($"{verificacao} - {mudancas}");