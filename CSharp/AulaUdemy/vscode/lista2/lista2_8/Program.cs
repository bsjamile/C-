using System.Globalization;

Console.Write("Quantos vezes? ");
int.TryParse(Console.ReadLine(), out int n);

float imposto = 0.0f;

for (int i = 0; i < n; i++)
{
    Console.Write("Digite o valor: ");
    float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (valor <= 2000)
    {
        imposto = 0.0f;
    }
    else if (valor <= 3000)
    {
        imposto = (valor - 2000) * 0.08f;
    }
    else if (valor <= 4500)
    {
        imposto = ((1000 * 0.08f) + ((valor - 3000) * 0.18f));
    }
    else
    {
        imposto = ((1000 * 0.08f) + (1500 * 0.18f) + ((valor - 4500) * 0.28f));
    }

    if(imposto <= 0.0f)
    {
        Console.WriteLine("Isento");
    }
    else
    {
        Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}