namespace EnumSwitch
{
    class program
    {

        enum Cor {Azul, Verde, Amarelo, Vermelho}
        enum Opcao {Criar = 1, Deletar, Editar, Listar, Atualizar}
        //nome do enum sempre no singular

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você quer deletar algo!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você quer editar algo!");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você quer listar algo!");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Você quer atualizar algo!");
                    break;
                default:
                    Console.WriteLine("Essa opção não existe!");
                    break;
            }

        }
    }
}