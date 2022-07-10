Console.WriteLine("Quantas partidas deseja saber? (escreva na mesma linha entre espaços)");
int.TryParse(Console.ReadLine(), out int n);

for (int i =0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int.TryParse(valores[0], out int horaInicial);
    int.TryParse(valores[1], out int horaFinal);

    int duracao;
    if (horaInicial < horaFinal)
    {
        duracao = horaFinal - horaInicial;
    }
    else
    {
        duracao = 24 - horaInicial + horaFinal;
    }

    Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
}

