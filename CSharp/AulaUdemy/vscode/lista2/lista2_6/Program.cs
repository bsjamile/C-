using System.Globalization;

Console.WriteLine("Quantos números deseja verificar? ");
int n = int.Parse(Console.ReadLine());

string resp;

for (int i = 0; i < n; i++)
{
    Console.Write("Digite um valor qualquer:");
    float.TryParse(Console.ReadLine(), out float num);

    if ((num >= 0) && (num <= 25))
    {
        resp = "Intervalo [0,25]";
    }
    else if ((num >= 0) && (num <= 50))
    {
        resp = "Intervalo (25,50)";
    }
    else if ((num >= 0) && (num <= 75))
    {
        resp = "Intervalo (50,75]";
    }
    else if ((num >= 0) && (num <= 100))
    {
        resp = "Intervalo (75,100]";
    }
    else
    {
        resp = "Fora de intervalo";
    }

    Console.WriteLine(resp);
}