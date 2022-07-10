int maiorNumero = 0;
int menorNumero = 0;
long soma = 0;
for (int i = 0; i < arr.Count; i++)
{
    soma += arr[i];
    if (i == 0 || arr[i] > maiorNumero)
        maiorNumero = arr[i];
    if (i == 0 || arr[i] < menorNumero)
        menorNumero = arr[i];
}
Console.WriteLine($"{soma - maiorNumero} {soma - menorNumero}");