using System;
Console.WriteLine("Digite a quantidade de clientes que você deseja cadastrar");
int qtd = Convert.ToInt32(Console.ReadLine());
var clientesArr = new Pessoa[qtd];
for (int i = 0; i < qtd; i++)
{
    Console.WriteLine("Digite o Nome do Cliente:");
    string nomeDoCliente = Console.ReadLine();
    Console.WriteLine("Digite o email do Cliente:");
    string emailDoCliente = Console.ReadLine();
    clientesArr[i] = new Pessoa(nomeDoCliente, emailDoCliente);
    Console.WriteLine("Digite o logradouro:");
    string logradouro = Console.ReadLine();
    Console.WriteLine("Digite o numero:");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite S/N se tem complemento?");
    var sOuN = Console.ReadLine();

    char sOuNCh = char.ToUpper(sOuN[0]);

        if (sOuNCh == 'S')
    {
        Console.WriteLine("Digite o complemento:");
        var complemento = Console.ReadLine();
        clientesArr[i].endereco = new Endereco(logradouro, numero, complemento);
    }
    else
    {
        clientesArr[i].endereco = new Endereco(logradouro, numero);
    }
}
Console.WriteLine("esses são os seus clientes:");
foreach (var item in clientesArr)
{
    item.ImprimePessoa();
}
/*
perguntar pro usuário se tem complemento o endereco dele, S/N
caso ele responda N, chame o construtor de endereco que você vai escrever que recebe somente 2 parametros
caso ele responda S, pergunte o complemento e chame o construtor que já existe na classe endereco*/
