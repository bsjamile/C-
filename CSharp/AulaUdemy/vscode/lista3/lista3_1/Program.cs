Console.Write("Digite a senha: ");
int.TryParse(Console.ReadLine(), out int senha);

while (senha != 2002)
{
    Console.WriteLine("Senha Inválida!");
    Console.Write("Digite a senha: ");
    int.TryParse(Console.ReadLine(), out senha);

}
Console.Write("Acesso Permitido!");